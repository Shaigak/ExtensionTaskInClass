using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeTasks12._21._2022.Helpers
{
    public static class Extensions
    {
        public static int Getnum(this int num)
        {
            
            return num;
        }

        public static bool CheckString(this string text,string patern)
        {
            return Regex.IsMatch(text, patern);
        }


    }
}
