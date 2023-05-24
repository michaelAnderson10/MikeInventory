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
            switch (parameter.ToString())
            {
                case "SwitchToHome":
                    viewModel.CurrentViewModel = new HomeViewModel();
                    break;
                case "SwitchToTool":
                    viewModel.CurrentViewModel = new ToolViewModel();
                    break;
                case "SwitchToPart":
                    viewModel.CurrentViewModel = new PartViewModel();
                    break;
                case "SwitchToSupplier":
                    viewModel.CurrentViewModel = new SupplierViewModel();
                    break;
                case "SwitchToUser":
                    viewModel.CurrentViewModel = new UserViewModel();
                    break;
            }
        }
    }
}
