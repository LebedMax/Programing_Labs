using System;

namespace Lab_1
{
    class Program
    {
        static void Main()
        {
            int n;
            double r=0;
            Console.WriteLine( " Enter value n ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value r ");
            r = Convert.ToDouble(Console.ReadLine());
            double P = 2 * r * n * Math.Tan((Math.PI / n));
            Console.Write(P);
        }
	}
}
