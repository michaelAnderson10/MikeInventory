using MikeInventory.Commands;
using MikeInventory.Data;
using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
        private string _supplierAddress;
        public string SupplierAddress
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
        private string _supplierPhone;
        public string SupplierPhone
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
        private string _supplierEmail;
        public string SupplierEmail
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

        private string _supplierTags;
        public string SupplierTags
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

        public SupplierCommand CreateSupplierCommand { get; set; }

        public SupplierViewModel()
        {
            CreateSupplierCommand = new SupplierCommand(this);
            _suppliers = SupplierDataAccess.GetSupplier();
        }

    }
}
