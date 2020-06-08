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
using BoostOrderInterviewQuestion.Model;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

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
            start_get();
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

        public void start_get()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://mangomart-autocount.myboostorder.com/wp-json/wc/v1/products"));

            WebReq.Method = "GET";
            WebReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("ck_2682b35c4d9a8b6b6effac126ac552e0bfb315a0:cs_cab8c9a729dfb49c50ce801a9ea41b577c00ad71"));
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            var js = new JavaScriptSerializer();
            var json = js.Deserialize<List<CartData>>(jsonString);
            foreach (var cartItem in jsonString)
            {
                Console.Write(cartItem.ToString());
            }
            //var newjsonString = jsonString.Replace("[", "");
            //newjsonString = newjsonString.Replace("]", "");
            ////var jsonData = JObject.Parse(newjsonString);
            //Console.WriteLine(newjsonString);
            dynamic data = JObject.Parse(jsonString);
            data.name = this.qtyTxt.Text;
            ////Console.WriteLine(json.Count);

            //JavaScriptSerializer ser = new JavaScriptSerializer();
            //var personlist = ser.Deserialize<List<Person>>(Json);
            //return View(personlist);

        }

        protected void viewData()
        {
           
            string jsonData = @"{  
            'FirstName':'Jignesh',  
            'LastName':'Trivedi'  
            }";
            dynamic data = JObject.Parse(jsonData);

            Console.Write(string.Concat("Hi ", data.FirstName, " " + data.LastName));
            Console.ReadLine();
        }
    }
}
