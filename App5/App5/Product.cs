using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Product
    {
        public Product(string Name, string Category, string Tag , float Price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Tag = Tag;
            this.Price = Price;    
        }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Tag { get; set; }
        public float Price { get; set; }


    }
}
