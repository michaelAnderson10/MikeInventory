using MikeInventory.Commands;
using MikeInventory.Data;
using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.ViewModels
{
    public class ToolViewModel: BaseViewModel
    {
        private int _toolId;
        public int ToolId 
        {
            get { return _toolId; }
            set
            {
                _toolId = value;
                OnPropertyChanged(nameof(ToolId));
            }
        }

        private string _toolDescription;
        public string ToolDescription
        {
            get { return _toolDescription; }
            set
            {
                _toolDescription = value;
                OnPropertyChanged(nameof(ToolDescription));
            }
        }

        private int _toolQuantity;
        public int ToolQuantity
        {
            get { return _toolQuantity; }
            set
            {
                _toolQuantity = value;
                OnPropertyChanged(nameof(ToolQuantity));
            }
        }

        private string _toolTag;
        public string ToolTag
        {
            get { return _toolTag; }
            set 
            {
                _toolTag = value;
                OnPropertyChanged(nameof(ToolTag));
            }
        }

        private int? _userIdToDb;
        public int? UserIdToDb
        {
            get { return _userIdToDb; }
            set
            {
                _userIdToDb = value;
                OnPropertyChanged(nameof(UserIdToDb));
            }
        }

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

        private ObservableCollection<Tool> _tools;
        public ObservableCollection<Tool> Tools
        {
            get { return _tools; }
            set
            {
                _tools = value;
                OnPropertyChanged(nameof(Tools));
            }
        }

        private string _toolSearch;
        public string ToolSearch
        {
            get { return _toolSearch; }
            set
            {
                _toolSearch = value;
                OnPropertyChanged(nameof(ToolSearch));
            }

        }

        private string _toolSelectedId;
        public string ToolSelectedId
        {
            get { return _toolSelectedId; }
            set
            {
                _toolSelectedId = value;
                OnPropertyChanged(nameof(ToolSelectedId));
            }

        }

        public ToolCommand ToolCommand { get; set; }

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

        public ToolViewModel()
        {
            _tools = ToolDataAccess.GetTool();

            _suppliers = SupplierDataAccess.GetSupplier();
            _users = UserDataAccess.GetUser();

            ToolCommand = new ToolCommand(this);
        }

        public void CheckSelectedSupplierAndUser()
        {
            if (!_suppliers.Any(s => s.SupplierId == _supplierIdToDb))
            {
                _supplierIdToDb = null;
            }

            if (!_users.Any(u => u.UserId == _userIdToDb))
            {
                _userIdToDb = null;
            }
        }

    }
}
