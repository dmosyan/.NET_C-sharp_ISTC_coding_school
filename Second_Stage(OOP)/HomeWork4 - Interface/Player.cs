using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Player : IRecordable, IPlayer
    {
       public void Record()
        {
            Console.WriteLine("Recording is started");
        }
        public void Pause()
        {
            Console.WriteLine("Recording is paused");
        }
        public void Stop()
        {
            Console.WriteLine("Recording is finished");
        }
        public void Resume()
        {
            Console.WriteLine("Recording is resumed");
        }



        public void Play()
        {
            Console.WriteLine("Music is playing");
        }
        void IPlayer.Pause()
        {
            Console.WriteLine("Music is paused");
        }
        void IPlayer.Stop()
        {
            Console.WriteLine("The music is stoped");
        }
        void IPlayer.Resume()
        {
            Console.WriteLine("Playing is resumed");
        }
    }
}
