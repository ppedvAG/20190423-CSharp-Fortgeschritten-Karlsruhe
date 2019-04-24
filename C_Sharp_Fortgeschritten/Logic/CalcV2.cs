using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten.Logic
{
    public class CalcV2 : ICalc
    {
        private readonly ICalcMethods[] calcMethods;

        public CalcV2(ICalcMethods[] calcMethods)
        {
            this.calcMethods = calcMethods;

        }
        public decimal Calculate(decimal op1, decimal op2, string method)
        {
            var calculationMethod = calcMethods.First(x => x.Method == method);
            return calculationMethod.Do(op1, op2);
        }
    }
}
