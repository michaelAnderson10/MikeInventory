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

        public override void Execute(object? parameter)
        {          
            PartDataAccess.AddPart(_viewModel.PartIdToDb, _viewModel.PartDescription, _viewModel.PartQuantity, _viewModel.SupplierIdToDb, _viewModel.PartTag, _viewModel.UserIdToDb);
            _viewModel.LoadPart();

        }

    }   
}

