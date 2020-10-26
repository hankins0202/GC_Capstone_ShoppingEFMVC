
using Capstone_ShoppingList.Context;
using Capstone_ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_ShoppingList.Services
{
    public interface IAddsToCart
    {
        public ProductList AddToCart(CapstoneShoppingListDBContext context, int id);
    }
}