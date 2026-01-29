using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeStewthEmailParser.Scripts
{
    [Serializable]
    public class SearchSettings
    {
        public int EmailLimit;
        public bool Descending;
        public string StartDate;
        public string EndDate;
        public bool ToggleDate;
        public bool ToggleID;

        public SearchSettings(int emailLimit, bool descending, string startDate, string endDate, bool toggleDate, bool toggleID)
        {
            EmailLimit = emailLimit;
            Descending = descending;
            StartDate = startDate;
            EndDate = endDate;
            ToggleDate = toggleDate;
            ToggleID = toggleID;
        }
    }
}
