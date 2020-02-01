using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj
{
    interface StorageCapable
    {
        List<Product> getAllProduct();
        void storeCDProduct(string name, int price, int tracks);
        void storeBookProduct(string name, int price, int tracks);
    }
}
