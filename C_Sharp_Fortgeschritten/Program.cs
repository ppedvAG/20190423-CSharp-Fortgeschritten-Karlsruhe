using C_Sharp_Fortgeschritten.Logic;
using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace C_Sharp_Fortgeschritten
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var operatorAssembly = Assembly.LoadFrom("AdditionalOperators.dll");
                List<ICalcMethods> calcMethods = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.StartsWith("Additional"))
                    .SelectMany(x => x.GetTypes())
                    .Where(x => typeof(ICalcMethods).IsAssignableFrom(x))
                    .Select(x => (ICalcMethods)Activator.CreateInstance(x))
                    .ToList();
                //Type calculatorType = operatorAssembly.GetType("C_Sharp_Fortgeschritten.CalculatorMaster");
                //object calculatorInstance = Activator.CreateInstance(calculatorType);

                var calculationMethods = new List<ICalcMethods>();
                calculationMethods.Add(new Add());
                calculationMethods.Add(new Subtract());

                calculationMethods.AddRange(calcMethods);
                   
                var calculator = new CalcV2(calculationMethods);
                var parser = new ParserV2();
  
                CalculatorMaster calculatorMaster = new CalculatorMaster(parser, calculator);
                calculatorMaster.Start();

            }catch(CalcException e)
            {
                Console.WriteLine($"Der Rechner funktioniert nicht: {e.Message}");
            }
            

            Console.ReadKey();
        }
    }
}
