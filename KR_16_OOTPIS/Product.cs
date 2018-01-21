using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_16_OOTPIS
{
    class Product
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        // Конструктор с параметрами
        public Product(string name, string date, double price, int count)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
            this.Count = count;
        }

        // Констркутор  по умолчанию
        public Product() : this("default", "01.01.1975", 15, 5) { }

        public string GetInfo()
        {
            return String.Format("\nName: {0};\nDate: {1};\nPrice: {2}; Count: {3}", Name, Date, Price, Count);
        }
    }
}
