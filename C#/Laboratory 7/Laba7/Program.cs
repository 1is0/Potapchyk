using System;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Enter a integer number(n):");
            n = OverloadMethods.CheckInteger();
            Console.WriteLine("Enter a natural number(m):");
            m = OverloadMethods.CheckNatural();
            OverloadMethods N = new OverloadMethods { number = n };
            OverloadMethods M = new OverloadMethods { number = m };
            bool peer;
            bool bm;
            peer = N == M;
            bm = N > M;
            Console.Clear();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select an action: ");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Compare");
                Console.WriteLine("6.Chech numbers for equality");
                Console.WriteLine("7.Exit");
                int otvet = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (otvet)
                {
                    case 1: Console.WriteLine($"N+M= {(N + M).number}"); break;
                           
                    case 2: Console.WriteLine($"N-M={(N - M).number}"); break;

                    case 3:
                        Console.WriteLine($"N*M={(N * M).number}"); break;
                    case 4:
                        Console.WriteLine($"N/M={(N / M).number}"); break;
                    case 5:
                        switch (bm)
                        {
                            case true:
                                Console.WriteLine($"{n}>{m}");
                                break;
                            case false:
                                Console.WriteLine($"{n}<{m}");
                                break;
                        }
                        break;
                    case 6:  switch (peer)
                        {
                            case true:
                                Console.WriteLine($"{n}={m}");
                                break;
                            case false:
                                Console.WriteLine($"{n}!={m}");
                                break;
                        }
                     break;
                    case 7: return;
                    default:
                        break;
                } }
       
        }
    }
}