using MikeInventory.Data;
using MikeInventory.Models;
using MikeInventory.ViewModels;
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

        private void DatagridPart_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Part selectedPart = (Part)DatagridPart.SelectedItem;

            TxtIdPart.Text = selectedPart.PartId.ToString();
            TxtDescriptionPart.Text = selectedPart.PartDescription;
            TxtQtyPart.Text = selectedPart.PartQuantity.ToString();
            TxtTagPart.Text = selectedPart.PartTag;

            //cmbSupplierPart.SelectedItem = selectedPart.SupplierID.ToString();
            //CmbUserPart.SelectedItem = selectedPart.UserID.ToString();

        }

        private void BtnClearPart_Click(object sender, RoutedEventArgs e)
        {
            TxtIdPart.Text = "0";
            TxtDescriptionPart.Text = string.Empty;
            TxtQtyPart.Text = "0";
            TxtTagPart.Text = string.Empty;

            CmbSupplierPart.SelectedItem = null;
            CmbUserPart.SelectedItem = null;

        }

    }
}




