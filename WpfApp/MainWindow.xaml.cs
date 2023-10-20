using Bussines;
using Entity;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            BInvoice bInvoice = new BInvoice();
            DateTime date = Convert.ToDateTime("2023-10-11 11:30:00.000");
            List<Invoice> invoices = bInvoice.GetByDate(date);
            InitializeComponent();
            dataGrid.ItemsSource = invoices;
        }
    }
}
