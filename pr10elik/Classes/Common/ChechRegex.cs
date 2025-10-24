using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pr10elik.Classes.Common
{
    public class ChechRegex
    {
        public static bool Match(string Pattern, string Input)
        {
            Match m = Regex.Match(Input, Pattern);
            return m.Success;
        }
    }
}
