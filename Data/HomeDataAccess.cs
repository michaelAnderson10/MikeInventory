using MikeInventory.Models;
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

        public static ObservableCollection<object> SearchAllComponent(string searchTerm)
        {
            using var db = new MikeInventoryContext();

            var partSearchResult = db.Parts
                .Where(p => p.PartId.ToString().Contains(searchTerm)
                    || p.PartDescription.Contains(searchTerm)
                    || (p.PartTag != null && p.PartTag.Contains(searchTerm)))
                .Select(p => new
                {
                    PartAndToolId = p.PartId,
                    PartAndToolDescription = p.PartDescription,
                    PartAndToolQuantity = p.PartQuantity,
                    PartAndToolSupplierId = p.SupplierID,
                    PartAndToolTags = p.PartTag,
                    PartAndToolUserId = p.UserID
                })
                .Cast<object>();

            var toolSearchResult = db.Tools
                .Where(t => t.ToolId.ToString().Contains(searchTerm)
                    || t.ToolDescription.Contains(searchTerm)
                    || (t.ToolTag != null && t.ToolTag.Contains(searchTerm)))
                .Select(t => new
                {
                    PartAndToolId = t.ToolId,
                    PartAndToolDescription = t.ToolDescription,
                    PartAndToolQuantity = t.ToolQuantity,
                    PartAndToolSupplierId = t.SupplierID,
                    PartAndToolTags = t.ToolTag,
                    PartAndToolUserId = t.UserID
                })
                .Cast<object>();

            var searchResult = new ObservableCollection<object>(partSearchResult.Union(toolSearchResult));
            return searchResult;
        }


        public static ObservableCollection<Category> GetCategories()
        {
            return new ObservableCollection<Category>
            {
                 new Category("Part"),
                 new Category("Tool")
            };
        }       

    }
}
