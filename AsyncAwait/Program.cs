using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = MachEtwas();

            Console.WriteLine("Ich bin wieder im Main");

            Console.ReadKey();
        }

        static async Task MachEtwas()
        {
            Task<int> machLangsamTask = MachLangsam();

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            int ergebnis = await machLangsamTask;

            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

        }
        
        static async Task<int> MachLangsam()
        {
            Console.WriteLine("MachLangsam beginnt");
            await Task.Delay(4000);
            Console.WriteLine("MachLangsam hat gewartet");
            return 597;
        }
    }
}
