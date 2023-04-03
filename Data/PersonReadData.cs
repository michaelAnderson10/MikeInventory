using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.Models;

namespace MikeInventory.Data
{
    public class PersonReadData: ObservableCollection<Person>
    {
        public PersonReadData() : base()
        {
        //Add(new Person("Michael"));
        
        }
    }
}
