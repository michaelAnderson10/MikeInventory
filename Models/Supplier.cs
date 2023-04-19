using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Models
{
    public class Supplier
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? SupplierAddress { get; set; }
        public string? SupplierPhone { get; set; }
        public string? SupplierEmail { get;set; }
        public string? SupplierTag { get; set; }

        public ICollection<Part>? Parts { get; set; }
        public ICollection<Tool>? Tools { get; set; }

    }
}
    