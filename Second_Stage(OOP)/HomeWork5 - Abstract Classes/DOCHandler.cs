using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change the DOC file");
        }

        public override void Create()
        {
            Console.WriteLine("Create a new DOC file"); ;
        }

        public override void Open()
        {
            Console.WriteLine("Open DOC file");
        }

        public override void Save()
        {
            Console.WriteLine("DOC file saved");
        }
    }
}
