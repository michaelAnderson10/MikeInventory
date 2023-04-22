using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using MikeInventory.Data;
using MikeInventory.Models;


namespace MikeInventory.Data
{
    
    public class UserDataAccess
    {

        //Create new record in People table
        public static void AddUser()
        {
            var context = new MikeInventoryContext();

            var db = new User
            {
                FirstName = "Nora",
            };
            context.Users.Add(db);
            context.SaveChanges();
             
        }

        //Read all records in People table
        public static List<User> GetUser()
        {
            using (var db = new MikeInventoryContext())
            {
                return db.Users.ToList();
            }
        }

        //Update a record in People table
        public static void UpdateUser()
        {
            User varUpdate = new User();
            using var db = new MikeInventoryContext();
            varUpdate = db.Users.Where(x => x.UserId == 3).First();
            varUpdate.FirstName = "Michael";
            db.SaveChanges();  
        }


        //Delete record from People table  
        public static void RemoveUser()
        {
            User varRemove = new User();
            using var db = new MikeInventoryContext();
            varRemove = db.Users.Where(x => x.UserId == 3).First();
            db.Users.Remove(varRemove);
            db.SaveChanges();
        }

        public static List<User> SearchUser()
        {
            using var db = new MikeInventoryContext();
            return db.Users.Where(x => x.UserId == 3).ToList();

        }

    }
}
