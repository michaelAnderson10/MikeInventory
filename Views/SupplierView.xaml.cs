using MikeInventory.Models;
using MikeInventory.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace MikeInventory.Views
{
    /// <summary>
    /// Interaction logic for SupplierView.xaml
    /// </summary>
    public partial class SupplierView : UserControl
    {
        public SupplierView()
        {
            InitializeComponent();
            DataContext = new SupplierViewModel();
        }

        private void DatagridSupplier_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Supplier selectedSupplier = (Supplier)DatagridSupplier.SelectedItem;

            TxtIdSupplier.Text=selectedSupplier.SupplierId.ToString();
            TxtDescriptionSupplier.Text=selectedSupplier.SupplierName;
            TxtAddressSupplier.Text = selectedSupplier.SupplierAddress;
            TxtPhoneSupplier.Text = selectedSupplier.SupplierPhone;
            TxtEmailSupplier.Text = selectedSupplier.SupplierEmail;
            TxtTagSupplier.Text = selectedSupplier.SupplierTag;
            
        }

        private void BtnClearSupplier_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            TxtIdSupplier.Text = "0";
            TxtDescriptionSupplier.Text = string.Empty;
            TxtAddressSupplier.Text = string.Empty;
            TxtPhoneSupplier.Text = string.Empty;
            TxtEmailSupplier.Text= string.Empty;
            TxtTagSupplier.Text= string.Empty;
        }
    }
}
