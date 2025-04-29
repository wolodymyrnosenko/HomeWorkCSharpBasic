using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_15_1_VegetableShop
{
    class Product
    {
        public double BasePrice { get; protected set; }
        public Product(double basePrice)
        {
            BasePrice = basePrice;
        }
    }
}
