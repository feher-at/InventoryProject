using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj
{
    class StoreManager
    {
        private StorageCapable storage;

        public StoreManager(StorageCapable Storage)
        {
            this.storage = Storage;
        }
        public void addStorage(StorageCapable store)
        {

        }
        public void addCDProduct(string name, int price, int tracks)
        {

        }
        public void addBookProduct(string name, int price, int tracks)
        {

        }
        public string listProducts()
        {
            string juststring = "juststring";
            return juststring;
        }
        public int getTotalProductPrice()
        {
            int justint = 0;
            return justint;
        }
    }
}
