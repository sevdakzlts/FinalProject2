using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models.Base
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
