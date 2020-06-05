using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Sportsman
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
        public double OverallResult { get; set; }
        protected string ID { get; set; }

        public Sportsman()
        {
            Name = "Ivanov";
            Age = 24;
            Sport = "Run";
            ID = SportsmanId();
        }

        public Sportsman(string name = " ", int age = 0, string sport = " ")
        {
            Name = name;
            Age = age;
            Sport = sport;
            ID = SportsmanId();
        }

        protected static string SportsmanId()
        {
            return Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return ($"Name:{Name}\nAge:{Age}\nSport:{Sport}\nID:{ID}\n");
        }
    }
}