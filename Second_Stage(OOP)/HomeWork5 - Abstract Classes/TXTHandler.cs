using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change the TXT file");
        }

        public override void Create()
        {
            Console.WriteLine("Create a new TXT file"); ;
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT file");
        }

        public override void Save()
        {
            Console.WriteLine("TXT file saved");
        }
    }
}
