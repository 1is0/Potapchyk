using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class competition : Sportsman
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
        public double Result { get; set; }
        public Ranking Place { get; set; }

        public competition(Ranking ranking,string name="", int age=0, string sport="", string  nameCompetition="", string reward="", double result=0)
        {
            Name = name;
            Age = age;
            Sport = sport;
            NameCompetition = nameCompetition;
            Reward = reward;
            Result = result;
            Place = ranking;
            ID = SportsmanId();
        }
        public virtual void ShowResults()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Sport:{Sport}");
            Console.WriteLine($"Competition:{NameCompetition}");
            Console.WriteLine($"Ranking place:{Place}");
            Console.WriteLine($"Reward:{Reward}");
            Console.WriteLine($"Result:{Result}s");
            Console.WriteLine($"ID:{ID}");
        }
    }
}
