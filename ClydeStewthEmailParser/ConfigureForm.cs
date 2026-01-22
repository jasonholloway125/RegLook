using ClydeStewthEmailParser.Scripts;
using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace ClydeStewthEmailParser
{
    public partial class SearchForm : Form
    {
        private SearchFormFunc sff;
        private TextBox folderTitle;
        private Button searchB;
        private NumericUpDown emaiLimitNUD;
        private CheckBox descendingCB;
        private DateTimePicker startDTP;
        private DateTimePicker endDTP;

        public SearchForm()
        {
            InitializeComponent();

            Panel panel = (Panel)GetControlByName("optionsPanel", this);
            folderTitle = (TextBox)GetControlByName("folderNameTextBox", panel);
            searchB = (Button)GetControlByName("searchButton", panel);
            emaiLimitNUD = (NumericUpDown)GetControlByName("emaiLimitNumericUpDown", panel);
            descendingCB = (CheckBox)GetControlByName("descendingCheckBox", panel);
            startDTP = (DateTimePicker)GetControlByName("startDateTimePicker", panel);
            endDTP = (DateTimePicker)GetControlByName("endDateTimePicker", panel);

            DataManager dm = new DataManager();

            Config config = dm.LoadCachedConfig();
            sff = new SearchFormFunc(this, config);

            ThisAddIn addInInstance = Globals.ThisAddIn;
            addInInstance.UpdateForm(this);

            UpdateTitle();
        }

        public void UpdateTitle()
        {
            folderTitle.Text = Search.GetCurrentFolder().FolderPath.Substring(2);
        }

        private Control GetControlByName(string name, Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            
            return null;
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] checkedItems = sff.GetCheckedItems();

            DateTime start = startDateTimePicker.Value;
            DateTime end = endDateTimePicker.Value;
            int emailLimit = (int)emaiLimitNUD.Value;
            bool desc = descendingCB.Checked;
            
            Search.SearchFolder(sff.Config, checkedItems, start, end, emailLimit, desc);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sff.CheckedListBox.CheckedItems.Count > 0)
            {
                searchB.Enabled = true;
            }
            else
            {
                searchB.Enabled = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toggleIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
