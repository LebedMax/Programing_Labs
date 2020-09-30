using System;
//13. Дана квадратна матриця порядку M. Знайти суму елементів її 1)головної; 2) побічної діагоналей.
namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Sum_1=0, Sum_2=0;
            Console.WriteLine("N: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
               Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < N; j++)
            {
                Sum_1 += matrix[j,j];
            }
            Console.WriteLine("Sum1=" + Sum_1);

            for (int i = 0; i < N; i++)
            {
                for (int j = N-1; j >=0; j--)
                {
                    Sum_2 += matrix[i, j];
                }
            }
            Console.WriteLine("Sum2=" + Sum_2);
        }
    }
}
