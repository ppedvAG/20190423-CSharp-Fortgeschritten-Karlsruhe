using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calc = new Calculator("Add");
                var result = calc.Calculate(21, 30);
                Console.WriteLine($"Das Ergebnis ist: {result}");
            }catch(CalcException e)
            {
                Console.WriteLine($"Der Rechner funktioniert nicht: {e.Message}");
            }
            

            Console.ReadKey();
        }
    }
}
