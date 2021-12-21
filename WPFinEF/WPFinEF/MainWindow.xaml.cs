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
using System.Data.Entity;

namespace WPFinEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        northwndEntities context = new northwndEntities();
        CollectionViewSource custViewSource;
        CollectionViewSource customerOrdersViewSource;
        public MainWindow()
        {
            InitializeComponent();
            custViewSource = (CollectionViewSource)(FindResource("customerViewSource"));
            customerOrdersViewSource = (CollectionViewSource)(FindResource("customerOrdersViewSource"));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var x = context.Customers.Select(a => a);
            //custViewSource.Source = x;
            context.Customers.Load();
            custViewSource.Source = context.Customers.Local;
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToFirst();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToPrevious();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToNext();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            custViewSource.View.MoveCurrentToLast();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            existingCustomerGrid.Visibility = Visibility.Collapsed;
            newCustomerGrid.Visibility = Visibility.Visible;
            ordersDataGrid.Visibility = Visibility.Collapsed;
            foreach (var otrok in newCustomerGrid.Children)
            {
                var tb = otrok as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (newCustomerGrid.IsVisible)
            {
                Customer c = new Customer
                {
                    Address = add_cityTextBox.Text,
                    City = add_cityTextBox.Text,
                    CompanyName = add_companyNameTextBox.Text,
                    CustomerID = add_customerIDTextBox.Text

                };
                int len = context.Customers.Local.Count();
                context.Customers.Local.Insert(len, c);
                custViewSource.View.Refresh();
                custViewSource.View.MoveCurrentTo(c);
                newCustomerGrid.Visibility = Visibility.Collapsed;
                existingCustomerGrid.Visibility = Visibility.Visible;
                ordersDataGrid.Visibility = Visibility.Visible;
            }
        }
    }
}
