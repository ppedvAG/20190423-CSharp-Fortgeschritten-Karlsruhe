using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten
{
    class Add : ICalcMethod
    {
        public int Calculate(int op1, int op2)
        {
            return op1 + op2;
        }
    }
}
