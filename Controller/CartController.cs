using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using BoostOrderInterviewQuestion.View;
using BoostOrderInterviewQuestion.Model;
using System.Web.Script.Serialization;

namespace BoostOrderInterviewQuestion.Controller
{
    class CartController
    {
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

            var s = new JavaScriptSerializer();
            var blah = s.Deserialize<List<CartData>>(jsonString);

           Console.WriteLine(blah.Count);   
        }
    }
}
