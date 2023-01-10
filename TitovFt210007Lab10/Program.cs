using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace TitovFt210007Lab10
{
    internal class Program
    {
        static string ChoseLang()
        {
            Console.WriteLine("Choose language/Выберете язык: (Enter \"ru\" or \"eng\")");
            string lang = Console.ReadLine();
            return lang;
        }


        static string SendMessage(int number, string lang,  Func<string, bool> isEng)
        {
            Languages langs = new Languages();
            if (isEng(lang))
            {
                return string.Join("", langs.Eng.Where(z => z.Key == number).Select(z => z.Value));
            }
            else
            {
                return string.Join("", langs.Ru.Where(z => z.Key == number).Select(z => z.Value));
            }
        }

        static int BillsAnalyses(int n)
        {
            int count = 0;
            for (int i = 6; i >= 0; i--)
            {
                while (n > 0 && n >= (int)Math.Pow(2, i))
                {
                    n = n - (int)Math.Pow(2, i);
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            string lang = ChoseLang();
            Console.WriteLine((SendMessage(0, lang, (l) => lang == "eng"))); 
            try //обработка ошибок ввода
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine((SendMessage(1, lang, (l) => lang == "eng") + " " +BillsAnalyses(n))); 
            }
            catch (FormatException e)    
            {
                    Console.WriteLine((SendMessage(2, lang, (l) => lang == "eng")));
            }
        }
    }
}
