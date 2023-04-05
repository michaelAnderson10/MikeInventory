using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string PartDescription { get; set; } = null!;
        public int? PartQuantity { get; set; }
        public ICollection<Supplier>? Suppliers { get; set; }
    }
}
