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

namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Goods_button_Click(object sender, RoutedEventArgs e)
        {
            Stranici.Content = new Page2();
        }

        private void Clients_button_Click(object sender, RoutedEventArgs e)
        {
            Stranici.Content = new Page1();

        }

        private void Orders_button_Click(object sender, RoutedEventArgs e)
        {
            Stranici.Content = new Page3();

        }

        private void GoodsTeg_button_Click(object sender, RoutedEventArgs e)
        {
            Stranici.Content = new Page4();
        }
    }
}
