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
        public delegate int CalcMethod(int op1, int op2);
        // CalcMethod deklarieren
        CalcMethod calcMethod;
 
        public Calculator(string operation)
        {
            // Wir weisen dem Delegaten "calcMethod" die Berechnungsmethode zu
            if (operation == "Add")
            {
                calcMethod = new CalcMethod(Add);
            }
        }

        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }
        public int Subtract(int op1, int op2)
        {
            return op1 - op2;
        }

        public int Calculate(int op1, int op2)
        {
            return calcMethod.Invoke(op1, op2);
        }
    }
}
