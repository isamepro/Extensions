using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Globalization;

namespace IsameprO
{
    public static class StringExtension
    {
        /// <summary>
        /// Check if string value is numeric
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string value)
        {
            float resultat;
            return float.TryParse(value, out resultat);
        }
        
        
      
    }
}
