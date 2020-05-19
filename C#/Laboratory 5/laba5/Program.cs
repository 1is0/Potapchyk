using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            competition sportsman = new  competition((competition.Ranking)2,"Ivanov",24,"Run","Olympic Games","Silver", "Belarus");
            sportsman.ShowResults();
            Console.ReadKey();
        }
    }
}
