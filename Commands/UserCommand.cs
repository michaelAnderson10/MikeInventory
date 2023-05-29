using MikeInventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.Data;

namespace MikeInventory.Commands
{
    public class UserCommand : BaseCommand
    {
        private readonly UserViewModel _userViewModel;

        public UserCommand(UserViewModel userViewModel)
        {
            _userViewModel = userViewModel;
        }

        public override void Execute(object? parameter)
        {
            switch (parameter.ToString())
            {
                case "CreateUser":
                    UserDataAccess.AddUser(_userViewModel.UserId, _userViewModel.FirstName, _userViewModel.LastName, _userViewModel.UserPhoneNo, _userViewModel.UserEmail, _userViewModel.UserTag);
                    _userViewModel.Users = UserDataAccess.GetUser();
                    break;
                case "UpdateUser":
                    UserDataAccess.UpdateUser(_userViewModel.UserId, _userViewModel.FirstName, _userViewModel.LastName, _userViewModel.UserPhoneNo, _userViewModel.UserEmail, _userViewModel.UserTag);
                    _userViewModel.Users = UserDataAccess.GetUser();
                    break;
                case "DeleteUser":
                    int selectedUserId = int.Parse(_userViewModel.UserSelectedId);
                    UserDataAccess.RemoveUser(selectedUserId);
                    _userViewModel.Users = UserDataAccess.GetUser();
                    break;
                case "SearchUser":
                    _userViewModel.Users = UserDataAccess.SearchUser(_userViewModel.UserSearch);
                    break;
                //case "ClearUser":
                //    UserDataAccess.ClearUserControls(_userViewModel.UserId, _userViewModel.FirstName, _userViewModel.LastName, _userViewModel.UserPhoneNo, _userViewModel.UserEmail, _userViewModel.UserTag);
                //    _userViewModel.Users = UserDataAccess.GetUser();
                //    break;
            }
        }
    }
}
