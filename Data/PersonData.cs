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
    

    public class PersonData
    {

        //Create new record in People table
        public static void AddPerson()
        {
            var context = new MikeInventoryContext();

            var db = new Person
            {
                Name = "Nora",
            };
            context.Persons.Add(db);
            context.SaveChanges();

        }

        //Read all records in People table
        public static List<Person> GetPerson()
        {
            using (var db = new MikeInventoryContext())
            {
                return db.Persons.ToList();
            }
        }

        //Update a record in People table
        public static void UpdatePerson()
        {
            Person varUpdate = new Person();
            using var db = new MikeInventoryContext();
            varUpdate = db.Persons.Where(x => x.Id == 4).First();
            varUpdate.Name = "Frank";
            db.SaveChanges();
        }


        //Delete record from People table
        public static void RemovePerson()
        {
            Person varRemove = new Person();
            using var db = new MikeInventoryContext();
            varRemove = db.Persons.Where(x => x.Id == 4).First();
            db.Persons.Remove(varRemove);
            db.SaveChanges();
        }

        public static List<Person> SearchPerson()
        {
            using var db = new MikeInventoryContext();
            return db.Persons.Where(x => x.Id == 4).ToList();

        }

    }
}
