using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Data
{
    public class SupplierDataAccess
    {
        public static void AddSupplier(int SupplierId, string SupplierName, string SupplierAddress, string SupplierPhone, string SupplierEmail, string SupplierTag) 
        {
            using var Context = new MikeInventoryContext();
            var db = new Supplier
            {
                SupplierId = SupplierId,
                SupplierName = SupplierName,
                SupplierAddress = SupplierAddress,
                SupplierPhone = SupplierPhone,
                SupplierEmail = SupplierEmail,
                SupplierTag = SupplierTag
            };
            Context.Suppliers.Add(db);
            Context.SaveChanges();
        }

        public static ObservableCollection<Supplier> GetSupplier()
        {
            using (var db = new MikeInventoryContext())
            {
                return new ObservableCollection<Supplier>(db.Suppliers.ToList());
            }
        }

    }
}
