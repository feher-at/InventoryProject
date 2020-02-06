using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InventoryProj
{
    
    public class BookProducts : Product
    {
        public int numOfPages;

        public BookProducts(string name,int price,int size) : base(name,price)
        {
            this.numOfPages = size;
        }
        public BookProducts()
        { }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"type = book, name = {Name}, price = {Price},size = {numOfPages}");
            return sb.ToString();
        }

    }
}
