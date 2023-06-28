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
using WpfAppLibrary.Models;

namespace personInfoForm
{
    /// <summary>
    /// Interaction logic for AddressViewWindow.xaml
    /// </summary>
    public partial class AddressViewWindow : Window
    {
        AddressModel _address;
        public AddressViewWindow(AddressModel address)
        {
            InitializeComponent();
            _address = address;

            streetAddressTextBox.Text = address.Street;
            cityTextBox.Text = address.City;
            stateTextBox.Text = address.State;
            zipeCodeTextBox.Text = address.ZipCode;
            emailTextBox.Text = address.Email;
        }

        private void saveAddressInformation_Click(object sender, RoutedEventArgs e)
        {
            _address.Street = streetAddressTextBox.Text;
            _address.City = cityTextBox.Text;
            _address.State = stateTextBox.Text;
            _address.ZipCode = zipeCodeTextBox.Text;
            _address.Email = emailTextBox.Text;

            Close();
        }
    }
}
