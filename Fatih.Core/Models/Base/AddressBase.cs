using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models.Base
{
    public abstract class AddressBase
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Detail { get; set; }
    }
}
