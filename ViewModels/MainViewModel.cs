using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using MikeInventory.Commands;

namespace MikeInventory.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel? _currentViewModel;
        public BaseViewModel? CurrentViewModel 
        {
            get { return _currentViewModel; }
            set 
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }
       
        public ICommand SwitchViewCommand { get; set; }


        public MainViewModel()
        {
            SwitchViewCommand = new SwitchViewCommand(this);
        }
    }
}
