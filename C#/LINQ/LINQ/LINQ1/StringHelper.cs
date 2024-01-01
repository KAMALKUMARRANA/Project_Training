using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    
    public static class StringHelper
    {
        //extension method
        public static string changeFirstLetterCase(this string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                char[] charArray=inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray); 
            }
            return inputString;
          
        }

        public static int PlusNumber(this int input,int inc)
        {
            if(input != 0)
            {
                return input+inc;
            }
            return input;
        }
    }
}
