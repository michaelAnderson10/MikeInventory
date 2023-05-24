using MikeInventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.Data;
using MikeInventory.Models;
using System.Collections.ObjectModel;

namespace MikeInventory.Commands
{
    public class SupplierCommand : BaseCommand
    {
        private readonly SupplierViewModel _viewModel;

        public SupplierCommand(SupplierViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            SupplierDataAccess.AddSupplier(_viewModel.SupplierId, _viewModel.SupplierName, _viewModel.SupplierAddress, _viewModel.SupplierPhone, _viewModel.SupplierEmail, _viewModel.SupplierTags);
            _viewModel.Suppliers = new ObservableCollection<Supplier>(SupplierDataAccess.GetSupplier());

        }
    }
}
