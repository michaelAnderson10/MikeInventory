using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? SupplierPhone { get; set; }
        public string? SupplierEmail { get;set; }

        public Part Part { get; set; } = null!;
        public Tool Tool { get; set; } = null!;
    }
}
