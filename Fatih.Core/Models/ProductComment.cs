using Fatih.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models
{
    public class ProductComment : CommentBase
    {

        //product
        public virtual Product Product { get; set; }
    }
}
