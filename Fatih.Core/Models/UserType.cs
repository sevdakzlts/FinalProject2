using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models
{
    public class UserType
    {
        public int Id { get; set; }
        public bool Seller { get; set; }
        public bool Customer { get; set; }

        //public bool SellerCustomer { get; set; }

        //user
        public virtual User User { get; set; }
    }
}
