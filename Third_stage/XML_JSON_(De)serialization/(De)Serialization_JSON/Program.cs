using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace _De_Serialization_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Books_json_ book = File.Exists("book.json") ? JsonConvert.DeserializeObject<Books_json_>(File.ReadAllText("book.json")) : new Books_json_
            {
                Name = "Harry Potter",
                Author = "Joan Rolling",
                Raiting = 9.7,
                Pages = 317
            };

            File.WriteAllText("book.json", JsonConvert.SerializeObject(book));

            var deSerJson = JsonConvert.DeserializeObject<Books_json_>(File.ReadAllText("book.json"));
            Console.ReadKey();

        }
    }
}
