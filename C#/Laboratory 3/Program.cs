using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman Sportsman1 = new Sportsman();
            Sportsman Sportsman2 = new Sportsman("Petrov", 26, "Skiing");

            Console.WriteLine(Sportsman1);
            Console.WriteLine(Sportsman2);
            Sportsman[] sportsman = new Sportsman[2];
            EnterSportsman(sportsman);
            Console.WriteLine();
            Console.ReadKey();
        }
        static int CheckInt()
        {
            int CheckNumber;
            while (!int.TryParse(Console.ReadLine(), out CheckNumber) || CheckNumber <= 0)
            {
                Console.WriteLine("Enter again");
            }
            return CheckNumber;
        }
        

        static void EnterSportsman(Sportsman[] sportsman)
        {

            for (int i = 0; i < sportsman.Length; i++)
            {
                Console.WriteLine("\n");
                sportsman[i] = new Sportsman();
                Console.WriteLine("Enter name");
                sportsman[i].Name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                sportsman[i].Age = CheckInt();
                Console.WriteLine("Enter sport");
                sportsman[i].Sport = Console.ReadLine();

            }
            for (int j = 0; j < sportsman.Length; j++)
            {
                Console.WriteLine("\n"+(j + 1) + ")" + sportsman[j]);
            }

        }
    }
}
