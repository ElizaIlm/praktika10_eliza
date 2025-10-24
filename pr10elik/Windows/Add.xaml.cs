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
using System.Windows.Shapes;

namespace pr10elik.Windows
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        Classes.Passport EditPassport;
        public Add(Classes.Passport EditPassport)
        {

            InitializeComponent();
            if (EditPassport != null)
            {
                Name.Text = EditPassport.Name;
                FirstName.Text = EditPassport.Firstname;
                LastName.Text = EditPassport.Lastname;
                Issued.Text = EditPassport.Issued;
                DateOfIssued.Text = EditPassport.DateOfIssued;
                DepatmentCode.Text = EditPassport.DepatmentCode;
                SerialAndNumber.Text = EditPassport.SerialAndNumber;
                DateOfBirth.Text = EditPassport.DateOfBirth;
                PlaceOfBirth.Text = EditPassport.PlaceOfBirth;
                BthAdd.Content = "Сохранить";
                this.EditPassport = EditPassport;
            }
        }

        private void AddPassport(object sender, RoutedEventArgs e)
        {
            
            if (EditPassport == null)
            {
                EditPassport = new Classes.Passport();
                MainWindow.init.Passports.Add(EditPassport);
            }

            if (EditPassport == null)
            {
                EditPassport = new Classes.Passport();
                MainWindow.init.Passports.Add(EditPassport);
            }
            EditPassport.Name = Name.Text;
            EditPassport.Firstname = FirstName.Text;
            EditPassport.Lastname = LastName.Text;
            EditPassport.Issued = Issued.Text;
            EditPassport.DateOfIssued = DateOfIssued.Text;
            EditPassport.DepatmentCode = DepatmentCode.Text;
            EditPassport.SerialAndNumber = SerialAndNumber.Text;
            EditPassport.DateOfBirth = DateOfBirth.Text;
            EditPassport.PlaceOfBirth = PlaceOfBirth.Text;

            MainWindow.init.LoadPassports();
            this.Close();
        }

        private void SerialAndNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
}
