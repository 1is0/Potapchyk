using System;

namespace laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            Competition sportsman = new Competition((Competition.Ranking)2, "Ivanov", 24, "Run", "Olympic Games", "Silver", "Belarus",12.3);
            sportsman.ShowResults();
            Console.ReadKey();
        }
    }
}
