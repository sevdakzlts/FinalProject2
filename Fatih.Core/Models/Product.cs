using System.Collections.Generic;

namespace Fatih.Core.Models
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        //category 
        public virtual Category Category { get; set; }

        //comments 
        public virtual List<ProductComment> ProductComments { get; set; }
    }
}
