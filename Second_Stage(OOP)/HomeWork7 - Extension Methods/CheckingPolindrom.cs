using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public static class CheckingPolindrome
    {
        //Checking if we have poilindrom
        public static string CheckIfPolindrome(this string inputString)
        {
            string reversedString = "";
            if (inputString.Length > 0)
            {
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    reversedString += inputString[i].ToString();
                }
                if (reversedString == inputString)
                {
                    return "String is polindrome";
                }
                return "String is not polindrome";
            }
            else
                return "String is empty";
        }
    }
}
