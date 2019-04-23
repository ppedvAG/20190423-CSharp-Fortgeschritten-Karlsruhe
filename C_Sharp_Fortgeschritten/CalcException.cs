using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten
{
    class CalcException: Exception
    {
        public CalcException(string message): base(message)
        {
        }
    }
}
