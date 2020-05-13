using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_15
{
    class Program
    { static char bukva(char stroka3)
        {
            int a = (int)stroka3 + 1;
            stroka3 = Convert.ToChar(a);
            return stroka3;
        }

        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            char[] stroka2 = stroka.ToCharArray();
            for (i = 0; i < stroka2.Length; i++)
            {
                switch (stroka2[i]) {
                    case 'a':
                        stroka2[i + 1] =bukva(stroka2[i+1]);
                        break;
                    case 'e':
                        stroka2[i + 1]= bukva(stroka2[i + 1]);
                        break;
                }
            }
            for (i = 0; i < stroka2.Length; i++)
            {
                Console.Write(stroka2[i]);
            }
            Console.ReadLine();
        }

    }
}
