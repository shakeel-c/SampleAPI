using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Models
{
    public class Customer
    {
        public int customerPk { get; set; }
        public string customerName { get; set; }
        public string contactNo { get; set; }

    }

    public class Product
    {
        public int productPk { get; set; }
        public string productName { get; set; }
        public float productRate { get; set; }

    }

    public class Order
    {
        public int orderPk { get; set; }
        public int customerPk { get; set; }
        public DateTime orderDate { get; set; }
        public float orderAmount { get; set; }

    }

    public class OrderDetails
    {
        public int orderDetailsPk { get; set; }
        public int productPk { get; set; }
        public int orderPk { get; set; }
        public float productQuantity { get; set; }

    }
}
