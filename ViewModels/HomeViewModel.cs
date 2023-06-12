using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.Data;
using MikeInventory.Commands;

namespace MikeInventory.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private ObservableCollection<object>? _allComponents;
        public ObservableCollection<object>? AllComponents
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

        private string _componentSearch;
        public string ComponentSearch
        {
            get { return _componentSearch; }
            set
            { 
                _componentSearch = value; 
                OnPropertyChanged(nameof(ComponentSearch));
            }
        }

        public Supplier? Supplier { get; set; }
        public User? User { get; set; }

        public HomeCommand HomeCommand { get; }

        public HomeViewModel()
        {
            AllComponents = HomeDataAccess.GetAllComponent();
            HomeCommand = new HomeCommand(this);
          
        }

    }
}
