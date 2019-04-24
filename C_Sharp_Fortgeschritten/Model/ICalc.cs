using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fortgeschritten.Model
{
    public interface ICalc
    {
        decimal Calculate(decimal op1, decimal op2, string method);
    }
}
