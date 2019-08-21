using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;

namespace _De_Serialization_JSON
{

    public class Books_json_
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Raiting { get; set; }
        public int Pages { get; set; }     
    }
}
