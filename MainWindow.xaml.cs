 using System.Collections.Generic;
using System.Windows;
using MikeInventory.Models;
using MikeInventory.Data;
using System;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using Microsoft.Identity.Client;
using System.Windows.Controls;
using MikeInventory.ViewModels;

namespace MikeInventory
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
 