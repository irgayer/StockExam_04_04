using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExam
{
    public partial class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Added { get; set; }

        public void Print()
        {
            Console.WriteLine($"Имя  : {Name}");
            Console.WriteLine($"Цена : {Price} ");
        }
    }
}
