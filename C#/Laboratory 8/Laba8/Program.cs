using System;

namespace laba8
{
    class Program
    {
        delegate string competition(string a, string b);
        static void Main(string[] args)
        {
            string nameCompetition = "Olympic Games";
            string reward = "Silver";
            competition Outputcompetititon = (firstPart, secondPart) => firstPart + secondPart;
            Competition sportsman = new Competition((Competition.Ranking)2, "Ivanov", 24, "Run", nameCompetition, reward, "Belarus", 12.3);
            sportsman.ShowResults();
            sportsman.Ev += AgeShow;
            if (sportsman.Age < 19)
            {
                Console.WriteLine("\n\n");
            }
            else
            {
                sportsman.ShowAge();
            }
            Console.WriteLine(Outputcompetititon("Name Competition and Reward:", $" {nameCompetition}/{reward}"));
            Console.ReadKey();
        }
        static void AgeShow(string age)
        {
            Console.WriteLine(age);
        }

    }
 
}

