using Microsoft.Identity.Client;
using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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


        ////Read all records in Tools table       
        public ObservableCollection<Tool>? Tools { get; set; }
        public static ObservableCollection<Tool> GetTool()
        {
            using (var db = new MikeInventoryContext())
            {
                return new ObservableCollection<Tool>(db.Tools.ToList());
            }
        }

        //Update a record in Tools table
        public static void UpdateTool(int toolId, string toolDescription, int toolQuantity, int supplierId, string toolTag, int userId)
        {
            using var db = new MikeInventoryContext();
            Tool toolToUpdate = db.Tools.FirstOrDefault(x => x.ToolId == toolId);
            if (toolToUpdate != null)
            {
                toolToUpdate.ToolId = toolId;
                toolToUpdate.ToolDescription = toolDescription;
                toolToUpdate.ToolQuantity = toolQuantity;
                toolToUpdate.SupplierID = supplierId;
                toolToUpdate.ToolTag = toolTag;
                toolToUpdate.UserID = userId;

                db.SaveChanges();
            }
            else
            {
                string errorMessage = $"Part with ID {toolId} not found.";
                Console.WriteLine(errorMessage);
            }

        }

        //Delete record from Tools table           
        public static void RemoveTool(int toolSelectedId)
        {
            Tool varRemove = new Tool();
            using var db = new MikeInventoryContext();
            varRemove = db.Tools.Where(x => x.ToolId == toolSelectedId).First();
            db.Tools.Remove(varRemove);
            db.SaveChanges();
        }

        public static ObservableCollection<Tool> SearchTool(string searchTerm)
        {
            using var db = new MikeInventoryContext();
            var searchResult = db.Tools.Where(x =>
                x.ToolId.ToString().Contains(searchTerm) ||
                x.ToolDescription.Contains(searchTerm) ||
                (x.ToolTag != null && x.ToolTag.Contains(searchTerm))).ToList();

            return new ObservableCollection<Tool>(searchResult);
        }
    }   
}
