using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Basic_15_1_VegetableShop
{
    sealed class VegetableShop
    {
        public List<Product> Products { get; private set; }

        public VegetableShop()
        {
            Products = new List<Product> { };
        }
        public void AddProducts(List<Product> products)
        {
            foreach(var product in products)
            {
                Products.Add(product);
            }
        }

        public void PrintProductsInfo()
        {
            Console.WriteLine("Output:");
            double totalPrice = 0;
            string className;
            foreach(var product in Products)
            {
                className = TypeDescriptor.GetClassName(product);//Separate class name

                Console.WriteLine($"Product: {className}, Price: {product.BasePrice}");
                totalPrice += product.BasePrice;
            }
            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }
}
