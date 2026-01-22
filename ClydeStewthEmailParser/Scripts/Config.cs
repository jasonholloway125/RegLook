using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ClydeStewthEmailParser
{
    [Serializable]
    public class Config
    {
        public Filter[] Filters;

    }

    [Serializable]
    public class Filter
    {
        public string Name;
        public Parsing[] Detect;
        public Parsing[] Extract;
    }

    [Serializable]
    public class Parsing
    {
        public string Name;
        public string Regex;
        public string Source;

        private Regex regexObj;

        public bool Match(string txt)
        {
            if (regexObj == null) regexObj = new Regex(Regex);
            return regexObj.IsMatch(txt);
        }
    }
}
