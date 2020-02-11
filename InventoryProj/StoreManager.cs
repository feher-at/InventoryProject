using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj
{
    class StoreManager
    {
        public StorageCapable storage;

        

        public StoreManager(StorageCapable Storage)
        {
            
        }
        public void addStorage(StorageCapable store)
        {
            storage = store;
        }
        public void addCDProduct(string name, int price, int tracks)
        {
            storage.storeCDProduct(name, price, tracks);
        }
        public void addBookProduct(string name, int price, int tracks)
        {
            storage.storeBookProduct(name, price, tracks);
        }
        public string listProducts()
        {
            string productsList = "";
            foreach(Product product in storage.GetAllProduct)
            {
                if(product.GetType() == typeof(CDProducts))
                {
                    CDProducts cdproduct = (CDProducts)product;
                    productsList += cdproduct.ToString() + "\n";
                    
                }
                else if(product.GetType() == typeof(BookProducts))
                {
                    BookProducts bookproduct = (BookProducts)product;
                    productsList += bookproduct.ToString() + "\n";
                }
            }
            return productsList;
        }
        public int getTotalProductPrice()
        {
            int totalPrice = 0;
            foreach (Product product in storage.GetAllProduct)
            {
                totalPrice += product.Price;

            }
            return totalPrice;
        }
    }
}
