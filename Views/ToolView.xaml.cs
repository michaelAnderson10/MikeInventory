using MikeInventory.Models;
using MikeInventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MikeInventory.Views
{
    /// <summary>
    /// Interaction logic for ToolView.xaml
    /// </summary>
    public partial class ToolView : UserControl
    {
        public ToolView()
        {
            InitializeComponent();
            DataContext = new ToolViewModel();
        }

        private void DatagridTool_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Tool selectedTool = (Tool)DatagridTool.SelectedItem;

            TxtIdTool.Text = selectedTool.ToolId.ToString();
            TxtDescriptionTool.Text = selectedTool.ToolDescription;
            TxtIdTool.Text = selectedTool.ToolQuantity.ToString();
            TxtTagTool.Text = selectedTool.ToolTag;

            //cmbSupplierTool.SelectedItem = selectedTool.SupplierID.ToString();
            //CmbUserPart.SelectedItem = selectedTool.UserID.ToString();
        }

        private void BtnClearTool_Click(object sender, RoutedEventArgs e)
        {
            TxtIdTool.Text = "0";
            TxtDescriptionTool.Text = string.Empty;
            TxtIdTool.Text = "0";
            TxtTagTool.Text = string.Empty;

            CmbSupplierTool.SelectedItem = null;
            CmbUserTool.SelectedItem = null;
        }
    }
}
