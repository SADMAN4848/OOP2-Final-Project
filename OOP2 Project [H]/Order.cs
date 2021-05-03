using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Project__H_
{
    class Order
    {
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }
        public string OrderTime { get; set; }
        public string Food1Name { get; set; }
        public int Food1Price { get; set; }
        public string Food2Name { get; set; }
        public int Food2Price { get; set; }
        public string Food3Name { get; set; }
        public int Food3Price { get; set; }
        public string TotalCost { get; set; }
        public string PaymentStatus { get; set; }
    }
}
