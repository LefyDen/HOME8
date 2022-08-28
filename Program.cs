
using System;
using System.Text.RegularExpressions;
using System.IO;
namespace HOME8_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneBook = { "Clara Klane +380670356345", "li Lion +380340356745", "Clara Frog +380478356745" };
            string ss;
            ss = Console.ReadLine();
            try
            {
               Regex regex = new Regex(ss);
            int hMatcher;

            for (int i = 0; i < phoneBook.Length; i++)
            {
                string s = phoneBook[i];



                MatchCollection matches = regex.Matches(s);
                hMatcher = matches.Count;
                if (matches.Count != 0)
                {

                    Console.WriteLine(phoneBook[i]);

                }
                if (hMatcher < 1 && i == phoneBook.Length)
                {
                    Console.WriteLine("Нікого не знайдено");
                }
            }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Введiть коректнi даннi, без '+'");
                Console.WriteLine(ex.Message);
            }


        }
    }
}
//checked 
