using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitovFt210007Lab10
{
    internal class Languages
    {
        public Dictionary<int, string> Eng { get; set; }
        public Dictionary<int, string> Ru { get; set; }

        public Languages()
        {
            Eng = new Dictionary<int, string>
            { 
                {0, "Enter sum" },
                {1, "Quantity of bills to pay"},
                {2, "Wrong input data" }
        };
            Ru = new Dictionary<int, string>
            {
                {0, "Введите сумму" },
                {1, "Колличество купюр для оплаты" },
                {2, "Неправильны входные данные" }
            };
        }
    }
}
