using MikeInventory.Data;
using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.ViewModels;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace MikeInventory.Commands
{
    public class PartCommand : BaseCommand
    {
        private readonly PartViewModel _viewModel;
        public PartCommand(PartViewModel viewModel)
        {
            _viewModel = viewModel;            
        }

        public void CheckSupplierAndUserIdIfNull()
        {
            if (!_viewModel.Suppliers.Any(s => s.SupplierId == _viewModel.SupplierIdToDb))
            {
                _viewModel.SupplierIdToDb = null;
            }
            if (!_viewModel.Users.Any(u => u.UserId == _viewModel.UserIdToDb))
            {
                _viewModel.UserIdToDb = null;
            }
        }

        public override void Execute(object? parameter)
        {
            switch (parameter?.ToString())
            {
                case "CreatePart":
                    CheckSupplierAndUserIdIfNull();
                    PartDataAccess.AddPart(_viewModel.PartIdToDb, _viewModel.PartDescription, _viewModel.PartQuantity, _viewModel.SupplierIdToDb, _viewModel.PartTag, _viewModel.UserIdToDb);
                    _viewModel.Parts = PartDataAccess.GetPart();
                    break;
                case "UpdatePart":
                    CheckSupplierAndUserIdIfNull();
                    PartDataAccess.UpdatePart(_viewModel.PartIdToDb, _viewModel.PartDescription, _viewModel.PartQuantity, _viewModel.SupplierIdToDb, _viewModel.PartTag, _viewModel.UserIdToDb);
                    _viewModel.Parts = PartDataAccess.GetPart();
                    break;
                case "DeletePart":
                    if (_viewModel.PartSelectedId != null)
                    {
                        int selectedPartId = int.Parse(_viewModel.PartSelectedId);
                        PartDataAccess.RemovePart(selectedPartId);
                        _viewModel.Parts = PartDataAccess.GetPart();
                    }
                    break;
                case "SearchPart":
                    _viewModel.Parts = PartDataAccess.SearchPart(_viewModel.PartSearch);
                    break;
            }
           
        }
         
    }   
}

