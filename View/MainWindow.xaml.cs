using BoostOrderInterviewQuestion.View;
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

namespace BoostOrderInterviewQuestion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void deductQty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addQty_Click(object sender, RoutedEventArgs e)
        {
            var qtyTxt = this.qtyTxt.Text;
            int qty;
            Int32.TryParse(qtyTxt, out qty);
            int totalQty = qty = qty + 1;
            var qtyAmt = totalQty.ToString();
            MessageBox.Show(qtyAmt);
            qtyTxt = qtyAmt;
        }

        private void addToCartBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void viewCartBtn_Click(object sender, RoutedEventArgs e)
        {
            CartView cartView = new CartView();
            cartView.Show();
        }
    }
}
