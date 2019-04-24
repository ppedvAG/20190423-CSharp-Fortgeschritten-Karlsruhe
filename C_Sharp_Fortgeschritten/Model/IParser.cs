using System;

namespace C_Sharp_Fortgeschritten.Model
{
    public interface IParser
    {
        (decimal op1, decimal op2, string method) Parse(string input);
    }
}
