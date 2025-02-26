﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Model
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }
        public bool NameBeginWithS => Name?[0] == 'S';

        public Product(bool stock = true)
        {
            InStock = stock;
        }
        public static Product[] GetProducts()
        {
            var kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            var lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null}
            ;

        }
    }
     
}
