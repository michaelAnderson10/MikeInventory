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
            UserDataAccess.AddUser(_userViewModel.UserId, _userViewModel.FirstName, _userViewModel.LastName, _userViewModel.UserPhoneNo, _userViewModel.UserEmail, _userViewModel.UserTag);
            _userViewModel.Users = UserDataAccess.GetUser();
        }
    }
}
