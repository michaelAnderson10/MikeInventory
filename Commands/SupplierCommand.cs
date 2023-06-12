using MikeInventory.Data;
using MikeInventory.ViewModels;

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
            switch (parameter?.ToString())
            {
                case "CreateSupplier":
                    SupplierDataAccess.AddSupplier(_viewModel.SupplierId, _viewModel.SupplierName, _viewModel.SupplierAddress, _viewModel.SupplierPhone, _viewModel.SupplierEmail, _viewModel.SupplierTags);
                    _viewModel.Suppliers = SupplierDataAccess.GetSupplier();
                    break;
                case "UpdateSupplier":
                    SupplierDataAccess.UpdateSupplier(_viewModel.SupplierId, _viewModel.SupplierName, _viewModel.SupplierAddress, _viewModel.SupplierPhone, _viewModel.SupplierEmail, _viewModel.SupplierTags);
                    _viewModel.Suppliers = SupplierDataAccess.GetSupplier();
                    break;
                case "DeleteSupplier":
                    int selectedSupplierId = int.Parse(_viewModel.SupplierSelectedId);
                    SupplierDataAccess.RemoveSupplier(selectedSupplierId);
                    _viewModel.Suppliers = SupplierDataAccess.GetSupplier();
                    break;
                case "SearchSupplier":
                    _viewModel.Suppliers = SupplierDataAccess.SearchSupplier(_viewModel.SupplierSearch);
                    break;
            }      

        }
    }
}
