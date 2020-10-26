﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Capstone_ShoppingList.Models
{
    public partial class ShoppingListDetails
    {
        public ShoppingListDetails()
        {
            ShoppingList = new HashSet<ShoppingList>();
        }

        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        //public IEnumerable joinShoppingListDetails { get; set; }

        public virtual ProductList Product { get; set; }
        public virtual ICollection<ShoppingList> ShoppingList { get; set; }
    }
}
