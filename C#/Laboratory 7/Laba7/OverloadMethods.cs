using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7
{
    class OverloadMethods
    {
        public int number { get; set; }

        public static int CheckInteger()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Enter the number again  ");
            }
            return a;
        }

        public static int CheckNatural()
        {
            int b;
            while ((!int.TryParse(Console.ReadLine(), out b) || b <= 0))
            {
                Console.WriteLine("Enter the number again  ");
            }
            return b;
        }

        public static string StrRepresent(string znachenie, int a)
        {
            string s;
            s = znachenie + $"={a}";
            return s;
        }

        public static OverloadMethods operator +(OverloadMethods a, OverloadMethods b)
        {
            return new OverloadMethods { number = a.number + b.number };
        }
        public static OverloadMethods operator -(OverloadMethods a, OverloadMethods b)
        {
            return new OverloadMethods { number = a.number - b.number };
        }
        public static OverloadMethods operator *(OverloadMethods a, OverloadMethods b)
        {
            return new OverloadMethods { number = a.number * b.number };
        }
        public static OverloadMethods operator /(OverloadMethods a, OverloadMethods b)
        {
            return new OverloadMethods { number = a.number / b.number };
        }
        public static bool operator >(OverloadMethods a, OverloadMethods b)
        {
            return a.number > b.number;
        }
        public static bool operator <(OverloadMethods a, OverloadMethods b)
        {
            return a.number < b.number;
        }

        public static bool operator <=(OverloadMethods a, OverloadMethods b)
        {
            return a.number <= b.number;
        }

        public static bool operator >=(OverloadMethods a, OverloadMethods b)
        {
            return a.number >= b.number;
        }
        public static bool operator ==(OverloadMethods a, OverloadMethods b)
        {
            return a.number == b.number;
        }
        public static bool operator !=(OverloadMethods a, OverloadMethods b)
        {
            return a.number != b.number;
        }

    }
}