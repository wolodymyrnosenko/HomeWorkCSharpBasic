using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_15_1_VegetableShop
{
    class Product
    {
        public double BasePrice { get; protected set; }

        public virtual void PrintProductInfo()
        {
            string className = GetType().Name;
            Console.Write($"{Environment.NewLine}Product: {className}, Price: {BasePrice}");
        }
    }
}
