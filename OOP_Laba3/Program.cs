using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3
{
    //У колі стоять N людей, пронумерованих від 1 до N.
    //При веденні рахунку по колу викреслюється кожна друга людина, поки не залишиться один.
    //Скласти дві програми, що моделюють процес.Одна з програм повинна використовувати клас ArrayList,
    //а друга - LinkedList.Яка з двох програм працює швидше? Чому?

    internal class Program
    {
        static void Main(string[] args)
        {
            int N, choose;
            Console.WriteLine("Введiть скiльки людей стоiть у колi:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть за допоиогою чого буде виконуватись програма:\n1 - ArrayList\n2 - LinkedList");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        ArrayList list = new ArrayList();
                        for (int i = 0; i < N; i++)
                        {
                            list.Add(i + 1); 
                        }
                        int current = 0; 
                        while (list.Count > 1)
                        {
                            current++;
                            if (current >= list.Count) current = 0;
                            list.RemoveAt(current);
                            if (current >= list.Count) current = 0; 
                        }
                        Console.WriteLine($"Залишилась людина № {list[0]}");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        var list = new LinkedList<int>(Enumerable.Range(1, N));
                        var currentItem = list.First;
                        while (list.Count != 1)
                        {
                            list.Remove(currentItem.Next ?? list.First);
                            currentItem = currentItem.Next ?? list.First;
                        }
                        Console.WriteLine($"Залишилась людина № {list.First.Value}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Помилка!");
                        break;
                    }
            }

            Console.ReadKey();

        }
    }
}
