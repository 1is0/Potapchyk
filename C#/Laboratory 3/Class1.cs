sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Sportsman
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
        protected string ID { get; set; }

        public Sportsman()
        {
            Name = "Ivanov";
            Age = 24;
            Sport = "Run";
            ID = SportsmantId();
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
            return ($"Name:{Name}\t Age:{Age}\t Sport:{Sport}\t ID:{ID}\t");
        }
    }
}

