using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
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
        public static void SearchFolder(Config config, string[] filterNames, DateTime start, DateTime end, int emailLimit, bool desc)
        {
            Debug.WriteLine(start.ToString());
            Debug.WriteLine(end.ToString());
            Debug.WriteLine(emailLimit.ToString());
            Debug.WriteLine(desc);

            List<Filter> filters = GetFiltersByName(config, filterNames);
            IEnumerable<Outlook.MailItem> emails = GetAllEmailsFromSelectedFolder(start, end, emailLimit, desc);

            List<StringMatch[]> allSubstrings = GetSubstrings(emails, filters);

            Debug.WriteLine(allSubstrings.Count);


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


        private static List<StringMatch[]> GetSubstrings(IEnumerable<Outlook.MailItem> emails, List<Filter> filters)
        {
            List<StringMatch[]> allSubstrings = new List<StringMatch[]>();

            foreach (Outlook.MailItem email in emails)
            {
                foreach (Filter filter in filters)
                {

                    if (!DetectEmail(email, filter.Detect)) continue;


                    List<StringMatch> substrings = ExtractEmail(email, filter.Extract);

                    if (substrings.Count == 0) continue;

                    foreach (StringMatch sm in substrings)
                    {
                        Debug.WriteLine(sm.SubString + " from " + sm.Parsing.Name);
                    }

                    allSubstrings.Add(substrings.ToArray());
                }

                Marshal.ReleaseComObject(email);
            }

            return allSubstrings;
        }

        private static List<StringMatch> ExtractEmail(MailItem email, Parsing[] extract)
        {
            List<StringMatch> substrings = new List<StringMatch>();

            foreach (Parsing parsing in extract)
            {
                string txt = GetSource(email, parsing.Source);
                Match sub  = Regex.Match(txt, parsing.Regex);

                if (!sub.Success) continue;

                StringMatch stringMatch = new StringMatch(sub.Value, parsing, email);
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
    }
}
