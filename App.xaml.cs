using Microsoft.EntityFrameworkCore.Query.Internal;
using MikeInventory.ViewModels;
using MikeInventory.Views;
using System.Windows;

namespace MikeInventory
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow();
            mainWindow.Show();

            // Retrieve the ViewModel associated with the MainWindow
            var mainViewModel = mainWindow.DataContext as MainViewModel;

            // Trigger the SwitchViewCommand with the "SwitchToHome" command parameter
            mainViewModel?.SwitchViewCommand.Execute("SwitchToHome");


        }

    }
}
