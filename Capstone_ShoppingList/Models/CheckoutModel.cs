
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone_ShoppingList.Models;

namespace Capstone_ShoppingList.Models
{
    public class CheckoutModel
    {
        public List<ProductList> Items { get; set; }
        public double Total { get; set; }
        public double Tax { get; set; }

        public double GrandTotal { get; set; }
    }
}
