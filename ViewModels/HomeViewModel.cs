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

        private ObservableCollection<Category> _categories;
        public ObservableCollection<Category> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }

        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged(nameof(SelectedCategory));
            }
        }

        public HomeCommand HomeCommand { get; }

        public HomeViewModel()
        {
            AllComponents = HomeDataAccess.GetAllComponent();
            Categories = HomeDataAccess.GetCategories();

            HomeCommand = new HomeCommand(this);
        }
    }
}
