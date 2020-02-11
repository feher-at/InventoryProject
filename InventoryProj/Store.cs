using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace InventoryProj
{
    [XmlRoot("Products")]
    [XmlInclude(typeof(PersistentStore))]
    [XmlInclude(typeof(BookProducts))]
    [XmlInclude(typeof(CDProducts))]
    public abstract class Store:StorageCapable
    {
        public Store()
        { }
        public List<Product> GetAllProduct { get; set; }
        public abstract void Savefile(Product product);
        protected abstract void StoreProduct(Product product);

        protected Product createProduct(string type, string name, int price, int size)
        {
            if (type == "CD")
            {
                Product product = new CDProducts(name, price, size);
                return product;
            }
            else if(type == "Book")
            {
                Product product = new BookProducts(name, price, size);
                return product;
            }
            throw new ArgumentException($"Invalid argument: {type}");
            

        }

    public List<Product> loadProducts()
        {
            List<Product> products = new List<Product>();
            return products;
        }
        public void store(Product product)
        {
            StoreProduct(product);
            Savefile(product);
            
        }
        
        public void storeCDProduct(string name, int price, int tracks)
        {
            Product product =  createProduct("CD", name, price, tracks);
            store(product);
        }
        public void storeBookProduct(string name, int price, int tracks)
        {
            createProduct("Book", name, price, tracks);
        }

    }
}
