using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj
{
    public class PersistentStore : Store
    {
        public PersistentStore()
        {
            GetAllProduct = new List<Product>();
        }
        protected override void StoreProduct(Product product)
        {
            GetAllProduct.Add(product);
            
            
        }
        
        
    }
}
