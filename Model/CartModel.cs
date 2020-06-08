
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostOrderInterviewQuestion.Model
{
    public class CartModel
    {
        public string name { get; set; }
        public int id { get; set; }
        public string variations { get; set; }
    }
    public class CartData
    {
        public CartModel[] data { get; set; }
    }
}
