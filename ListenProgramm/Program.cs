using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = { 10, 5, 99, 14, 1, 35 };
            Console.WriteLine("------------------Array mit For---------------------------");
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }
            Console.WriteLine("------------------Array mit ForEach---------------------------");
            foreach (var i in integerArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------ArrayList mit ForEach---------------------------");
            ArrayList integerArrayList = new ArrayList();
            integerArrayList.Add(10);
            integerArrayList.Add(5);
            integerArrayList.Add(99);
            integerArrayList.Add(14);
            integerArrayList.Add("abc");
            integerArrayList.Add(new object());
            integerArrayList.Add(new Random());
            integerArrayList.Add(1);
            integerArrayList.Add(35);

            foreach(var item in integerArrayList)
            {
                if(item is int intItem)
                {
                    Console.WriteLine(5 + intItem);
                }
                
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------List mit ForEach---------------------------");
            List<int> integerList = new List<int>();
            integerList.Add(10);
            integerList.Add(5);
            integerList.Add(99);
            integerList.Add(14);
            integerList.Add(1);
            integerList.Add(35);

            Console.WriteLine("------------------Dictionary mit ForEach---------------------------");
            var dict = new Dictionary<int, string>();
            dict.Add(10, "Test");
            dict.Add(9, "Test2");
            dict.Add(7, "Test3");

            Console.WriteLine(dict.Values);

            Console.WriteLine("------------------Datenwörterbuch mit ForEach---------------------------");
            Datenwörterbuch<char> dw1 = new Datenwörterbuch<char>();
            dw1.Add('a', "30");
            
            /*dw.Add(10, "Test");
            dw.Add(9, "Test2");
            dw.Add("9", "Test2");
            dw.Add(7, "Test3");
            
            foreach(var item in dw)
            {
                Console.WriteLine(item.value);
            }*/

            dw.Remove(9);
            



            Console.ReadKey();
        }
    }
}
