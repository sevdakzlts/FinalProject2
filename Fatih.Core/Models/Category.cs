using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Fatih.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //list of product
        [JsonIgnore]
        public virtual List<Product> Products { get; set; }
    }
}