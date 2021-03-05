using Fatih.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models
{
    public class Courier : Person
    {

        //courier address
        public virtual CourierAddress CourierAddress { get; set; }

        //courier comment 
        public virtual List<CourierComment> CourierComments { get; set; }


    }
}
