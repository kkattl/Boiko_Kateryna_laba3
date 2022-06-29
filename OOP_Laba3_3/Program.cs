using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написати програму згідно виданого завдання використовуючи лише LINQ методи. 
//- Select, SelectMany, Where
//Дана послідовність додатніх цілих чисел.
//Обробляючи тільки непарні числа, отримати послідовність їх строкових уявлень
//і впорядкувати її в лексикографічному порядку по зростанню. (3)

namespace OOP_Laba3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введiть кiлькiсть елементiв: ");
            int size;
            if (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Помилка!");
            }
            var List = new List<int>();
            var newList = new List<string>();
            for (int i = 0; i < size; i++)
            {
                List.Add(rnd.Next(0, 100));
                Console.Write(List[i] + " ");
            }
            var selectedList = from i in List
                               where i % 2 == 1
                               orderby i.ToString()
                               select i.ToString();

            Console.WriteLine();
            foreach (var item in selectedList)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();  

        }
    
    }
}
