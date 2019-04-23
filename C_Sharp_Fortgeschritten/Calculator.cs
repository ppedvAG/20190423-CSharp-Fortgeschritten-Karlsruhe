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
                // Anonyme Methode
            } else if (operation == "Substract")
            {
                calcMethod = new CalcMethod(delegate(int op1, int op2)
                {
                    return op1 - op2;
                });
                // Kurzschreibweise
            }  else if(operation == "Divide")
            {
                calcMethod = delegate (int op1, int op2)
                {
                    return op1 / op2;
                };
                // Lambdaschreibweise
            } else if(operation == "Multiply")
            {
                calcMethod = (op1, op2) =>
                {
                    return op1 * op2;
                };
            } else if(operation == "Modulo")
            {
                calcMethod = (op1, op2) => op1 % op2;
            }
        }

        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }
 
        public int Calculate(int op1, int op2)
        {
            if (calcMethod == null)
            {
                throw new CalcException("Es ist keine Methode zum Rechnen vorhanden!");
            }
            else
            {
                return calcMethod.Invoke(op1, op2);
            }
        }
    }
}
