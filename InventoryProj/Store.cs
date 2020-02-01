using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj
{
    abstract class Store
    {
        public void saveToXml(Product product)
        {

        }
        public void storeProduct(Product product)
        {

        }
        public Product createProduct(string type, string name, int price, int size)
        {
            Product products = new Product();
            return products;
        }
        public List<Product> loadProducts()
        {
            List<Product> products = new List<Product>();
            return products;
        }
        public void store(Product product)
        {

        }
    }
}
