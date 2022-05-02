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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebBrowser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            /*Pass*/
        }
        private void Browser_AddressChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            /*Pass*/
        }
        private void AddressButton(object sender, RoutedEventArgs e)
        {
            ChangeAdress();
        }
        private void ChangeAdress()
        {
            Browser.Address = AddressBar.Text;
        }
        private void UpdateAddressBar()
        {
            AddressBar.Text = Browser.Address;
        }

        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ChangeAdress();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Browser.AddressChanged += Browser_AddressChanged;
            UpdateAddressBar();
        }

    }
}
