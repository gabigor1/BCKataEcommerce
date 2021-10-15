using System;
using System.Collections.Generic;

namespace BCKataEcommerce
{
    public class Item
    {
        public List<Product> Items { get; set; }
    }

    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public float price { get; set; }

        public string image { get; set; }

        public string description { get; set; }

        public List<string> tags { get; set; }

        public string category { get; set; }

    }
}