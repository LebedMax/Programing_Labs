using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    // Варіант 13
    // Створити розширяючий метод для масиву цілих чисел, який сортує елементи масиву по спаданню.
    static class ExtentionMethods
    {
        public static void method(this int n)
        {
            string Str = Convert.ToString(n);
            int l = Str.Length - 1;
            for (int i = l; i >= 0; i--)
            {
                Console.Write(Str[i]);
            }
            Console.WriteLine();
        }
        public static void method(this string str)
        {
            int l = str.Length - 1;
            for (int i = l; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        public static void method(this float num)
        {
            string str = Convert.ToString(num);
            int l = str.Length;
            int point = l;
            for (int i = 0; i < l; i++)
            {
                if ((str[i] == '.') || (str[i] == ','))
                {
                    point = i;
                }
            }
            for (int i = point - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.Write('.');
            for (int i = l - 1; i > point; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        public static void method(string str, int l)
        {
            int point = l;
            for (int i = 0; i < l; i++)
            {
                if (str[i] == ',')
                {
                    point = i;
                }
            }
            for (int i = point - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.Write(',');
            for (int i = l - 1; i > point; i--)
            {
                Console.Write(str[i]);
            }
        }
        public static void method7(this int[] array)
        {
            int l = array.Length;
            int temp;
            for (int i = 0; i < l / 2; i++)
            {
                temp = array[i];
                array[i] = array[l - i - 1];
                array[l - i - 1] = temp;
            }
            for (int i = 0; i < l; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
    static class ArraySort 
    {
        public static void Sort(this int[] num)
        {
            int temp;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(num[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 4, 0, 3, 9, -1 };
            ArraySort.Sort(array);
            Console.WriteLine();
            int number = 60991;
            string str = "apple";
            float numFloat = 223.54f;
            string str2 = "hello,world";
            int l = str2.Length;
            int[] array2 = new int[5] { 0, 2, 4, 6, 8 };
            ExtentionMethods.method(number);
            ExtentionMethods.method(str);
            ExtentionMethods.method(numFloat);
            ExtentionMethods.method(str2, l);
            Console.WriteLine();
            ExtentionMethods.method7(array2);
            Console.ReadKey();
        }
    }
}