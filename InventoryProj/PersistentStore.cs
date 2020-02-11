using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

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
        public override void Savefile(Product product)
        {

            string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Inventory_project.xml");

            using (Stream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Store));
                serializer.Serialize(fs, this);
            }
        }

    }
}
