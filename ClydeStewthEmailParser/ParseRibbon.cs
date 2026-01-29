using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using ClydeStewthEmailParser.Scripts;



namespace ClydeStewthEmailParser
{
    public partial class ParseRibbon
    {
        private SearchForm searchForm = null;

        private readonly string configFilename = "config.json";

        private void ParseRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void parse1_Click(object sender, RibbonControlEventArgs e)
        {
            if(searchForm != null)
            {
                searchForm.Close();
            }
            searchForm = new SearchForm();
            searchForm.Show();
        }

        //export
        private void configure1_Click(object sender, RibbonControlEventArgs e)
        {

            DataManager dm = new DataManager(configFilename);
            Config test = dm.LoadCachedConfig<Config>();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "JSON (*.json)|*.json";

            string filePath = "";
            saveFileDialog.RestoreDirectory = true;

            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }

            
            dm.ExportConfig(test, filePath);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        //import
        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "JSON (*.json)|*.json";

            string filePath = "";
            openFileDialog.RestoreDirectory = true;

            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            DataManager dm = new DataManager(configFilename);
            Config config = dm.ImportConfig<Config>(filePath);
            dm.CacheConfig(config);
            Debug.WriteLine(config.Filters[0].Name);
        }
    }
}

//configuration:
/*[                                                       (X) ]
 *      +++++++++++++++++++++++++++++++++++++++++++++++     |
 *      [                Logic Name                   ]     |
 *      [                   Filter                    ]     |
 *      [  (Source)                   (Regex)         ]     |
 *      [                   +                         ]     |
 *      -----------------------------------------------     |
 *      [                   Parse                     ]     |
 *      [  (Source)   (Regex)   (Group ID) (Priority) ]     |
 *      [                   +                         ]     |
 *      +++++++++++++++++++++++++++++++++++++++++++++++     |
 *      [                   +                         ]     |
 *      +++++++++++++++++++++++++++++++++++++++++++++++     |
 *                                                          O
 *                                                          |
 *                                                          |
 *                                                          |
 *[  (Import from file)                     (Export to file)  ] 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */