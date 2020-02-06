using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace InventoryProj
{
    
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name,int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Product()
        { }
    }
}
