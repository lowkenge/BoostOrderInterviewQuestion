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
using BoostOrderInterviewQuestion.Controller;
using BoostOrderInterviewQuestion.Model;

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
            CartController controller = new CartController();
            controller.start_get();
            
        }

        private void deductQty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addQty_Click(object sender, RoutedEventArgs e)
        {
            CartModel model = new CartModel();
            var qtyTxt = this.qtyTxt.Text;
            qtyTxt = model.name;
            MessageBox.Show(model.name);
            //Int32.TryParse(qtyTxt, out qty);
            //int totalQty = qty = qty + 1;
            //var qtyAmt = totalQty.ToString();
            //MessageBox.Show(qtyAmt);
            //qtyTxt = qtyAmt;
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
