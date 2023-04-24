using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using MikeInventory.Data;
using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.InteropServices;

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

        //public ObservableCollection<Part> parts { get; set; }
        //public PartViewModel()
        //{
        //    parts = new ObservableCollection<Part>(PartDataAccess.GetPart());
        //    OnPropertyChanged(nameof(Part));
        //}

        private ObservableCollection<Part> _parts;
        public ObservableCollection<Part> parts
        {
            get
            {
                return _parts;
            }
            set
            {
                if (_parts != value)
                {
                    _parts = value;
                    OnPropertyChanged(nameof(parts));
                }
            }
        }
        public PartViewModel()
        {
            _parts = new ObservableCollection<Part>(PartDataAccess.GetPart());
        }


    }
}
