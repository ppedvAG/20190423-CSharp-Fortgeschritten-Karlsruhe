using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten.Logic
{
    class ParserV2 : IParser
    {
        public (decimal op1, decimal op2, string method) Parse(string input)
        {
            Regex regex = new Regex(@"\D*(\d*)\D*([\*\+\-\%\/])\D*(\d*)\D*");
            Match result = regex.Match(input);

            if(result.Success)
            {
                Console.WriteLine("Gefundener 1. Operand: " + result.Groups[1].Value);
                Console.WriteLine("Gefundener Operator: " + result.Groups[2].Value);
                Console.WriteLine("Gefundener 2. Operand: " + result.Groups[3].Value);
                return (decimal.Parse(result.Groups[1].Value), decimal.Parse(result.Groups[3].Value), result.Groups[2].Value);
            }
            else
            {
                throw new ArgumentException("Der Parser konnte den eingegebenen String nicht lesen.");
            }
        }
    }
}
