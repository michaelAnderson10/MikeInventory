using MikeInventory.Data;
using MikeInventory.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace MikeInventory.Views
{

    public partial class PartView : UserControl
    {

        public PartView()
        {
            InitializeComponent();

        }

        private void BtnCreatePart_Click(object sender, RoutedEventArgs e)
        {
            PartDataAccess.AddPart();
        }
    }
}
