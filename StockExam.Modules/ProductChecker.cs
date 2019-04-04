using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExam
{
    public partial class Product
    {
        static public bool CheckName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return true;
            }
            return false;
        }
        static public bool CheckPrise(double price)
        {
            if(price > 0)
            {
                return true;
            }
            return false;
        }
    }
}
