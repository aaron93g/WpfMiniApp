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
using System.Windows.Shapes;
using WpfAppLibrary.Models;

namespace personInfoForm
{
    /// <summary>
    /// Interaction logic for AddressInformationWindow.xaml
    /// </summary>
    public partial class AddressInformationWindow : Window
    {

        PersonModel _input;

        public AddressInformationWindow(PersonModel input)
        {
            InitializeComponent();

            _input = input;

            firstNameTextBox.Text = _input.FirstName;
            lastNameTextBox.Text = _input.LastName;
            
            
            addressListBox.ItemsSource = _input.PersonnelAddress;
        }

        private void selectAddressButton_Click(object sender, RoutedEventArgs e)
        {
            // HOW  to connect button to selected item in address LIST BOX
            AddressModel selectedAddress = (AddressModel)addressListBox.SelectedItem;

            AddressViewWindow addressViewWindow = new AddressViewWindow(selectedAddress);
            addressViewWindow.Show();
        }

        private void newAddressButton_Click(object sender, RoutedEventArgs e)
        {
            // create new address model list, add it to personalAddress
            // maybe use selected inex? need to research it next
        }
    }
}
