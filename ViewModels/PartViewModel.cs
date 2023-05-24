﻿using MikeInventory.Commands;
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
        private int _userIdToDb;
        public int UserIdToDb
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
        private int _supplierIdToDb;
        public int SupplierIdToDb
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

        public PartCommand CreateCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand SearchCommand { get; }


        ////Binding property to UserId ComboBox in PartView
        public ObservableCollection<User> Users { get; set; }
        ////Binding property to SupplierId ComboBox in PartView
        public ObservableCollection<Supplier> Suppliers { get; set; }


        //// Construction
        public PartViewModel()
        {
            _parts = PartDataAccess.GetPart();

            Users = new ObservableCollection<User>(Data.UserDataAccess.GetUser());
            Suppliers = new ObservableCollection<Supplier>(SupplierDataAccess.GetSupplier());

            CreateCommand = new PartCommand(this);

        }

        public void LoadPart()
        {
            this.Parts = new ObservableCollection<Part>(PartDataAccess.GetPart());
        }

    }
      
}
