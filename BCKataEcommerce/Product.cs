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
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public List<string> Tags { get; set; }

        public string Category { get; set; }

    }
}