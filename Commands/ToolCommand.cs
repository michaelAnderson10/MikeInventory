using MikeInventory.Data;
using MikeInventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeInventory.Commands
{
    public class ToolCommand : BaseCommand
    {
        private readonly ToolViewModel _viewModel;

        public ToolCommand(ToolViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            ToolDataAccess.AddTool(_viewModel.ToolId, _viewModel.ToolDescription, _viewModel.ToolQuantity, _viewModel.SupplierIdToDb, _viewModel.ToolTag, _viewModel.UserIdToDb);
            _viewModel.Tools = ToolDataAccess.GetTool();
        }
    }
}
