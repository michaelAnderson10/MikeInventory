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
        public int? myVariable;

        public ObservableCollection<Person> persons;
        public MainWindow()
        {
            InitializeComponent();

            persons = new ObservableCollection<Person>(PersonData.GetPerson());        

            DatagridMain.ItemsSource= persons;

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

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DatagridMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person selectedPerson = (Person)DatagridMain.SelectedItem;
            myVariable = selectedPerson.Id;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
 