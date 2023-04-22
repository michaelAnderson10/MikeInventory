using MikeInventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Views
{
    public class MainViewModel:BaseViewModel
    {
        public BaseViewModel CurrentViewModel { get; set; }

        public MainViewModel()
        {
            CurrentViewModel = new PartViewModel();
        }
    }
}
