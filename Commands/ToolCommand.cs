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
            switch (parameter?.ToString())
            {
                case "CreateTool":
                    _viewModel.CheckSelectedSupplierAndUser();
                    ToolDataAccess.AddTool(_viewModel.ToolId, _viewModel.ToolDescription, _viewModel.ToolQuantity, _viewModel.SupplierIdToDb, _viewModel.ToolTag, _viewModel.UserIdToDb);
                    _viewModel.Tools = ToolDataAccess.GetTool();
                    break;
                case "UpdateTool":
                    _viewModel.CheckSelectedSupplierAndUser();
                    ToolDataAccess.UpdateTool(_viewModel.ToolId, _viewModel.ToolDescription, _viewModel.ToolQuantity, _viewModel.SupplierIdToDb, _viewModel.ToolTag, _viewModel.UserIdToDb);
                    _viewModel.Tools = ToolDataAccess.GetTool();
                    break;
                case "DeleteTool":
                    if (_viewModel.ToolSelectedId != null)
                    {
                        int selectedToolId = int.Parse(_viewModel.ToolSelectedId);
                        ToolDataAccess.RemoveTool(selectedToolId);
                        _viewModel.Tools = ToolDataAccess.GetTool();
                    }
                        break;
                case "SearchTool":
                    _viewModel.Tools = ToolDataAccess.SearchTool(_viewModel.ToolSearch);
                    break;
            }
            
        }
    }
}
