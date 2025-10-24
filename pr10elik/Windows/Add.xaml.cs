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
            if (String.IsNullOrEmpty(Name.Text) || !Classes.Common.ChechRegex.Match("^[А-Яа-яЁё]*$", Name.Text))
            {
                MessageBox.Show("Не правильно указано имя.");
                return;
            }
            if (String.IsNullOrEmpty(FirstName.Text) || !Classes.Common.ChechRegex.Match("^[А-Яа-яЁё]*$", Name.Text))
            {
                MessageBox.Show("Не правильно указана фамилия.");
                return;
            }
            if (String.IsNullOrEmpty(LastName.Text) || !Classes.Common.ChechRegex.Match("^[А-Яа-яЁё]*$", Name.Text))
            {
                MessageBox.Show("Не правильно указано отчество.");
                return;
            }
            if (String.IsNullOrEmpty(Issued.Text) ||
        !Classes.Common.ChechRegex.Match("^[А-Яа-яЁё0-9\\s\\-\"\",.]*$", Issued.Text))
            {
                MessageBox.Show("Не правильно указано кем выдан паспорт.");
                return;
            }

            // Проверка даты выдачи
            if (String.IsNullOrEmpty(DateOfIssued.Text) ||
                !Classes.Common.ChechRegex.Match("^(0[1-9]|[12][0-9]|3[01])\\.(0[1-9]|1[0-2])\\.(19|20)\\d{2}$", DateOfIssued.Text))
            {
                MessageBox.Show("Не правильно указана дата выдачи. Используйте формат ДД.ММ.ГГГГ");
                return;
            }

            // Проверка кода подразделения
            if (String.IsNullOrEmpty(DepatmentCode.Text) ||
                !Classes.Common.ChechRegex.Match("^\\d{3}-\\d{3}$", DepatmentCode.Text))
            {
                MessageBox.Show("Не правильно указан код подразделения. Формат: XXX-XXX");
                return;
            }

            // Проверка серии и номера паспорта 
            if (String.IsNullOrEmpty(SerialAndNumber.Text) ||
                !Classes.Common.ChechRegex.Match("^\\d{4}\\s\\d{6}$", SerialAndNumber.Text))
            {
                MessageBox.Show("Не правильно указаны серия и номер паспорта. Формат: XXXX XXXXXX");
                return;
            }

            // Проверка даты рождения
            if (String.IsNullOrEmpty(DateOfBirth.Text) ||
                !Classes.Common.ChechRegex.Match("^(0[1-9]|[12][0-9]|3[01])\\.(0[1-9]|1[0-2])\\.(19|20)\\d{2}$", DateOfBirth.Text))
            {
                MessageBox.Show("Не правильно указана дата рождения. Используйте формат ДД.ММ.ГГГГ");
                return;
            }

            // Проверка места рождения
            if (String.IsNullOrEmpty(PlaceOfBirth.Text) ||
                !Classes.Common.ChechRegex.Match("^[А-Яа-яЁё0-9\\s\\-\"\",.]*$", PlaceOfBirth.Text))
            {
                MessageBox.Show("Не правильно указано место рождения.");
                return;
            }

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

