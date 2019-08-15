using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            int folder_count = 0;
            string rootPath = @"C:\RootPath";
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            Console.WriteLine("All directories in the root folder");
            foreach  (string dir in dirs)
            {
                Console.WriteLine(dir);
                folder_count++;
            }
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"folder count: {folder_count}");


            long lenght_count = 0;
            int files_count = 0;
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            Console.WriteLine("\nAll files in the root directory");
            foreach (string file in files)
            {
                var info = new FileInfo(file);
                lenght_count += info.Length;
                Console.WriteLine(file + " " + info.Length + " bytes");
                files_count++;

                //Console.WriteLine(Path.GetFileName(file)) //Prints only the names
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file)); //Prints the names without extensions
            }
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"files count: {files_count}");
            Console.WriteLine($"Total files size: {lenght_count} bytes");

            //Creating subfolder and moving the files from the root folder to the created subfolder
            string path = @"C:\RootPath\SubFolder2\Sub2SubFolder"; //the folder doesn't exist
            bool folderExists = Directory.Exists(path);

            if (!folderExists)
            {
                Directory.CreateDirectory(path);
            }
            Console.WriteLine("\nSub2SubFolder folder exists");
            string[] files2 = Directory.GetFiles(rootPath);
            foreach (string file in files2)
            {
                File.Move(file, $"{path}{Path.GetFileName(file)}");
            }


        }
    }
}
