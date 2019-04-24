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
                Calculator calculator = new Calculator();
                calculator.Start();
            }catch(CalcException e)
            {
                Console.WriteLine($"Der Rechner funktioniert nicht: {e.Message}");
            }
            

            Console.ReadKey();
        }
    }
}
