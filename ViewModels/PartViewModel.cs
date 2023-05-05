using MikeInventory.Commands;
using MikeInventory.Data;
using MikeInventory.Models;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Windows.Input;

namespace MikeInventory.ViewModels
{
    public class PartViewModel : BaseViewModel
    {

        private int _partId;
        public int PartId
        {
            get
            {
                return _partId;
            }
            set
            {
                _partId = value;
                OnPropertyChanged(nameof(PartId));
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

        //// Binding property from ComboBox to DB
        private int _userIdToDb;
        public int UserIdToDb
        {
            get { return _userIdToDb; }
            set
            {
                _userIdToDb = value;
                OnPropertyChanged(nameof(UserIdToDb));
            }
        }


        //// Provide binding property for PartView DataGrid
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


        //// Construction
        public PartViewModel()
        {
            
            _parts = new ObservableCollection<Part>(PartDataAccess.GetPart());
            OnPropertyChanged(nameof(Parts));

            Users = new ObservableCollection<User>(Data.UserDataAccess.GetUser());
            OnPropertyChanged(nameof(Users));

            CreateCommand = new PartCommand(this);

        }

        public void PartCreatorViewModel()
        {
            CreateCommand.Execute(null);
        }

    }
}
