using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написати програму для пошуку однакових елементів у двох словниках.
//Вхідний словник: {'key1': 1, 'key2': 3, 'key3': 2},
//                 {'key1': 1, 'key2': 2}
//                 Результат програми:
//                                      key1: 1 is present in both x and y

namespace Laba3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary x:\n");
            var dictionary1 = new Dictionary<string, int>()
            {
                {"key1", 1}, {"key2", 3}, {"key3", 2}
            };
            Console.WriteLine(dictionary1);
           
            var dictionary2 = new Dictionary<string, int>()
            {
                {"key1", 1}, {"key2", 2}
            };
            foreach (var element1 in dictionary1)
            {
                foreach (var element2 in dictionary2)
                {
                    if (element1.Equals(element2))
                    {
                        Console.WriteLine($"{element1.Key}: {element1.Value} is present in both x and y");
                    };
                }
            }
            
            Console.ReadKey();

           
     
        }
    }
}
