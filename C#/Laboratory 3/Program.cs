using System;
using System.Collections.Generic;
using System.Text;
namespace laba3
{
 
        class Sportsman
        {
            public string Name { get; private set; }
            public string Sport { get; private  set; }
            public string Country { get; private set; }
            public int Age { get; private  set; }
            public bool Health { get; private set; }
            public double Record { get; private set; } 
            public int Medal { get; private set; }
            protected int MyId { get;private  set; }
            public static int Id = 0;
        public Sportsman(string name, string sport, string country, int age, double record) 
            {
                Name = name;
                Sport = sport;
                Country = country;      
                Age = age;
                Medal = 0;
                Record =record;
                Health = false;
                MyId = ++Id;
        }
            public Sportsman(string name, string sport, string country, int age, double record, int medal, bool health=false)
                :this(name,sport,country,age,record)
            {
                Health = health;
                Medal = medal;
            }

        static public bool Check(string name)
        {
            if (name.Length > 40)
            {
                return false;
            }
            foreach (var ch in name)
            {
                if ((ch < 'A' || ch > 'Z') && (ch < 'a' || ch > 'z'))
                {
                    return false;
                }
            }
            return true;
        }

        public void ChangeName(string newName)
        {
            if (!Check(newName))
            {
                return;
            }
            Name = newName;
        }
   
        public void ChangeAge(int newAge)
        {
            Age = newAge;
        }
        public void ChangeRecord(double newRecord)
        {
            Record = newRecord;
        }
            public void ChangeSport(string newSport)
        {
            if (!Check(newSport))
            {
                return;
            }
            Sport = newSport;
        }
        public void ChangeCountry(string newCountry)
        {
            if (!Check(newCountry))
            {
                return;
            }
            Country = newCountry;
        }
        public void ChangeHealth(bool newHealth)
        {
            Health = newHealth;
        }

        public string InfoToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Id: {MyId}");
            info.AppendLine($"Name: {Name}");
            info.AppendLine($"Sport: { Sport}");
            info.AppendLine($"Country: {Country}");
            info.AppendLine($"Age: {Age}yers");
            info.AppendLine($"Record: {Record}m");
            info.AppendLine($"Medal:{Medal}");
            info.AppendLine(Health ? "Sportsman is healthy" : "Sportsman is sick!");
            return info.ToString();
        }

        public void Reward()
        {
            Medal++;
        }

        public void Reward(int fresh)
        {
            Medal += fresh;
        }

        public void GetWell()
        {
            Health = false;
        }

        public void GetSick()
        {
            Health = true;
        }

    }
}