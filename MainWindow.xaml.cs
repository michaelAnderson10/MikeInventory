using System.Collections.Generic;
using System.Windows;
using MikeInventory.Models;
using MikeInventory.Data;
using System;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using Microsoft.Identity.Client;

namespace MikeInventory
{
    
    public partial class MainWindow : Window
    {
        
        public ObservableCollection<Person> persons;
        public MainWindow()
        {
            InitializeComponent();


            persons = new ObservableCollection<Person>(PersonData.GetPerson());
            //persons = new ObservableCollection<Person>(PersonData.GetPerson());
           

            MyDataGrid.ItemsSource= persons;

        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
                                  
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            PersonData.AddPerson();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            PersonData.UpdatePerson();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            PersonData.RemovePerson();
        }
    }
}
 