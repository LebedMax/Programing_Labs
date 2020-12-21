using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Створити клас Beer, в якому представлені 5 напоїв, кожен з яких має чотири характеристики: ціна, витримка, країна виробник. Четверту характеристику оберіть самі. 
 * Реалізувати можливість покупцю обрати собі напой до смаку. Вивести всі варіанти які йому підходять, якщо не підходить жоден – вивести відповідне повідомлення. */
namespace Application
{

    class Drink
    {
        public string endurance { get; set; }
        public string country { get; set; }
        public int price { get; set; }
        public int degree { get; set; }
        public Drink(string endurance, string country, int price, int degree)
        {
            this.endurance = endurance;
            this.country = country;
            this.price = price;
            this.degree = degree;
        }
    }
    class Beer
    {
        List<Drink> garage = new List<Drink>();
        public void NewDrink(string name, string color, int speed, int year)
        {
            Drink auto = new Drink(name, color, speed, year);
            garage.Add(auto);
        }
        public int NumberOfDrink()
        {
            return garage.Count;
        }
        public void ShowDrink()
        {
            for (int i = 0; i < NumberOfDrink(); i++)
            {
                Console.WriteLine($"{i + 1}. {garage[i].endurance} {garage[i].country} {garage[i].price} грн, {garage[i].degree} градусів");
            }
        }
      
        public void Sort(string name, string color, int speed, int year)
        {
            List<Drink> sortedList = new List<Drink>();
            for (int i = 0; i < NumberOfDrink(); i++)
            {
                sortedList.Add(garage[i]);
            }
            if (name != "0")
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].endurance!= name)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (color != "0")
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].country != color)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (speed != 0)
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].price != speed)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (year != 0)
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i].degree != year)
                    {
                        sortedList.RemoveAt(i);
                        i--;
                    }
                }
            }
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedList[i].endurance}, {sortedList[i].country}, {sortedList[i].price} грн, {sortedList[i].degree} градусів");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beer beer = new Beer();
            beer.NewDrink("long - lasting drink", "Ukraine", 70, 9);
            beer.NewDrink("medium-aged drink", "Scotland", 100, 72);
            beer.NewDrink("the drink has no aging", "Portugal", 400, 13);
            beer.NewDrink("medium-aged drink", "France", 5000, 7);
            beer.NewDrink("the drink has no aging", "Russia", 10, 40);
            int m;
            do
            {
                Console.WriteLine("1 - Список агкоголю \n2 - Ввести побажання до алкоголю\n0 - Выйти з меню");
                m = Convert.ToInt32(Console.ReadLine());
                switch (m)
                {

                    case 1:
                        if (beer.NumberOfDrink() == 0)
                        {
                            Console.WriteLine("У Вас немає жодного авто");
                        }
                        else
                        {
                            beer.ShowDrink();
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Для пошука алкоголю вписуйте: \nВитримку\nКраїну виробника\nЦіну\nГрадус\nЯкщо параметр невідомий , ставте 0");
                        string n = Console.ReadLine();
                        string c = Console.ReadLine();
                        int s = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        beer.Sort(n, c, s, y);
                        break;
                }
            } while (m != 0);
        }
    }
}

