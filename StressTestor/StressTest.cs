using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StressTestor
{
    delegate void Log(string message);
    internal class StressTest
    {
        int threads;
        int delay;
        int repeatCount;
        bool active = true;
        public StressTest(int threads=10, int delay=1000, int repeatCount=10)
        {
            this.threads = threads;
            this.delay = delay;
            this.repeatCount = repeatCount;
        }

        public Log Log;
        

        public void Go(string URL)
        {
            List<Task> tasks = new List<Task>();
            for(int i = 0; i < threads; i++)
            {
                Task t = new Task(() =>
                {
                    for(int i = 0; i < repeatCount; i++)
                    {
                        if (active)
                        {
                            WebClient c = new WebClient();
                            Log($"Loading {URL}: {i+1} / {repeatCount}");
                            byte[] result = c.DownloadData(URL);
                            Log($"Result from {URL}: {result.Count()} bytes");
                            Thread.Sleep(delay);
                        } else
                        {
                            Log("Stopping");
                            break;
                        }
                    }
                    
                });
                
                tasks.Add(t);
                t.Start();
            }
            
        }

        public void Stop()
        {
            active = false;
        }
    }
}
