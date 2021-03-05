using Fatih.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models
{
    public class UserAddress:AddressBase
    {

        //user
        public int UserAddressId { get; set; }
        public virtual User User { get; set; }
    }
}
