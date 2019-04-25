using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static int durchlauf = 1;
        static object lockObject = new object();
        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(MachEtwas));
            t.Start(durchlauf);
            durchlauf++;
            Thread t2 = new Thread(new ParameterizedThreadStart(MachEtwas));
            t2.Start(durchlauf);

            Console.ReadKey();
        }
        private static void MachEtwas(object durchlauf)
        {
            Console.WriteLine("Der Lock wird belegt");
            Monitor.Enter(lockObject);
            Console.WriteLine("Durchlauf " + durchlauf);
            for(int i = 90; i > 0; i--)
            {
                 Console.WriteLine($"Durchlauf {(int)durchlauf}: " + i);
            }
            Monitor.Exit(lockObject);
            Console.WriteLine("Der Lock ist Frei");
            Console.WriteLine("Der LockL2 wird belegt");
            lock (lockObject)
            {
                Console.WriteLine("Durchlauf L2 " + durchlauf);
                for (int i = 90; i > 0; i--)
                {
                    Console.WriteLine($"Durchlauf L2 {(int)durchlauf}: " + i);
                }
            }
            Console.WriteLine("Der Lock L2 ist Frei");
        }
    }
}
