using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;



namespace ClydeStewthEmailParser.Scripts
{
    internal static class Search
    {
        public static DataTable SearchFolder(Config config, string[] filterNames, DateTime start, DateTime end, int emailLimit = 100, bool desc = true, bool date = true, bool id = true)
        {
            Debug.WriteLine(start.ToString());
            Debug.WriteLine(end.ToString());
            Debug.WriteLine(emailLimit.ToString());
            Debug.WriteLine(desc);

            List<Filter> filters = GetFiltersByName(config, filterNames);
            IEnumerable<Outlook.MailItem> emails = GetAllEmailsFromSelectedFolder(start, end, emailLimit, desc);

            //List<StringMatch[]> allSubstrings = GetSubstrings(emails, filters);
            List<Dictionary<string, StringMatch>> records = GetSubstrings(emails, filters);

            //Debug.WriteLine(allSubstrings.Count);
            Debug.WriteLine(records.Count);

            DataTable dt = new DataTable();


            foreach(Dictionary<string, StringMatch> rec in records)
            {
                DataRow dr = dt.NewRow();

                foreach (KeyValuePair<string, StringMatch> kvp in rec)
                {
                    
                }
            }


            return dt;
        }

        public static Outlook.MAPIFolder GetCurrentFolder()
        {
            Outlook.Explorer explorer = Globals.ThisAddIn.Application.ActiveExplorer();

            if (explorer != null)
            {
                Outlook.MAPIFolder selectedFolder = explorer.CurrentFolder;
                return selectedFolder;
            }

            return null;
        }

        private static string[] GetColumnNames(List<Filter> filters)
        {
            return null;
        }


        private static List<Dictionary<string, StringMatch>> GetSubstrings(IEnumerable<Outlook.MailItem> emails, List<Filter> filters)
        {
            List<StringMatch[]> allSubstrings = new List<StringMatch[]>();
            List<Dictionary<string, StringMatch>> records = new List<Dictionary<string, StringMatch>>();

            foreach (Outlook.MailItem email in emails)
            {
                Dictionary<string, StringMatch> filterResults = new Dictionary<string, StringMatch>();

                for (int i = 0; i < filters.Count; i++)
                {
                    Filter filter = filters[i];


                    bool detect = DetectEmail(email, filter.Detect);


                    List<StringMatch> substrings = new List<StringMatch>();

                    for (int j = 0; j < filter.Extract.Length; j++) 
                    {
                        Parsing parsing = filter.Extract[j];

                        string column = string.Format("{0} - {1}", filter.Name.Length == 0 ? i.ToString() : filter.Name, parsing.Name.Length == 0 ? j.ToString() : parsing.Name);
                        filterResults.Add(column, null);

                        if (!detect) continue;

                        string txt = GetSource(email, parsing.Source);
                        Match sub = Regex.Match(txt, parsing.Regex);


                        StringMatch stringMatch = null;
                        if (sub.Success)
                        {
                            stringMatch = new StringMatch(sub.Value, parsing, email);
                        }

                        filterResults[column] = stringMatch;
                        substrings.Add(stringMatch);
                    }

                    //List<StringMatch> substrings = ExtractEmail(email, filter.Extract);

                    if (substrings.Count == 0) continue;

                    foreach (StringMatch sm in substrings)
                    {
                        Debug.WriteLine(sm.SubString + " from " + sm.Parsing.Name);
                    }

                    allSubstrings.Add(substrings.ToArray());
                    records.Add(filterResults);
                }

                Marshal.ReleaseComObject(email);
            }

            //return allSubstrings;
            return records;
        }

        private static List<StringMatch> ExtractEmail(MailItem email, Parsing[] extract)
        {
            List<StringMatch> substrings = new List<StringMatch>();

            foreach (Parsing parsing in extract)
            {
                string txt = GetSource(email, parsing.Source);
                Match sub  = Regex.Match(txt, parsing.Regex);


                StringMatch stringMatch = null;
                if (sub.Success)
                {
                    stringMatch = new StringMatch(sub.Value, parsing, email);
                }

                substrings.Add(stringMatch);
            }

            return substrings;
        }

        private static bool DetectEmail(MailItem email, Parsing[] detect)
        {
            foreach (Parsing parsing in detect)
            {
                string txt = GetSource(email, parsing.Source);
                if (!parsing.Match(txt))
                {
                    return false;
                }
            }
            return true;
        }

        private static string GetSource(MailItem email, string source)
        {
            switch (source)
            {
                case "subject":
                    {
                        return email.Subject;
                    }
                case "body":
                    {
                        return email.Body;
                    }
                case "sender":
                    {
                        return email.SenderEmailAddress;
                    }
                default:
                    {
                        return email.Subject;
                    }
            }
        }

        private static List<Filter> GetFiltersByName(Config config, string[] filterNames)
        {
            List<Filter> filters = new List<Filter>();
            foreach(string name in filterNames)
            {
                foreach (Filter filter in config.Filters)
                {
                    if (filter.Name == name)
                    {
                        filters.Add(filter);
                    }
                }
            }
            return filters;
        }

        private static IEnumerable<Outlook.MailItem> GetAllEmailsFromSelectedFolder(DateTime start, DateTime end, int emailLimit = 1000, bool desc = true)
        {
            Outlook.Explorer explorer = Globals.ThisAddIn.Application.ActiveExplorer();

            if (explorer != null)
            {
                Outlook.MAPIFolder selectedFolder = explorer.CurrentFolder;

                if (selectedFolder != null)
                {
                    Outlook.Items items = selectedFolder.Items;
                    
                    //Filter: only emails AND after start date AND before end date
                    string filter = "[MessageClass] = 'IPM.Note' AND [ReceivedTime] >= '" + start.ToString("g") + "' AND [ReceivedTime] <= '" + end.ToString("g") + "'";
                    
                    Outlook.Items restrictedItems = items.Restrict(filter);
                    
                    restrictedItems.Sort("[ReceivedTime]", desc);
                    
                    int count = emailLimit > restrictedItems.Count ? restrictedItems.Count : emailLimit;
                    
                    int i = 1;
                    
                    do
                    {
                        if (restrictedItems[i] is Outlook.MailItem mailItem)
                        {
                            i++;
                            yield return mailItem;
                        }
                    } while(i <= count);
                }
            }
        }

        public class StringMatch
        {
            public readonly string SubString;
            public readonly Parsing Parsing;
            public readonly MailItem Email;

            public StringMatch(string substring, Parsing parsing, MailItem email)
            {
                SubString = substring;
                Parsing = parsing;
                Email = email;
            }
        }

        public class Record
        {

        }
    }
}


//no cache causes error
//no emails causes error