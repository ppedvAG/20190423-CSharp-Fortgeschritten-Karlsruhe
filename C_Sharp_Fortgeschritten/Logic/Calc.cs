using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten.Logic
{
    public class Calc : ICalc
    {
        public decimal Calculate(decimal op1, decimal op2, string method)
        {
            if (method == "+")
            {
                return op1 + op2;
            }
            else if (method == "-")
            {
                return op1 - op2;
            }
            return 0;
        }
    }
}
