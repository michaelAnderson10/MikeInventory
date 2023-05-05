using MikeInventory.Models;
using MikeInventory.Views;
using System.Collections.Generic;
using System.Linq;


namespace MikeInventory.Data
{
    public class PartDataAccess
    {


        public static void AddPart(int partId, string partDescription, int partQuantity, string partTag, int userId)
        {

            using var context = new MikeInventoryContext();
            var db = new Part
            {

                PartId = partId,
                PartDescription = partDescription,
                PartQuantity = partQuantity,
                PartTag = partTag,
                UserID = userId,

                //PartId = 120,
                //PartDescription = "test description",
                //PartQuantity = 15,
                //PartTag = "tag fot the part",
                //UserID = 101,

            };
            context.Parts.Add(db);
            context.SaveChanges();
        }

        //public static void AddPart()
        //{

        //    using var context = new MikeInventoryContext();
        //    var db = new Part
        //    {

        //        PartId = 120,
        //        PartDescription = "Microscope",
        //        PartQuantity = 1,
        //        PartTag = "Am scope",
        //        UserID = 101,

        //    };
        //    context.Parts.Add(db);
        //    context.SaveChanges();
        //}

        //public static void AddPart(Part part)
        //{
        //    using var context = new MikeInventoryContext();
        //    context.Parts.Add(part);
        //    context.SaveChanges();
        //}






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
