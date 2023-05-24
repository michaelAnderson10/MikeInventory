using MikeInventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace MikeInventory.Data
{

    public class UserDataAccess
    {

        //Create new record in People table
        public static void AddUser(int userId, string firstName, string lastName, string phoneNo, string email, string userTag)
        {
            using var context = new MikeInventoryContext();

            var db = new User
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                UserPhoneNo = phoneNo,
                UserEmail = email,
                UserTag = userTag               
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
