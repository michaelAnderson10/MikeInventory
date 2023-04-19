using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? UserPhoneNo { get; set; }
        public string? UserEmail { get; set;}
        public string? UserTag { get; set;}

        public Part Part { get; set; } = null!;
        public Tool Tool { get; set; } = null!;
      
    }
}
