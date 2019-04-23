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
                List<int> integerListe = new List<int>() {5, 8 , 10, 1, 99, 23 };
                Console.WriteLine(integerListe);
                int[] intArray = { 5, 9, 10 };
                Console.WriteLine(intArray.Sum());

                List<string> stringListe = new List<string>();
                Calculator addCalc = new Calculator((op1, op2) => op1 + op2);
                Calculator SubCalc = new Calculator((op1, op2) => op1 - op2);
                Calculator DivCalc = new Calculator((op1, op2) => op1 / op2);
                Calculator MulCalc = new Calculator((op1, op2) => op1 * op2);
                Calculator ModCalc = new Calculator((op1, op2) => op1 % op2);
                var result = addCalc.Calculate(21, 30);
                Console.WriteLine($"Das Ergebnis ist: {result}");
            }catch(CalcException e)
            {
                Console.WriteLine($"Der Rechner funktioniert nicht: {e.Message}");
            }
            

            Console.ReadKey();
        }
    }
}
