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

namespace MikeInventory
{
    
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            CntHome.Visibility = System.Windows.Visibility.Visible;
            CntPart.Visibility = System.Windows.Visibility.Hidden;
            CntTool.Visibility = System.Windows.Visibility.Hidden;
            CntSupplier.Visibility = System.Windows.Visibility.Hidden;
            CntUser.Visibility = System.Windows.Visibility.Hidden;
        }

        private void BtnPart_Click(object sender, RoutedEventArgs e)
        {
            CntHome.Visibility = System.Windows.Visibility.Hidden;
            CntPart.Visibility = System.Windows.Visibility.Visible;
            CntTool.Visibility = System.Windows.Visibility.Hidden;
            CntSupplier.Visibility = System.Windows.Visibility.Hidden;
            CntUser.Visibility = System.Windows.Visibility.Hidden;
        }

        private void BtnTool_Click(object sender, RoutedEventArgs e)
        {
            CntHome.Visibility = System.Windows.Visibility.Hidden;
            CntPart.Visibility = System.Windows.Visibility.Hidden;
            CntTool.Visibility = System.Windows.Visibility.Visible;
            CntSupplier.Visibility = System.Windows.Visibility.Hidden;
            CntUser.Visibility = System.Windows.Visibility.Hidden;
        }

        private void BtnSupplier_Click(object sender, RoutedEventArgs e)
        {
            CntHome.Visibility = System.Windows.Visibility.Hidden;
            CntPart.Visibility = System.Windows.Visibility.Hidden;
            CntTool.Visibility = System.Windows.Visibility.Hidden;
            CntSupplier.Visibility = System.Windows.Visibility.Visible;
            CntUser.Visibility = System.Windows.Visibility.Hidden;
        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            CntHome.Visibility = System.Windows.Visibility.Hidden;
            CntPart.Visibility = System.Windows.Visibility.Hidden;
            CntTool.Visibility = System.Windows.Visibility.Hidden;
            CntSupplier.Visibility = System.Windows.Visibility.Hidden;
            CntUser.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
 