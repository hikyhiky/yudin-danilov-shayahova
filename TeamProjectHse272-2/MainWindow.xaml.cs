﻿using System;
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

namespace TeamProjectHse272_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Logic.DbInitialization();
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addwindow = new AddEditWindow();
            addwindow.ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow editwindow = new AddEditWindow();
            editwindow.ShowDialog();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //[dataGridMain.SelectedIndex]
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource categoryViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoryViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // categoryViewSource.Source = [универсальный источник данных]
        }
    }
}
