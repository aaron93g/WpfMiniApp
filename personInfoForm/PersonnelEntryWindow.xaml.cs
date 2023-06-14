using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfAppLibrary.Models;

namespace personInfoForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PersonnelEntryWindow : Window
    {
        BindingList<PersonModel> people = new BindingList<PersonModel>();

        public PersonnelEntryWindow()
        {
            InitializeComponent();

            fullNameListBox.ItemsSource = people;
            
        }

        private void saveNameButton_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
            };

            people.Add(person);
        }

        private void fullNameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Work on connecting selected item to Personnel Addresses Form
        }
    }
}
