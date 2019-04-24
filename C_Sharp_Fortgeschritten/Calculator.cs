using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten
{
    class Calculator
    {
        List<ICalcMethod> CalcMethods = new List<ICalcMethod>();
        public Calculator()
        {

        }
        public void Start()
        {
            Console.WriteLine("Bitte gib den Ausdruck ein:");
            var input = Console.ReadLine();

            var expression = Parse(input);
            var result = Calc(expression.op1, expression.op2, expression.method);

            Console.WriteLine($"Das Ergebnis für den eingegebenen Ausdruck lautet: {result}");

        }

        public (decimal op1, decimal op2, string method) Parse(string input)
        {
            var split = input.Split(' ');
            return (decimal.Parse(split[0]), decimal.Parse(split[2]), split[1]);
        }

        public decimal Calc(decimal op1, decimal op2, string method)
        {
            if(method == "+")
            {
                return op1 + op2;
            }else if (method == "-")
            {
                return op1 - op2;
            }
            return 0;
        }
    }
}
