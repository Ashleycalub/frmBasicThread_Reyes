using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmBasicThread_Reyes
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 5; i++) 
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + "= " + i);

                Thread.Sleep(1500);
            }
        }

    }
}
