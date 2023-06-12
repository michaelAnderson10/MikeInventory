using MikeInventory.Commands;
using MikeInventory.Data;
using MikeInventory.Models;
using System.Collections.ObjectModel;

namespace MikeInventory.ViewModels
{
    public class SupplierViewModel : BaseViewModel
    {
        private int _supplierId;
        public int SupplierId
        {
            get 
            {
                return _supplierId; 
            }
            set
            {
                _supplierId = value;
                OnPropertyChanged(nameof(SupplierId));
            }
        }

        private string _supplierName;
        public string SupplierName
        {
            get
            {
                return _supplierName;
            }
            set
            {
                _supplierName = value;
                OnPropertyChanged(nameof(SupplierName));
            }
        }
        private string? _supplierAddress;
        public string? SupplierAddress
        {
            get
            {
                return _supplierAddress;
            }
            set
            {
                _supplierAddress = value;
                OnPropertyChanged(nameof(SupplierAddress));
            }
        }
        private string? _supplierPhone;
        public string? SupplierPhone
        {
            get
            {
                return _supplierPhone;
            }
            set
            {
                _supplierPhone = value;
                OnPropertyChanged(nameof(SupplierPhone));
            }
        }
        private string? _supplierEmail;
        public string? SupplierEmail
        {
            get
            {
                return _supplierEmail;
            }
            set
            {
                _supplierEmail = value;
                OnPropertyChanged(nameof(SupplierEmail));
            }
        }

        private string? _supplierTags;
        public string? SupplierTags
        {
            get
            {
                return _supplierTags;
            }
            set
            {
                _supplierTags = value;
                OnPropertyChanged(nameof(SupplierTags));
            }
        }

        private string _supplierSearch;
        public string SupplierSearch
        {
            get { return _supplierSearch; }
            set
            {
                _supplierSearch = value;
                OnPropertyChanged(nameof(SupplierSearch));
            }

        }

        private string _supplierSelectedId;
        public string SupplierSelectedId
        {
            get { return _supplierSelectedId; }
            set
            {
                _supplierSelectedId = value;
                OnPropertyChanged(nameof(SupplierSelectedId));
            }

        }

        private ObservableCollection<Supplier> _suppliers;
        public ObservableCollection<Supplier> Suppliers
        {
            get 
            {
                return _suppliers; 
            }
            set
            { 
                _suppliers = value;
                OnPropertyChanged(nameof(Suppliers));
            }
        }

        public SupplierCommand SupplierCommand { get; set; }

        public SupplierViewModel()
        {
            SupplierCommand = new SupplierCommand(this);
            _suppliers = SupplierDataAccess.GetSupplier();
        }

    }
}
