using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public static class CountDuplicates
    {
        //Counts how many duplicate items we have
        public static int CountDuplicate(this int[] arrinput)
        {
            if(arrinput.Length != arrinput.Distinct().Count())
            {
                return arrinput.Length - arrinput.Distinct().Count();
            }
            return 0;
        }
    }
}
