using MikeInventory.Models;
using MikeInventory.ViewModels;
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
                parts.Select(p => new
                {
                    PartAndToolId = p.PartId,
                    PartAndToolDescription = p.PartDescription,
                    PartAndToolQuantity = p.PartQuantity,
                    PartAndToolSupplierId = p.SupplierID,
                    PartAndToolTags = p.PartTag,
                    PartAndToolUserId = p.UserID,
                    SupplierName = p.Supplier != null ? p.Supplier.SupplierName : null, // Eagerly load the SupplierName with null check
                    FirstName = p.User != null ? p.User.FirstName : null,
                    Supplier = p.Supplier,
                    User = p.User
                })
                    .Cast<object>()
                    .Union(tools.Select(t => new
                    {
                        PartAndToolId = t.ToolId,
                        PartAndToolDescription = t.ToolDescription,
                        PartAndToolQuantity = t.ToolQuantity,
                        PartAndToolSupplierId = t.SupplierID,
                        PartAndToolTags = t.ToolTag,
                        PartAndToolUserId = t.UserID,
                        SupplierName = t.Supplier != null ? t.Supplier.SupplierName : null, // Eagerly load the SupplierName with null check
                        FirstName = t.User != null ? t.User.FirstName : null,
                        Supplier = t.Supplier,
                        User = t.User
                    }))
                );

            return AllComponents;

        }

        public static ObservableCollection<object> SearchAllComponent(string searchTerm)
        {
            using var db = new MikeInventoryContext();

            var partSearchResult = db.Parts
                .Where(p => p.PartId.ToString().Contains(searchTerm)
                    || p.PartDescription.Contains(searchTerm)
                    || p.Supplier !=null && p.Supplier.SupplierName.Contains(searchTerm)
                    || (p.User != null && p.User.FirstName != null && p.User.FirstName.Contains(searchTerm))
                    || (p.PartTag !=null && p.PartTag.Contains(searchTerm)))
                .Select(p => new
                {
                    PartAndToolId = p.PartId,
                    PartAndToolDescription = p.PartDescription,
                    PartAndToolQuantity = p.PartQuantity,
                    PartAndToolSupplierId = p.SupplierID,
                    PartAndToolTags = p.PartTag,
                    PartAndToolUserId = p.UserID,
                    SupplierName = p.Supplier != null ? p.Supplier.SupplierName : null, // Eagerly load the SupplierName with null check
                    FirstName = p.User != null ? p.User.FirstName : null,
                    Supplier = p.Supplier,
                    User = p.User
                })
                .Cast<object>();

            var toolSearchResult = db.Tools
                .Where(t => t.ToolId.ToString().Contains(searchTerm)
                    || t.ToolDescription.Contains(searchTerm)
                    || t.Supplier != null && t.Supplier.SupplierName.Contains(searchTerm)
                    || (t.User != null && t.User.FirstName != null && t.User.FirstName.Contains(searchTerm))
                    || (t.ToolTag != null && t.ToolTag.Contains(searchTerm)))
                .Select(t => new
                {
                    PartAndToolId = t.ToolId,
                    PartAndToolDescription = t.ToolDescription,
                    PartAndToolQuantity = t.ToolQuantity,
                    PartAndToolSupplierId = t.SupplierID,
                    PartAndToolTags = t.ToolTag,
                    PartAndToolUserId = t.UserID,
                    SupplierName = t.Supplier != null ? t.Supplier.SupplierName : null, // Eagerly load the SupplierName with null check
                    FirstName = t.User != null ? t.User.FirstName : null,
                    Supplier = t.Supplier,
                    User = t.User
                })
                .Cast<object>();

            var searchResult = new ObservableCollection<object>(partSearchResult.Union(toolSearchResult));
            return searchResult;
        }
    }
}
