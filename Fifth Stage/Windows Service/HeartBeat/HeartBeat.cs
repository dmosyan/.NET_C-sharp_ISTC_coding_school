using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace HeartBeat
{
    public class HeartBeat
    {
        private readonly Timer _timer;

        public HeartBeat()
        {
            _timer = new Timer(10000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\Users\David\Desktop\Windows Services with .NET\HeartBeat\Log_File\HeartBeat.txt", lines);
        }

        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop();
        }

    }
}
