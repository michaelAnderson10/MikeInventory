using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Models
{
    public class Part
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartId { get; set; }
        public string PartDescription { get; set; }
        public int? PartQuantity { get; set; }
        public string? PartTag { get; set; }

        
        public int? SupplierID { get; set; }
        public Supplier? Supplier { get; set; }

        public int? UserID { get; set; }
        public User? User { get; set; }

    }
}
