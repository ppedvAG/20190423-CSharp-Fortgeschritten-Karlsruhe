using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t1 = new Task<int>(MachEtwas);
            Task<int> t2 = new Task<int>(MachEtwas);
            t1.Start();
            Console.WriteLine("Die Task wurde gestartet");
           
                var i = t1.Result;
                 t1 = new Task<int>(MachEtwas);
                t1.Start();
                var i2 = t1.Result;
               
                Console.WriteLine("Ergebnis ist: " + i);
            
            Console.WriteLine("Das Programm ist fertig");
            Console.ReadKey();
        }

        static int MachEtwas()
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine("Ausgabe" + i);
            }
            return -1;
        }
    }
}
