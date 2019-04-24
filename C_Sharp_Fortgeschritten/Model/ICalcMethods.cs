using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fortgeschritten.Model
{
    public interface ICalcMethods
    {
        string Method { get; }
        decimal Do(decimal op1, decimal op2);
    }
}
