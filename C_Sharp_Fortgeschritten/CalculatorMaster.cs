using C_Sharp_Fortgeschritten.Logic;
using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten
{
    class CalculatorMaster
    {
        private readonly IParser parser;
        private readonly ICalc calculator;
   
        List<ICalcMethods> CalcMethods = new List<ICalcMethods>();

        public CalculatorMaster(IParser parser, ICalc calculator)
        {
            this.parser = parser;
            this.calculator = calculator;
        }
  
        public void Start()
        {
            Console.WriteLine("Bitte gib den Ausdruck ein:");
            var input = Console.ReadLine();

            // Den eingegebenen String als Tupel (decimal, decimal, string) zurückgeben
            var expression = parser.Parse(input);
            var result = calculator.Calculate(expression.op1, expression.op2, expression.method);

            Console.WriteLine($"Das Ergebnis für den eingegebenen Ausdruck lautet: {result}");

        }
    }
}
