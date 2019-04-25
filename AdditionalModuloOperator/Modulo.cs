using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalModuloOperator
{
    class Modulo : ICalcMethods
    {
        public string Method => "%";

        public decimal Do(decimal op1, decimal op2)
        {
            return op1 % op2;
        }
    }
}
