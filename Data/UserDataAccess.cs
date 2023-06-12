using MikeInventory.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace MikeInventory.Data
{

    public class UserDataAccess
    {

        //Create new record in People table
        public static void AddUser(int userId, string? firstName, string? lastName, string? phoneNo, string? email, string? userTag)
        {
            using var context = new MikeInventoryContext();

            bool userExists = context.Users.Any(p => p.UserId == userId);
            if (userExists)
            {
                MessageBox.Show("User Id already exist, please assign a different User Id.", "Duplicate Part", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

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
        public static ObservableCollection<User> GetUser()
        {
            using (var db = new MikeInventoryContext())
            {
                return new ObservableCollection<User>(db.Users.ToList());
            }
        }

        //Update a record in People table
        public static void UpdateUser(int userId, string? firstName, string? lastName, string? phoneNo, string? email, string? userTag)
        {
            using var db = new MikeInventoryContext();
            User? userToUpdate = db.Users.FirstOrDefault(x => x.UserId == userId);
            if (userToUpdate != null)
            {
                userToUpdate.FirstName = firstName;
                userToUpdate.LastName = lastName;
                userToUpdate.UserPhoneNo = phoneNo;
                userToUpdate.UserEmail = email;
                userToUpdate.UserTag = userTag;
                db.SaveChanges();
            }
        }


        ////Delete record from People table
        public static void RemoveUser(int userSelectedId)
        {
            User varRemove = new User();
            using var db = new MikeInventoryContext();
            varRemove = db.Users.Where(x => x.UserId == userSelectedId).First();
            db.Users.Remove(varRemove);
            db.SaveChanges();
        }

        public static ObservableCollection<User> SearchUser(string searchTerm)
        {
            using var db = new MikeInventoryContext();
            var searchResult = db.Users.Where(x =>
                x.UserId.ToString().Contains(searchTerm) ||
                (x.FirstName != null && x.FirstName.Contains(searchTerm)) ||
                (x.LastName != null && x.LastName.Contains(searchTerm)) ||
                (x.UserPhoneNo != null && x.UserPhoneNo.Contains(searchTerm)) ||
                (x.UserEmail != null && x.UserEmail.Contains(searchTerm)) ||
                (x.UserTag != null && x.UserTag.Contains(searchTerm))).ToList();

            return new ObservableCollection<User>(searchResult);
        }

        //public static void ClearUserControls(int userId, string? firstName, string? lastName, string? phoneNo, string? email, string? userTag)
        //{
        //    userId = 0;
        //    firstName = string.Empty;
        //    lastName = string.Empty;
        //    phoneNo = string.Empty;
        //    email = string.Empty;
        //    userTag = string.Empty;
        //}
    }
}
