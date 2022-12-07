using System;

namespace TitovFt210007Lab10
{
    internal class Program
    {       
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
