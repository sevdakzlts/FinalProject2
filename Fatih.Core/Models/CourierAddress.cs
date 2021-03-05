using Fatih.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models
{
    public class CourierAddress : AddressBase
    {
        //courier
        public int CourierAddressId { get; set; }
        public virtual Courier Courier { get; set; }
    }
}
