using System;
using System.Collections.Generic;
using System.Text;

namespace laba8
{
    class Competition : Sportsman, SportsmanResult
    {
        public new string Name { get; set; }
        public new int Age { get; set; }
        public new string Sport { get; set; }
        public enum Ranking
        {

            First = 1,
            Second,
            Third,
            Fourth,
            Fifth,
            Sixth,
            Seventh,
            Eighth,
            Ninth,
            Tenth
        }
        public string NameCompetition { get; set; }
        public string Reward { get; set; }
        public string Country { get; set; }
        public Ranking Place { get; set; }
        public delegate void AgeGet(string age);
        public event AgeGet Ev;

        public Competition(Ranking ranking, string name = "", int age = 0, string sport = "", string nameCompetition = "",
                                                                   string reward = "", string country = "", double overallResult = 0)
        {
            Name = name;
            Age = age;
            Sport = sport;
            NameCompetition = nameCompetition;
            Reward = reward;
            Country = country;
            Place = ranking;
            OverallResult = overallResult;
            ID = SportsmanId();
        }
        public void ShowAge()
        {
            Ev.Invoke($"\nAge: {Age}\n");
        }
        public virtual void ShowResults()
        {
            Console.WriteLine($"Name:{Name}");
            //Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Sport:{Sport}");
            Console.WriteLine($"Competition:{NameCompetition}");
            Console.WriteLine($"Ranking place:{Place}");
            Console.WriteLine($"Reward:{Reward}");
            Console.WriteLine($"Country:{Country}");
            Console.WriteLine($"ID:{ID}");
            Result();
        }
        public void Result()
        {
            Console.WriteLine($"Total time at 100 meters :{OverallResult}s");
            if (OverallResult <= 9.58)
            {
                Console.WriteLine("\nCongratulations! You broke the world record.");
            }
            else if (OverallResult >= 9.58 && OverallResult < 13.5)
            {
                Console.WriteLine("\nYou can try to participate in the Olympic Games.");
            }
            else if (OverallResult > 13.5)
            {
                Console.WriteLine("\nYou still need to work out.");
            }
        }
    }
}
