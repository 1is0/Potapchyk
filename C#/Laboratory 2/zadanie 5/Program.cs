using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        { int i;
            bool res;
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            char[] stroka2 = stroka.ToCharArray();
            Console.WriteLine("Заглавные буквы из строки:");
            for (i = 0; i < stroka2.Length; i++)
            { res = char.IsUpper(stroka2[i]);
                if ((res == true)&&(stroka2[i]>='А')&&(stroka2[i]<='Я'))
                { Console.Write(" " + stroka2[i]); }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
