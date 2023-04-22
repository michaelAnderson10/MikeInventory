using MikeInventory.Data;
using MikeInventory.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace MikeInventory.Views
{
    /// <summary>
    /// Interaction logic for PartView.xaml
    /// </summary>
    public partial class PartView : UserControl
    {
        public ObservableCollection<Part>? parts;
        public PartView()
        {

            InitializeComponent();

        }

        private void TestRunPart_Click(object sender, RoutedEventArgs e)
        {
            //parts = new ObservableCollection<Part>(PartDataAccess.GetPart());
            //DatagridPart.ItemsSource = parts;

        }
    }
}
