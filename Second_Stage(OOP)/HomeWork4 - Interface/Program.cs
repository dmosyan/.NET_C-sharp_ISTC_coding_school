using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("You can play the music and also record");
            while (true)
            {
                BEGINING:
                Console.WriteLine("Write 'r' if you want to start recording, or write 'p' if you want to start playing");
                Console.WriteLine("For exit write 'e' ");
                string input1 = Console.ReadLine();

                if (input1 == char.ConvertFromUtf32('r'))
                {
                    player.Record();
                    PAUSEorSTOP2:
                    Console.WriteLine("Write 's' if you want to stop the recording, write 'p' if you want to pause");
                    string input2 = Console.ReadLine();
                    if (input2 == char.ConvertFromUtf32('s'))
                    {
                        player.Stop();
                        goto BEGINING;
                    }
                    if (input2 == char.ConvertFromUtf32('p'))
                    {
                        player.Pause();   
                        Console.WriteLine("Press 'r' to resume the recording or press 's' to stop the recording");
                        string input4 = Console.ReadLine();
                        if (input4 == char.ConvertFromUtf32('r'))
                        {
                            player.Resume();
                            goto PAUSEorSTOP2;
                        }
                        if (input4 == char.ConvertFromUtf32('s'))
                        {
                            player.Stop();
                            goto BEGINING;
                        }

                    }
                }

                else if (input1 == char.ConvertFromUtf32('p'))
                {
                    player.Play();
                    PAUSEorSTOP:
                    Console.WriteLine("Write 's' if you want to stop the music, write 'p' if you want to pause");
                    string input3 = Console.ReadLine();
                    if (input3 == char.ConvertFromUtf32('s'))
                    {
                        IPlayer player1 = (player as IPlayer);
                        player1.Stop();
                    }
                    if (input3 == char.ConvertFromUtf32('p'))
                    {
                        IPlayer player2 = (player as IPlayer);
                        player2.Pause();
                        
                        Console.WriteLine("Press 'r' to resume the music or press 's' to finish the listening");
                        string input5 = Console.ReadLine();
                        if (input5 == char.ConvertFromUtf32('r'))
                        {
                            IPlayer player3 = (player as IPlayer);
                            player3.Resume();
                            goto PAUSEorSTOP;
                        }
                        if (input5 == char.ConvertFromUtf32('s'))
                        {
                            IPlayer player4 = (player as IPlayer);
                            player4.Stop();
                            goto BEGINING;
                            
                        }

                    }
                }
                else if (input1 == char.ConvertFromUtf32('e'))
                {
                    break;

                }

                else
                {
                    Console.WriteLine("Please enter 'r' or 'p'");
                }
            }
            
        }
    }
}
