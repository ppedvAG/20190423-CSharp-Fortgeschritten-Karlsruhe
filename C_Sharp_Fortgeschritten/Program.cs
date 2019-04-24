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
                CalculatorMaster calculator = new CalculatorMaster();
                calculator.Start();
            }catch(CalcException e)
            {
                Console.WriteLine($"Der Rechner funktioniert nicht: {e.Message}");
            }
            

            Console.ReadKey();
        }
    }
}
