using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class Customer:BaseEntity
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Note { get; set; }
        public virtual List<Sale>? Sales { get; set; }
    }
}
