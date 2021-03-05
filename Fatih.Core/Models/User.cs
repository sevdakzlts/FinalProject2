using Fatih.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models
{
    public class User:Person
    {

        public string LoginName { get; set; }
        public string LoginPassword { get; set; }

        //usertype
        public virtual List<UserType> UserTypes { get; set; }
        //user address
        public virtual UserAddress UserAddress { get; set; }
    }
}
