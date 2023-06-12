using MikeInventory.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System;

namespace MikeInventory.Data
{
    public class SupplierDataAccess
    {
        public static void AddSupplier(int supplierId, string supplierName, string? supplierAddress, string? supplierPhone, string? supplierEmail, string? supplierTag) 
        {
            using var Context = new MikeInventoryContext();

            bool supplierExists = Context.Suppliers.Any(p => p.SupplierId == supplierId);
            if (supplierExists)
            {
                MessageBox.Show("User Id already exist, please assign a different User Id.", "Duplicate Part", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            var db = new Supplier
            {
                SupplierId = supplierId,
                SupplierName = supplierName,
                SupplierAddress = supplierAddress,
                SupplierPhone = supplierPhone,
                SupplierEmail = supplierEmail,
                SupplierTag = supplierTag
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

        public static void UpdateSupplier(int supplierId, string supplierName, string? supplierAddress, string? supplierPhone, string? supplierEmail, string? supplierTag)
        {
            using var db = new MikeInventoryContext();
            Supplier? supplierToUpdate = db.Suppliers.FirstOrDefault(x => x.SupplierId == supplierId);
            if (supplierToUpdate != null)
            {
                supplierToUpdate.SupplierId = supplierId;
                supplierToUpdate.SupplierName = supplierName;
                supplierToUpdate.SupplierAddress = supplierAddress;
                supplierToUpdate.SupplierPhone = supplierPhone;
                supplierToUpdate.SupplierEmail = supplierEmail;
                supplierToUpdate.SupplierTag = supplierTag;

                db.SaveChanges();
            }
        }

        public static void RemoveSupplier(int supplierSelectedId)
        {
            Supplier varRemove = new Supplier();
            using var db = new MikeInventoryContext();
            varRemove = db.Suppliers.Where(x => x.SupplierId == supplierSelectedId).First();
            db.Suppliers.Remove(varRemove);
            db.SaveChanges();
        }

        public static ObservableCollection<Supplier> SearchSupplier(string searchTerm)
        {
            using var db = new MikeInventoryContext();
            var searchResult = db.Suppliers.Where(x =>
                x.SupplierId.ToString().Contains(searchTerm) ||
                (x.SupplierName != null && x.SupplierName.Contains(searchTerm)) ||
                (x.SupplierAddress != null && x.SupplierAddress.Contains(searchTerm)) ||
                (x.SupplierPhone != null && x.SupplierPhone.Contains(searchTerm)) ||
                (x.SupplierEmail != null && x.SupplierEmail.Contains(searchTerm)) ||
                (x.SupplierTag != null && x.SupplierTag.Contains(searchTerm))).ToList();

            return new ObservableCollection<Supplier>(searchResult);
        }

    }
}
