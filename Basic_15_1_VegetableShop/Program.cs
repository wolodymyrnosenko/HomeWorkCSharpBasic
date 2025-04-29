﻿using System.Data.Common;

namespace Basic_15_1_VegetableShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, vegetable shop!");
            var products = new List<Product>
            {
                new Carrot(15),
                new Potato(20, 4),
                new Cucumber(14,2)
            };

            VegetableShop shop = new VegetableShop();
            shop.AddProducts(products);
            shop.PrintProductsInfo();

        }
    }
}
