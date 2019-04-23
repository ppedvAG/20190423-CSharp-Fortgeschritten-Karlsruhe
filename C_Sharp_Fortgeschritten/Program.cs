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
            Calculator calc = new Calculator("Add");
            var result = calc.Add(20, 30);
            Console.WriteLine($"Das Ergebnis ist: {result}");

            Console.ReadKey();
        }
    }
}
