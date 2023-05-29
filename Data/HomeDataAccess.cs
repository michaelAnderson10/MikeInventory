using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Data
{
    public class HomeDataAccess
    {
        public static ObservableCollection<object> GetAllComponent()
        {
            var parts = PartDataAccess.GetPart();
            var tools = ToolDataAccess.GetTool();       

            var AllComponents = new ObservableCollection<object>(
                parts.Select(p => new { PartAndToolId = p.PartId, PartAndToolDescription = p.PartDescription, PartAndToolQuantity = p.PartQuantity, PartAndToolSupplierId = p.SupplierID, PartAndToolTags = p.PartTag, PartAndToolUserId = p.UserID })
                     .Cast<object>()
                     .Union(tools.Select(t => new { PartAndToolId = t.ToolId, PartAndToolDescription = t.ToolDescription, PartAndToolQuantity = t.ToolQuantity, PartAndToolSupplierId = t.SupplierID, PartAndToolTags = t.ToolTag, PartAndToolUserId = t.UserID }))
            );

            return AllComponents;

        }
    }
}
