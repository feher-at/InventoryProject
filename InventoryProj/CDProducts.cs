using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InventoryProj
{
    
   public class CDProducts : Product
    {
        public int numOfTracks;

        public CDProducts(string name, int price, int size) : base(name,price)
        {
            this.numOfTracks = size;
            
        }
        public CDProducts()
        { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"type = cd, name = {Name}, price = {Price},size = {numOfTracks}");
            return sb.ToString();
        }
        
    }
}
