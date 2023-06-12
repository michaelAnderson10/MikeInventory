using MikeInventory.Data;
using MikeInventory.ViewModels;

namespace MikeInventory.Commands
{
    public class HomeCommand : BaseCommand
    {
        private readonly HomeViewModel _homeViewModel;
        public HomeCommand(HomeViewModel homeViewModel)
        {
            _homeViewModel = homeViewModel;
        }

        public override void Execute(object? parameter)
        {
            switch (parameter?.ToString())            
            {
                case "SearchHome":
                    _homeViewModel.AllComponents = HomeDataAccess.SearchAllComponent(_homeViewModel.ComponentSearch);
                    break;
            }
        }
    }
}
