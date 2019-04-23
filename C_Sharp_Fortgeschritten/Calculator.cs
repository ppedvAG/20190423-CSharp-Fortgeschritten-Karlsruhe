using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten
{
    class Calculator
    {
        // Delegate deklarieren
        public Func<int,int,int> CalcMethod;
        // CalcMethod deklarieren
 
        public Calculator(Func<int,int,int> operation)
        {
            CalcMethod = operation;
        }
  
        public int Calculate(int op1, int op2)
        {
            if (CalcMethod == null)
            {
                throw new CalcException("Es ist keine Methode zum Rechnen vorhanden!");
            }
            else
            {
                return CalcMethod.Invoke(op1, op2);
            }
        }
    }
}
