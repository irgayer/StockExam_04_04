using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExam
{
    public class StockApp
    {
        const string PATH_TO_FILE = "";
        const string FILE_NAME = "products.xml";

        Stock stock;
        XmlManager xmlManager;

        

        public void Run()
        {
            xmlManager = new XmlManager(PATH_TO_FILE + FILE_NAME);
            stock = new Stock();
            //stock.AddProducts(xmlManager.Load<Product>());
            stock.Added += ShowMessage;
            while (true)
            {
                Product newProduct = new Product();
                string productName, productPriceStr;
                double productPrice;

                Console.WriteLine("Добавление нового продукта:\n");
                Console.WriteLine("Введите имя:");
                productName = Console.ReadLine();
                if (Product.CheckName(productName))
                {
                    Console.WriteLine("Введите описание:");
                    newProduct.Name = productName;
                    newProduct.Description = Console.ReadLine();

                    Console.WriteLine("Введите цену:");
                    productPriceStr = Console.ReadLine();

                    if (double.TryParse(productPriceStr, out productPrice))
                    {
                        if (Product.CheckPrise(productPrice))
                        {
                            newProduct.Price = productPrice;
                            newProduct.Added = DateTime.Now;

                            stock.AddProduct(newProduct);
                            xmlManager.Save(stock.GetProducts());
                           // stock.AddProducts(xmlManager.Load<Product>());
                        }
                        else Console.WriteLine("Цена должна быть больше 0!");
                    }
                    else Console.WriteLine("Некорректная цена!");
                }
            }
        }
        private void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
