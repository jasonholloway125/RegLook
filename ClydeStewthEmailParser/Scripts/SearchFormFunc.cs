using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClydeStewthEmailParser.Scripts
{
    internal class SearchFormFunc
    {
        public SearchForm SearchForm
        {
            get; private set; 
        }
        public CheckedListBox CheckedListBox
        {
            get; private set; 
        }

        public Config Config
        {
            get; private set;
        }

        public SearchFormFunc(Config config)
        {
            SearchForm = new SearchForm();
            CheckedListBox = GetCheckListBox();
            Config = config;
            UpdateCheckedList();
            
        }

        public SearchFormFunc(SearchForm searchForm, Config config)
        {
            SearchForm = searchForm;
            CheckedListBox = GetCheckListBox();
            Config = config;
            UpdateCheckedList();
        }

        public void UpdateCheckedList()
        {
            CheckedListBox.Items.Clear();
            foreach (Filter f in Config.Filters)
            {
                CheckedListBox.Items.Add(f.Name);
                
                
            }
        }

        public CheckedListBox GetCheckListBox()
        {
            foreach (Control control in SearchForm.Controls)
            {
                if (control is CheckedListBox clb)
                {
                    return clb;
                }
            }
            return null;
        }

        public string[] GetCheckedItems()
        {
            int count = CheckedListBox.CheckedItems.Count;
            if (count == 0) return null;

            string[] checkedRtn = new string[CheckedListBox.CheckedItems.Count];
            for (int i = 0; i < count; i++)
            {
                checkedRtn[i] = CheckedListBox.CheckedItems[i].ToString();
            }

            return checkedRtn;
        }
    }
}
