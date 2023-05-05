using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.ViewModels
{
    public class UserViewModel:BaseViewModel
    {
        private int _userId;
        public int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
                OnPropertyChanged(nameof(UserId));
            }
        }
     
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get 
            { 
                return _lastName; 
            }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private string _userPhoneNo;
        public string UserPhoneNo
        {
            get
            {
                return _userPhoneNo;
            }
            set
            {
                _userPhoneNo = value;
                OnPropertyChanged(nameof(UserPhoneNo));
            }
        }

        private string _userName;
        public string UserEmail
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserPhoneNo));
            }

        }

        private string _userTag;
        public string UserTag
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserTag));
            }
            
        }
        

        public ObservableCollection<User> Users { get; set; }
        public UserViewModel()
        {
            Users = new ObservableCollection<User>(Data.UserDataAccess.GetUser());
        }

    }
}
 