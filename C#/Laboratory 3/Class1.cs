using System;
using System.Collections.Generic;
namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sportsman = new Dictionary<int, Sportsman>();
            sportsman[1] = new Sportsman("Ivanov","Run","Belarussian",19,20.1,10,true);
            sportsman[2] = new Sportsman("Sidorov","Skiing","Russia",21,14.6);
            while (true)
            {
                Console.WriteLine("1 to show all the sportsman");
                Console.WriteLine("2 to add a new sporsman");
                Console.WriteLine("3 to delete sportsman by id");
                Console.WriteLine("4 to change sportsman");
                Console.WriteLine("5 to quit the program");
                switch (Choice(1, 5))
                {
                    case 1:
                        Console.Clear();
                        ShowAll(sportsman);
                        break;
                    case 2:
                        Console.Clear();
                        sportsman[Sportsman.Id + 1] = GetNewSportsman();
                        Console.WriteLine("\nCharacteristics of the new sportsman:\n");
                        Console.WriteLine(sportsman[Sportsman.Id].InfoToString());
                        Console.WriteLine("Sportsman was added!");
                        break;
                    case 3:
                        DeleteSportsman(sportsman);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        ChangeSome(sportsman);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        return;
                }
            }
        }

        static int Choice(int min = int.MinValue, int max = int.MaxValue, string text = "Choice: ")
        {
            int x;
            Console.Write(text);
            while (!int.TryParse(Console.ReadLine(), out x) || x < min || x > max)
            {
                Console.WriteLine("Error! Input a number from {0} to {1}", min, max);
                Console.Write(text);
            }
            return x;
        }

        static double ReadDouble(string text, double min = 0, double max = double.MaxValue)
        {
            double x;
            Console.Write(text);
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out x) || x < min || x > max)
            {
                Console.WriteLine("Error! Enter a number from {0} to {1}", min, max);
                Console.Write(text);
            }
            return x;
        }
        static int ReadInt(string text, int min = 0, int max = int.MaxValue)
        {
            int x;
            Console.Write(text);
            while (!int.TryParse(Console.ReadLine(), out x) || x < min || x > max)
            {
                Console.WriteLine("Error! Enter a number from {0} to {1}", min, max);
                Console.Write(text);
            }
            return x;
        }
        static void ShowAll(Dictionary<int, Sportsman> sportsman)
        {
            if (sportsman.Count == 0)
            {
                Console.WriteLine("There is no sportsman");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("******************************************************");
            foreach (var a in sportsman)
            {
                Console.Write(a.Value.InfoToString());
                Console.Write("******************************************************");
                Console.ReadLine();
            }
        }

        static string GetName(string text)
        {
            while (true)
            {
                Console.Write(text);
                string Name = Console.ReadLine();
                if (Sportsman.Check(Name))
                {
                    return Name;
                }
                Console.WriteLine("String should contain up to 40 symbols A-Z or a-z");
            }
        }

        static Sportsman GetNewSportsman()
        {
            string name = GetName("Name-");
            string sport = GetName("Sport-");
            string country = GetName("Country-");
            int    age= ReadInt("Age(year) - ");
            double record = ReadDouble("Record(m) - ");
            if (Choice(0, 1, "Your sportsman health(1/0)? ") == 0)
            {
                return new Sportsman(name,sport,country, age, record);
            }
            int medal = ReadInt("Medal() - ");
            bool health = true;
            return new Sportsman(name, sport,country,age,record,medal,health);
        }

        static int ChooseSpecific(Dictionary<int, Sportsman> sportsman)
        {
            Console.Write("Available sportsman: ");
            foreach (var a in sportsman)
            {
                Console.Write(a.Key + " ");
            }
            Console.WriteLine();
            while (true)
            {
                int choice = Choice();
                if (sportsman.ContainsKey(choice))
                {
                    return choice;
                }
                Console.WriteLine("There is no such sportsman. Try again");
            }
        }

        static void DeleteSportsman(Dictionary<int, Sportsman> sportsman)
        {
            if (sportsman.Count == 0)
            {
                Console.WriteLine("\nThere is no sportsman");
                return;
            }
            Console.WriteLine("\nChoose the id of the sportsman you want to delete");
            int index = ChooseSpecific(sportsman);
            sportsman.Remove(index);
            Console.WriteLine("It has been removed!");
        }

        static void ChangeSome(Dictionary<int, Sportsman> sportsman)
        {
            if (sportsman.Count == 0)
            {
                Console.WriteLine("\nThere is no sportsman");
                return;
            }
            Console.WriteLine("\nChoose the id of the sportsman you want to change");
            int index = ChooseSpecific(sportsman);
            Console.WriteLine("1 to change the Name");
            Console.WriteLine("2 to change the Sport");
            Console.WriteLine("3 to change the Country");
            Console.WriteLine("4 to change the medal");
            Console.WriteLine("5 to change the age");
            Console.WriteLine("6 to change the record");
            Console.WriteLine("7 to change health/sick the spotsman");
            Console.WriteLine("8 to do nothing");
            switch (Choice(1, 8))
            {
                case 1:
                    sportsman[index].ChangeName(GetName(""));
                    Console.WriteLine("Name has been changed!");
                    break;
                case 2:
                    sportsman[index].ChangeSport(GetName(""));
                    Console.WriteLine("Sport has been changed!");
                    break;
                case 3:
                    sportsman[index].ChangeCountry(GetName(""));
                    Console.WriteLine("Country has been changed!");
                    break;

                case 4:
                    if (sportsman[index].Health)
                    {
                        Console.WriteLine("You can not medal sick sporsman");
                        break;
                    }
                    Console.WriteLine("Input kolichestvo new medal");
                    sportsman[index].Reward(ReadInt("Medal(m) = "));
                    Console.WriteLine("OK! Number of medals is {0}", sportsman[index].Medal);
                    break;
                case 5:
                    sportsman[index].ChangeAge(ReadInt(""));
                    Console.WriteLine("Age has been changed!");
                    break;
                case 6:
                    sportsman[index].ChangeRecord(ReadDouble(""));
                    Console.WriteLine("Record has been changed!");
                    break;
                case 7:
                    Console.WriteLine("1 to health");
                    Console.WriteLine("2 to sick");
                    int choice = Choice(1, 2);
                    if (choice == 1 && sportsman[index].Health ==true)
                    {
                        Console.WriteLine("He was not sick");
                        break;
                    }
                    if (choice == 2 && sportsman[index].Health == false)
                    {
                        Console.WriteLine("He was not healthy");
                        break;
                    }
                    if (choice == 1)
                    {
                        sportsman[index].GetWell();
                        Console.WriteLine("He is health");
                        sportsman[index].ChangeHealth(true);
                        break;
                    }
                    sportsman[index].GetSick();
                    Console.WriteLine("He is sick");
                    sportsman[index].ChangeHealth(false);
                    break;
                case 8:
                    Console.WriteLine("Nothing has been changed");
                    return;
            }
        }

    }
}

