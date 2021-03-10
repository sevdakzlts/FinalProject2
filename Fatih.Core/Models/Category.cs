using System.Collections.Generic;

namespace Fatih.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //list of product 
        public virtual List<Product> Products { get; set; }
    }
}
