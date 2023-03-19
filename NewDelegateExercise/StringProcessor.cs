using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDelegateExercise
{
    internal class StringProcessor
    {
        public delegate string StringDelegate(string input);
        public string ProcessString(string str, StringDelegate strDelegate)
        {
            return strDelegate(str);
        }
        public string UpperCaseStr(string str)
        {
           return str.ToUpper();
        }
        public string LowerCaseStr(string str)
        {
            return str.ToLower();
        }
        public string ReverseStr(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
