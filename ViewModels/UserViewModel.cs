using MikeInventory.Commands;
using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.Data;

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

        private string _userEmail;
        public string UserEmail
        {
            get { return _userEmail; }
            set
            {
                _userEmail = value;
                OnPropertyChanged(nameof(UserPhoneNo));
            }

        }

        private string _userTag;
        public string UserTag
        {
            get { return _userTag; }
            set
            {
                _userTag = value;
                OnPropertyChanged(nameof(UserTag));
            }
            
        }

        private string _userSearch;
        public string UserSearch
        {
            get { return _userSearch; }
            set
            {
                _userSearch = value;
                OnPropertyChanged(nameof(UserSearch));
            }

        }

        private string _userSelectedId;
        public string UserSelectedId
        {
            get { return _userSelectedId; }
            set
            {
                _userSelectedId = value;
                OnPropertyChanged(nameof(UserSelectedId));
            }

        }

        private List<User> _users;
        public List<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        public UserCommand UserCommand { get; set; }
       
        public UserViewModel()
        {
            UserCommand = new UserCommand(this);

            _users = UserDataAccess.GetUser();
        }

        //public void ClearText()
        //{
        //    UserId = 0;
        //    FirstName = string.Empty;
        //    LastName = string.Empty;
        //    UserPhoneNo = string.Empty;
        //    UserEmail = string.Empty;
        //    UserTag = string.Empty;
        //}

    }
}
 