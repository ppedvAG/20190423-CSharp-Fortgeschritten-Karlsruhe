using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten
{
    class Divide : ICalcMethods
    {
        public string Method => "/";

        public decimal Do(decimal op1, decimal op2) => op1 / op2;
    }
}
