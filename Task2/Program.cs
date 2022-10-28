using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку (предложение, слово) для проверки на палиндромность:");
            string str = Console.ReadLine();
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
            }

            #region обработка исх строки
            string[] stringArray = str.Split();
            string resultstr2 = "";
            string resultstr = "";
            foreach (string c in stringArray)
            {
                resultstr += c.Substring(0).ToLower();
            }
            #endregion

            #region обработка перевернутой строки
            string[] stringArray2 = str2.Split();
            foreach (string s in stringArray2)
            {
                resultstr2 += s.Substring(0).ToLower();
            }
            #endregion

            if (resultstr2 == resultstr)
            {
                Console.WriteLine("Строка (предложение, слово) - палиндром");
            }
            else
            {
                Console.WriteLine("Строка (предложение, слово) - НЕ палиндром");
            }
            Console.ReadKey();
        }
    }
}
