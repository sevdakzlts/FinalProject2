using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Core.Models.Base
{
    public abstract class CommentBase
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
