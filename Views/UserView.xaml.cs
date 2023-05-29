using MikeInventory.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MikeInventory.Views
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();                                
        }

        private void DatagridUser_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            User selectedUser = (User)DatagridUser.SelectedItem;

            TxtIdUser.Text = selectedUser.UserId.ToString();
            TxtFirstName.Text = selectedUser.FirstName;
            TxtLastName.Text = selectedUser.LastName;
            TxtPhoneUser.Text = selectedUser.UserPhoneNo;
            TxtEmailUser.Text = selectedUser.UserEmail;
            TxtTagUser.Text = selectedUser.UserTag;

        }

        private void BtnClearUser_Click(object sender, RoutedEventArgs e)
        {
            TxtIdUser.Text = "0";
            TxtFirstName.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtPhoneUser.Text = string.Empty;
            TxtEmailUser.Text = string.Empty;
            TxtTagUser.Text = string.Empty;
        }
    }
}
