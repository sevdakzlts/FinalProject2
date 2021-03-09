﻿using System.Text.Json.Serialization;
using Fatih.Core.Models.Base;

namespace Fatih.Core.Models
{
    public class ProductComment : CommentBase
    {

        //product
        public int ProductId { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}
