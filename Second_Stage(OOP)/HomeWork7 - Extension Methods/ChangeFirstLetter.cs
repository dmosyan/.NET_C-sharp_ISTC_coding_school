using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public static class ChangeFirstLetter
    {
        //Method will change first letter case (from lowercase to uppercase and vise a versa)

        public static string FirstLetterCase(this string input)
        {
            if (input.Length > 0)
            {
                char[] charArray = input.ToCharArray();
                charArray[0] = char.IsLower(charArray[0]) ? char.ToUpper(charArray[0]) : char.ToLower(charArray[0]);
                return new string(charArray);   
            }
            return input;
        }

    }
}
