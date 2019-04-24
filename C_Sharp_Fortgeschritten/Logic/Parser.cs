using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten.Logic
{
    class Parser : IParser
    {
        public (decimal op1, decimal op2, string method) Parse(string input)
        {
            var split = input.Split(' ');
            return (decimal.Parse(split[0]), decimal.Parse(split[2]), split[1]);
        }
    }
}
