using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change the XML file");
        }

        public override void Create()
        {
            Console.WriteLine("Create a new XML file"); ;
        }

        public override void Open()
        {
            Console.WriteLine("Open XML file");
        }

        public override void Save()
        {
            Console.WriteLine("XML file saved");
        }
    }
}
