using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        public void SaveToXml(Product product)
        {
            string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Inventory_project.xml");
           
            using (Stream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Store));
                serializer.Serialize(fs, this);
            }
            
            
                
            
        }
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
            SaveToXml(product);
            
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
