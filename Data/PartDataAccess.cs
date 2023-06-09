﻿using Microsoft.EntityFrameworkCore;
using MikeInventory.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace MikeInventory.Data
{
    public class PartDataAccess
    {     
        public static void AddPart(int partId, string partDescription, int partQuantity, int? supplierId, string partTag, int? userId)
        {
            using var context = new MikeInventoryContext();

            bool partExists = context.Parts.Any(p => p.PartId == partId);
            if (partExists)
            {
                MessageBox.Show("Part number already exist, please assign a different Part number.", "Duplicate Part", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var db = new Part
            {
                PartId = partId,
                PartDescription = partDescription,
                PartQuantity = partQuantity,
                SupplierID = supplierId,
                PartTag = partTag,
                UserID = userId,             
            };
            context.Parts.Add(db);
            context.SaveChanges();         
        }


        ////Read all records in People table       
        public static ObservableCollection<Part> GetPart()
        {
            using (var db = new MikeInventoryContext())
            {
                return new ObservableCollection<Part>(db.Parts.Include(t => t.Supplier).Include(t => t.User).ToList());
            }
        }


        //Update a record in Parts table
        public static void UpdatePart(int partId, string partDescription, int partQuantity, int? supplierId, string partTag, int? userId)
        {
            using var db = new MikeInventoryContext();
            Part? partToUpdate = db.Parts.FirstOrDefault(x => x.PartId == partId);
            if (partToUpdate != null)
            {
                partToUpdate.PartId = partId;
                partToUpdate.PartDescription = partDescription;
                partToUpdate.PartQuantity = partQuantity;
                partToUpdate.SupplierID = supplierId;
                partToUpdate.PartTag = partTag;
                partToUpdate.UserID = userId;

                db.SaveChanges();
            }
            else
            {
                string errorMessage = $"Part with ID {partId} not found.";
                Console.WriteLine(errorMessage);
            }

        }


        ////Delete record from Parts table  
        public static void RemovePart(int partSelectedId)
        {
            Part varRemove = new Part();
            using var db = new MikeInventoryContext();
            varRemove = db.Parts.Where(x => x.PartId == partSelectedId).First();
            db.Parts.Remove(varRemove);
            db.SaveChanges();
        }

        public static ObservableCollection<Part> SearchPart(string searchTerm)
        {
            using var db = new MikeInventoryContext();
            var searchResult = db.Parts.Where(x =>
                x.PartId.ToString().Contains(searchTerm) ||
                x.PartDescription.Contains(searchTerm) ||
                (x.PartTag != null && x.PartTag.Contains(searchTerm))).ToList();

            return new ObservableCollection<Part>(searchResult);
        }

    }
}
