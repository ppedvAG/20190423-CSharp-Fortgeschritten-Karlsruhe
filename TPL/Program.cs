using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static CancellationTokenSource cts = new CancellationTokenSource();
        static void Main(string[] args)
        {
            Task<int> t1 = new Task<int>(MachEtwas);
            Task<int> t2 = new Task<int>(MachEtwas);
            t1.Start();
            Console.WriteLine("Die Task wurde gestartet");


            cts.Cancel();
            var i = t1.Result;
            Console.WriteLine("Ergebnis ist: " + i);
            
            Console.WriteLine("Das Programm ist fertig");
            Console.ReadKey();
        }

        static int MachEtwas()
        {
            
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine("Ausgabe" + i);
                if (cts.IsCancellationRequested)
                {
                    break;
                }
            }
            return -1;
        }
    }
}
