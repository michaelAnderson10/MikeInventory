using MikeInventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MikeInventory.Commands
{
    class SwitchViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public SwitchViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter.ToString() == "SwitchToPart")
            {
               viewModel.CurrentViewModel = new PartViewModel();
            }
            else if(parameter.ToString() == "SwitchToUser")
            {
                viewModel.CurrentViewModel = new UserViewModel();
            }
        }
    }
}
