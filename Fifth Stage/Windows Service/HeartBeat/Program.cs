using System;
using Topshelf;

namespace HeartBeat
{
    class Program
    {
        static void Main(string[] args)
        {
            TopshelfExitCode exitCode = HostFactory.Run(x =>
            {
                x.Service<HeartBeat>(s =>
                {
                    s.ConstructUsing(heartbeat => new HeartBeat());
                    s.WhenStarted(heartbeat => heartbeat.Start());
                    s.WhenStopped(heartbeat => heartbeat.Stop());
                });

                x.RunAsLocalSystem();
                x.SetServiceName("HeartBeatService");
                x.SetDisplayName("HeartBeat Service");
                x.SetDescription("Test service");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
