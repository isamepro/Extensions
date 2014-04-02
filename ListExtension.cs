using System;
using System.Collections.Generic;
using System.Linq;

namespace IsameprO
{
    public static class ListExtension
    {
        /// <summary>
        /// Check if List is null or empty
        /// </summary>
        /// <param name="liste"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this System.Collections.IList liste)
        {
            return (liste == null || liste.Count == default(int));
        }
    }
}
