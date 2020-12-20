using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    /*
     * Варіант 13
     * Створити ліст трінгових змінних, дозволити можливість заповнення з калвіатури. 
     * Вивести індекси змінних рівних перевірочній(теж ввести з клавіатури). Скопіювати ліст в масив.*/
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Введыть 5 слів (eng):");
            for (int i = 0; i < 5; i++)
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("Введіть слово для перевірки (eng):");
            string word = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (word == list[i])
                {
                    Console.WriteLine($"Слово {list[i]} має індекс {i}.");
                }
            }
            string[] array = new string[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = list[i];
            }
            Console.WriteLine("Скопированный массив слов: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
