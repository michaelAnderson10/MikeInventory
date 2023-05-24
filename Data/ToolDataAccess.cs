using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Data
{
    public class ToolDataAccess
    {
        public static void AddTool(int toolId, string toolDescription, int toolQuantity, int supplierId, string toolTag, int userId)
        {
            using var context = new MikeInventoryContext();
            var db = new Tool
            {
                ToolId = toolId,
                ToolDescription = toolDescription,
                ToolQuantity = toolQuantity,
                SupplierID = supplierId,
                ToolTag = toolTag,
                UserID = userId,
            };
            context.Tools.Add(db);
            context.SaveChanges();
        }


        ////Read all records in People table       
        public ObservableCollection<Tool>? Tools { get; set; }
        public static ObservableCollection<Tool> GetTool()
        {
            using (var db = new MikeInventoryContext())
            {
                return new ObservableCollection<Tool>(db.Tools.ToList());
            }
        }
    }
}
