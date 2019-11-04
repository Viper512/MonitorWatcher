using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MonitorWatcher.BLL;

namespace MonitorWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(TimerCallback, null, 0, 60000);
            Console.ReadLine();
        }

        public static bool locked = false;

        private static void TimerCallback(Object o)
        {
            if (!locked)
            {
                locked = true;
                BLLMonitor.RecordData();
                // Display the date/time when this method got called.
                Console.WriteLine("In TimerCallback: " + DateTime.Now);
                // Force a garbage collection to occur for this demo.
                GC.Collect();
                locked = false;
            }
            else
            {
                Console.WriteLine("Tried to run, but it's locked right now.");
            }
        }
    }
}
