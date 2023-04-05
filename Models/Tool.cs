using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Models
{
    public class Tool
    {
        public int Id { get; set; }
        public string ToolDescription { get; set; } = null!;
        public int? ToolQuantity { get; set; }
        public ICollection<Supplier>? Suppliers { get; set; }
    }
}
