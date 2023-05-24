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
    public class HomeViewModel : BaseViewModel
    {
        private ObservableCollection<object> _allComponents;
        public ObservableCollection<object> AllComponents
        {
            get
            {
                return _allComponents;
            }
            set
            {
                _allComponents = value;
                OnPropertyChanged(nameof(AllComponents));

            }
        }

        public HomeViewModel()
        {
            AllComponents = HomeDataAccess.GetAllComponent();
        }
    }
}
