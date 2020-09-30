using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter as three - digit number");
            int a= Convert.ToInt32(Console.ReadLine());
            bool Flag ;
            int a1 = a / 100;
            int a2 = (a % 100) / 10;
            int a3 = a % 10;
            if(a1<a2 && a2<a3)
            {
                Flag = true;
          
            }
            else
            {
                Flag = false;
             
            }
            if (Flag == true)
            {
                
                Console.WriteLine("These figures form elements of increasing progression");
            }
            else
            {
            
                Console.WriteLine("The condition is not met");
            }


        }
    }
}
