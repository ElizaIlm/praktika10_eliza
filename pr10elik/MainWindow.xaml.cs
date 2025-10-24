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

namespace pr10elik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Passport> Passports = new List<Classes.Passport>();
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            if (lv_passport.SelectedIndex > -1)
                new Windows.Add(lv_passport.SelectedItem as Classes.Passport).ShowDialog();
            else
                MessageBox.Show("Выберите паспорт");
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            new Windows.Add(null).ShowDialog();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (lv_passport.SelectedIndex > -1)
            {
                Passports.Remove(lv_passport.SelectedItem as Classes.Passport);
                LoadPassports();
            }
            else
                MessageBox.Show("Выберите паспорт");
        }
        public void LoadPassports()
        {
            lv_passport.Items.Clear();
            foreach (Classes.Passport Passport in Passports)
            {
                lv_passport.Items.Add(Passport);
            }
        }
    }
}

