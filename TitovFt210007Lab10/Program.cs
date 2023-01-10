using System;
using System.Linq;
using System.Collections.Generic;

namespace TitovFt210007Lab10
{
    internal class Program
    {
        //Dictionary<string, int> messages = new Dictionary<string, string>
        //{
        //    {"Enter sum", "Введите сумму" },
        //    {"Quantity of bills to pay", "Колличество купюр для оплаты" },
        //    {"Wrong input data", "Неправильны входные данные" }
        //};

        Dictionary<int, string> Engessages = new Dictionary<int, string>
        {
            {0, "Enter sum" },
            {1, "Quantity of bills to pay"},
            {2, "Wrong input data" }
        };

        Dictionary<int, string> ruMessages = new Dictionary<int, string>
        {
            {0, "Введите сумму" },
            {1, "Колличество купюр для оплаты" },
            {2, "Неправильны входные данные" }
        };




        static void ChoseLang(string lang)
        {
            Console.WriteLine("Choose language: (Enter \"ru\" or \"eng\")");
            lang = Console.ReadLine();
        }

        static string SendMessage(string lang, int currentMessage)
        {
            string msg = null;
            if (lang == "ru")
            {
                
            }
            return msg;
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
            while (true) 
            {
                Console.Write("Enter the sum \n>");
                try //обработка ошибок ввода
                {
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Quantity of bills to pay: " + BillsAnalyses(n));
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Wrong input data");
                }
            }
        }
    }
}
