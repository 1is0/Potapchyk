using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            string[] words = stroka.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words) {
                Array.Reverse(words);
                Console.WriteLine("Обратный:");
                for (int i = 0; i < words.Length; i++)
                {

                    Console.Write(words[i] + " ");


                }
                Console.ReadKey();
            }
        }
    }
}
