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

namespace NepovezanDostop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NepovezanDostop.adwDataSet adwDataSet;
        adwDataSetTableAdapters.ProductTableAdapter ta;
        CollectionViewSource productViewSource;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            adwDataSet = ((NepovezanDostop.adwDataSet)(this.FindResource("adwDataSet")));
            // Load data into the table Product. You can modify this code as needed.
            ta 
                = new adwDataSetTableAdapters.ProductTableAdapter();
            ta.Fill(adwDataSet.Product);
            productViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
        }

        private void btnNaprej_Click(object sender, RoutedEventArgs e)
        {
            int dolžina = ((CollectionView)productViewSource.View).Count;
            int pozicija = productViewSource.View.CurrentPosition;
            if (pozicija<dolžina-1)
                productViewSource.View.MoveCurrentToNext(); //pojdi na naslednji zapis
        }

        private void btnNazaj_Click(object sender, RoutedEventArgs e)
        {
            int pozicija = productViewSource.View.CurrentPosition;
            if (pozicija >0)
                productViewSource.View.MoveCurrentToPrevious(); //pojdi na prejšnji zapis
        }

        private void btnShrani_Click(object sender, RoutedEventArgs e)
        {
            ta.Update(adwDataSet.Product);
        }
    }
}
