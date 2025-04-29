using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_15_1_VegetableShop
{
    sealed class Potato : Product
    {
        public double Count { get; private set; }
        public double Price { get; private set; }
        public Potato(double basePrice, double count)
        {
            Count = count;
            Price = basePrice;
            BasePrice = basePrice * count;
        }
        public override void PrintProductInfo()
        {
            string className = GetType().Name;
            Console.Write($"{Environment.NewLine}Product: {className}, Price: {Price}, Count: {Count}, Total price: {BasePrice}");
        }
    }
}
