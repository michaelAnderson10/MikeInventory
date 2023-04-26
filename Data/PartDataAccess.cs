﻿using MikeInventory.Models;
using System.Collections.Generic;
using System.Linq;


namespace MikeInventory.Data
{
    public class PartDataAccess
    {
        public static void AddPart()
        {
            
            
            using var context = new MikeInventoryContext();
            var db = new Part
            {

                PartId = 109,
                PartDescription = "Double Tape",
                PartQuantity = 5,
                PartTag = "double tape",
                UserID = 100,              
                
            };
            context.Parts.Add(db);
            context.SaveChanges();
        }

        ////Read all records in People table
        public static List<Part> GetPart()
        {
            using (var db = new MikeInventoryContext())
            {
                return db.Parts.ToList();
            }
        }
        //public ObservableCollection<Part>? parts;
        //public PartDataAccess()
        //{
        //    parts = new ObservableCollection<Part>(PartDataAccess.GetPart());
        //}


        ////Update a record in People table
        //public static void UpdateUser()
        //{
        //    User varUpdate = new User();
        //    using var db = new MikeInventoryContext();
        //    varUpdate = db.Users.Where(x => x.UserId == 3).First();
        //    varUpdate.FirstName = "Michael";
        //    db.SaveChanges();
        //}


        ////Delete record from People table  
        //public static void RemoveUser()
        //{
        //    User varRemove = new User();
        //    using var db = new MikeInventoryContext();
        //    varRemove = db.Users.Where(x => x.UserId == 3).First();
        //    db.Users.Remove(varRemove);
        //    db.SaveChanges();
        //}

        //public static List<User> SearchUser()
        //{
        //    using var db = new MikeInventoryContext();
        //    return db.Users.Where(x => x.UserId == 3).ToList();

        //}
    }
}
