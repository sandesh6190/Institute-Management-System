using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thsemprj1.Extensions
{
    public static class StringExtensions
    {
        public static string ValueOrNull(this string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            return value;
        }
    }
}
