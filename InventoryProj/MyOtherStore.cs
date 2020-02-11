using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryProj
{
    class MyOtherStore:Store
    {
        public MyOtherStore()
        {
            GetAllProduct = new List<Product>();
        }
        protected override void StoreProduct(Product product)
        {
            GetAllProduct.Add(product);


        }
        public override void Savefile(Product product)
        {
            string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Inventory_project.txt");
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                foreach(Product element in GetAllProduct)
                {
                    sw.WriteLine(element.ToString());
                }
            }
        }
    }
}
