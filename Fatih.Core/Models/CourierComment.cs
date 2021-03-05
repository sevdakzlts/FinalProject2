using Fatih.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models
{
    public class CourierComment : CommentBase
    {

        //courier
        public virtual Courier Courier { get; set; }
    }
}
