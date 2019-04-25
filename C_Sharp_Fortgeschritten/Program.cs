using C_Sharp_Fortgeschritten.Logic;
using C_Sharp_Fortgeschritten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace C_Sharp_Fortgeschritten
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // ToDo: Null Checks hinzufügen
                // Hole uns alle Dateien aus dem Ordner Plugins
                foreach (string datei in Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Plugins")))
                {
                    if (Path.GetExtension(datei) == ".dll")
                    {
                        // Füge die .dll Datei der Assembly hinzu
                        Assembly.LoadFrom(datei);
                    }
                }
                // Gehe die gesamte Assembly durch und hole uns die ICalcMethods
                Console.WriteLine(Assembly.LoadFrom("Plugins/AdditionalOperators.dll").GetTypes());
                List<ICalcMethods> calcMethods = AppDomain.CurrentDomain?.GetAssemblies()?.Where(x => x.FullName.StartsWith("Additional"))
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
