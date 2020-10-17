using System;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string inputData;
            int[] Mas = { 1, 3, 4, 5, 8 };

            inputData = Console.ReadLine();
            Console.WriteLine(reverse(inputData));
            
            Console.WriteLine(reverseRecursion(inputData));
            
            Console.WriteLine(ReverseArray(ref Mas));
        }

        static string reverse(string S1)
        {
            char[] reversedCharArray = new char[S1.Length];
            int i = 0;
            int j = S1.Length - 1;
            while (i <= j)
            {
                reversedCharArray[i] = S1[j];
                reversedCharArray[j] = S1[i];
                i++; j--;
            }
            return new string(reversedCharArray);
        }

        static string reverseRecursion(string s)
        {
            if (s.Length == 1)
                return s;

            return reverseRecursion(s.Substring(1)) + s[0];
        }

        static int[] ReverseArray(ref int[] array)
        {
            int i = 0;
            int j = array.Length - 1;
            while (i < j)
            {
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            return array;
        }
    }
}