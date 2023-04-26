using MikeInventory.Data;
using MikeInventory.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MikeInventory.Views
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        //public ObservableCollection<User> users;
        public UserView()
        {
            InitializeComponent();
                      
            //users = new ObservableCollection<User>(UserDataAccess.GetUser());

            //DatagridUser.ItemsSource = users;
           
        }

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            Data.UserDataAccess.AddUser();
        }
    }
}
