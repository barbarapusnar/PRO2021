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

namespace DruštvoWPF
{
    /// <summary>
    /// Interaction logic for Tiskanje.xaml
    /// </summary>
    public partial class Tiskanje : Window
    {
        public Tiskanje()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            IDocumentPaginatorSource idp = doc;
            bool? print = pd.ShowDialog();
            if (print == true)
                pd.PrintDocument(idp.DocumentPaginator, "");
        }
    }
}
