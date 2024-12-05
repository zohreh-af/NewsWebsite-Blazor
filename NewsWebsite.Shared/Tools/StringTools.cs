using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system
{
    public static class StringTools
    {
        public static bool HasValue(this string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                return true;
            }
            return false;
        }

        public static bool HasNoValue(this string s) => !HasValue(s);

    }
}
