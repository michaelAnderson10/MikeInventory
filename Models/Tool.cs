using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Models
{
    public class Tool
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToolId { get; set; }
        public string ToolDescription { get; set; } = null!;
        public int? ToolQuantity { get; set; }     
        public string? ToolTag { get; set; }
        public ICollection<Supplier>? Suppliers { get; set; }
        public ICollection<User>? Users { get; set; }

    }
}
