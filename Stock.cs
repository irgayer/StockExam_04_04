using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExam
{
    public class Stock
    {
        private List<Product> products;

        public delegate void AddPressed(string message);
        public event AddPressed Added;

        public Stock()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
            
            if(Added != null)
            {
                Console.WriteLine("Добавлен продукт");
            }
            
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public void AddProducts(List<Product> products)
        {


            foreach (var p in products)
            {
                products.Add(p);
            }
            if (Added != null)
            {
                Console.WriteLine("Добавлены продукты");
            }
        }
        
    }
}
