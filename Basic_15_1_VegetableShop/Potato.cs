using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_15_1_VegetableShop
{
    class Potato : Product
    {
        public double BasePrice { get; private set; }
        public double Count { get; private set; }

        public Potato(double basePrice, double count) : base(basePrice)
        {
            BasePrice = basePrice * count;
            Count = count;
        }
    }
}
