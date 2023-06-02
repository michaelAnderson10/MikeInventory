using MikeInventory.Commands;
using MikeInventory.Data;
using MikeInventory.Models;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace MikeInventory.ViewModels
{
    public class PartViewModel : BaseViewModel
    {

        private int _partId;
        public int PartIdToDb
        {
            get
            {
                return _partId;
            }
            set
            {
                _partId = value;
                OnPropertyChanged(nameof(PartIdToDb));
            }
        }

        private string _partDescription;
        public string PartDescription
        {
            get
            {
                return _partDescription;
            }
            set
            {
                _partDescription = value;
                OnPropertyChanged(nameof(PartDescription));
            }
        }

        private int _partQuantity;
        public int PartQuantity
        {
            get
            {
                return _partQuantity;
            }
            set
            {
                _partQuantity = value;
                OnPropertyChanged(nameof(PartQuantity));
            }
        }

        private string _partTag;
        public string PartTag
        {
            get
            {
                return _partTag;
            }
            set
            {
                _partTag = value;
                OnPropertyChanged(nameof(PartTag));
            }
        }

        //// Binding property from User ComboBox to DB
        private int? _userIdToDb;
        public int? UserIdToDb
        {
            get 
            {
                return _userIdToDb;
            }
            set
            {
                _userIdToDb = value;
                OnPropertyChanged(nameof(UserIdToDb));
            }
        }

        //// Binding property from Supplier ComboBox to DB
        private int? _supplierIdToDb;
        public int? SupplierIdToDb
        {
            get { return _supplierIdToDb; }
            set
            {
                _supplierIdToDb = value;
                OnPropertyChanged(nameof(SupplierIdToDb));
            }
        }

        // Binding property for PartView DataGrid
        private ObservableCollection<Part> _parts;
        public ObservableCollection<Part> Parts
        {
            get
            {
                return _parts;
            }
            set
            {
                _parts = value;
                OnPropertyChanged(nameof(Parts));

            }
        }

        private string _partSearch;
        public string PartSearch
        {
            get { return _partSearch; }
            set
            {
                _partSearch = value;
                OnPropertyChanged(nameof(PartSearch));
            }

        }

        private string _partSelectedId;
        public string PartSelectedId
        {
            get { return _partSelectedId; }
            set
            {
                _partSelectedId = value;
                OnPropertyChanged(nameof(PartSelectedId));
            }

        }

        public PartCommand PartCommand { get; }

        ////Binding property to UserId ComboBox in ToolView
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        ////Binding property to SupplierId ComboBox in ToolView
        private ObservableCollection<Supplier> _suppliers;
        public ObservableCollection<Supplier> Suppliers
        {
            get { return _suppliers; }
            set
            {
                _suppliers = value;
                OnPropertyChanged(nameof(Suppliers));
            }
        }
 
        public Supplier Supplier { get; set; }
        public User User { get; set; }

        //// Construction
        public PartViewModel()
        {
            _parts = PartDataAccess.GetPart();

            _suppliers = SupplierDataAccess.GetSupplier();
            _users = UserDataAccess.GetUser();


            PartCommand = new PartCommand(this);

        }

    }
      
}
