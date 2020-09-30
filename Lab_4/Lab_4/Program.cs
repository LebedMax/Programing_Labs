using System;
//Варіант 13
namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int a=0, b=0;
            int [] Mas = new int [n];
            Random rnd = new Random();
            for (int i=0; i < n; i++)//ввід масива
            {
                Mas[i] = rnd.Next();
            }
            int Min = Mas[0];
            int Max = Mas[0];

            for (int i = 1; i < n; i++)//пошук максимума і мінімума
            {
               if(Min>Mas[i])
                {
                    Min = Mas[i];
                }
               else if(Max<Mas[i])
                {
                    Max = Mas[i];
                }
            }

            for (int i = 0; i < n; i++)//пошук кількості мінімумів і максимумів
            {
                if (Min == Mas[i])
                {
                    a++;
                }
                else if (Max == Mas[i])
                {
                    b++;
                }
            }
            Console.WriteLine("In the array have " + a +" minimum") ;
            Console.WriteLine("In the array have " + b + " max");
        }
    }
}
