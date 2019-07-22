using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            DOCHandler docFile = new DOCHandler();
            TXTHandler txtFile = new TXTHandler();
            XMLHandler xmlFile = new XMLHandler();

            BEGINNING:
            Console.WriteLine("Please enter a file name which you want to open");
            string input1 = Console.ReadLine();
            if(input1.Substring(input1.Length - 4) == ".txt")
            {
                Console.WriteLine("You cose TXT file");
                Console.WriteLine("Write 'o' if you want to open file, for going back write 'b'");
                string input2 = Console.ReadLine();
                if(input2 == char.ConvertFromUtf32('b'))
                {
                    goto BEGINNING;
                }
                if(input2 == char.ConvertFromUtf32('o'))
                {
                    PART2:
                    Console.WriteLine("You can creat a new file ('c'), change ('g') and save ('s') file");
                    string input3 = Console.ReadLine();
                    if(input3 == char.ConvertFromUtf32('c'))
                    {
                        Console.WriteLine("New file created, press 's' for saving, else write 'b' for going back");
                        string input4 = Console.ReadLine();
                        if (input4 == char.ConvertFromUtf32('s'))
                        {
                            txtFile.Save();
                        }
                        else if (input4 == char.ConvertFromUtf32('b'))
                        {
                            goto PART2;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid command");
                            goto PART2;
                        }
                    }
                    else if(input3 == char.ConvertFromUtf32('g'))
                    {
                        txtFile.Change();
                        Console.WriteLine("File Changed, press 's' for saving, else write 'b' for going back");
                        string input4 = Console.ReadLine();
                        if (input4 == char.ConvertFromUtf32('s'))
                        {
                            txtFile.Save();
                        }
                        else if (input4 == char.ConvertFromUtf32('b'))
                        {
                            goto PART2;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid command");
                            goto PART2;
                        }
                    }
                    else if(input3 == char.ConvertFromUtf32('s'))
                    {
                        txtFile.Save();
                        Console.WriteLine("press 'e' if you want to exit, or press 'o' for opening new file");
                        string input5 = Console.ReadLine();
                        if(input5 == char.ConvertFromUtf32('e'))
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }

            else if (input1.Substring(input1.Length - 4) == ".xml")
            {
                Console.WriteLine("You cose XML file");
                Console.WriteLine("Write 'o' if you want to open file, for going back write 'b'");
                string input2 = Console.ReadLine();
                if (input2 == char.ConvertFromUtf32('b'))
                {
                    goto BEGINNING;
                }
                if (input2 == char.ConvertFromUtf32('o'))
                {
                    PART3:
                    Console.WriteLine("You can creat a new file ('c'), change ('g') and save ('s') file");
                    string input6 = Console.ReadLine();
                    if (input6 == char.ConvertFromUtf32('c'))
                    {
                        Console.WriteLine("New file created, press 's' for saving, else write 'b' for going back");
                        string input4 = Console.ReadLine();
                        if (input4 == char.ConvertFromUtf32('s'))
                        {
                            xmlFile.Save();
                        }
                        else if (input4 == char.ConvertFromUtf32('b'))
                        {
                            goto PART3;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid command");
                            goto PART3;
                        }
                    }
                    else if (input6 == char.ConvertFromUtf32('g'))
                    {
                        xmlFile.Change();
                        Console.WriteLine("File Changed, press 's' for saving, else write 'b' for going back");
                        string input7 = Console.ReadLine();
                        if (input7 == char.ConvertFromUtf32('s'))
                        {
                            xmlFile.Save();
                        }
                        else if (input7 == char.ConvertFromUtf32('b'))
                        {
                            goto PART3;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid command");
                            goto PART3;
                        }
                    }
                    else if (input6 == char.ConvertFromUtf32('s'))
                    {
                        xmlFile.Save();
                        Console.WriteLine("press 'e' if you want to exit, or press 'o' for opening new file");
                        string input8 = Console.ReadLine();
                        if (input8 == char.ConvertFromUtf32('e'))
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }

            else if (input1.Substring(input1.Length - 4) == ".doc")
            {
                Console.WriteLine("You cose DOC file");
                Console.WriteLine("Write 'o' if you want to open file, for going back write 'b'");
                string input2 = Console.ReadLine();
                if (input2 == char.ConvertFromUtf32('b'))
                {
                    goto BEGINNING;
                }
                if (input2 == char.ConvertFromUtf32('o'))
                {
                PART4:
                    Console.WriteLine("You can creat a new file ('c'), change ('g') and save ('s') file");
                    string input9 = Console.ReadLine();
                    if (input9 == char.ConvertFromUtf32('c'))
                    {
                        Console.WriteLine("New file created, press 's' for saving, else write 'b' for going back");
                        string input10 = Console.ReadLine();
                        if (input10 == char.ConvertFromUtf32('s'))
                        {
                            docFile.Save();
                        }
                        else if (input10 == char.ConvertFromUtf32('b'))
                        {
                            goto PART4;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid command");
                            goto PART4;
                        }
                    }
                    else if (input9 == char.ConvertFromUtf32('g'))
                    {
                        docFile.Change();
                        Console.WriteLine("File Changed, press 's' for saving, else write 'b' for going back");
                        string input11 = Console.ReadLine();
                        if (input11 == char.ConvertFromUtf32('s'))
                        {
                            xmlFile.Save();
                        }
                        else if (input11 == char.ConvertFromUtf32('b'))
                        {
                            goto PART4;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid command");
                            goto PART4;
                        }
                    }
                    else if (input9 == char.ConvertFromUtf32('s'))
                    {
                        docFile.Save();
                        Console.WriteLine("press 'e' if you want to exit, or press 'o' for opening new file");
                        string input12 = Console.ReadLine();
                        if (input12 == char.ConvertFromUtf32('e'))
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please choose XML, TXT or DOC type documents");
                        goto BEGINNING;
                    }
                }
            }

        }
    }
}
