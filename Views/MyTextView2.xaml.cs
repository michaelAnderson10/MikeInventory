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
using System.Windows.Shapes;

namespace MikeInventory.Views
{
    /// <summary>
    /// Interaction logic for MyTextView2.xaml
    /// </summary>
    public partial class MyTextView2 : Window
    {
        public MyTextView2()
        {
            InitializeComponent();
            DataContext = new PartViewModel();
        }
    }
}
