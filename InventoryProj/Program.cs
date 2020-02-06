using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj
{
    class Program
    {
        static private StorageCapable storecap = new PersistentStore();
        static void Main(string[] args)
        {
            StoreManager store = new StoreManager(storecap);
            store.addStorage(storecap);
            store.addCDProduct("nem", 013, 234);
            store.addCDProduct("az", 013, 234);
            store.addCDProduct("meg", 0323, 234);
            store.addCDProduct("dikk", 0323, 234);

        }
    }
}
