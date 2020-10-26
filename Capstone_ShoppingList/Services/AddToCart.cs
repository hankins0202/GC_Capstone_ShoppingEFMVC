using Capstone_ShoppingList.Context;
using Capstone_ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_ShoppingList.Services
{
    public class AddToCart : IAddsToCart
    {
        ProductList IAddsToCart.AddToCart(CapstoneShoppingListDBContext context, int id)
        {
            var _context = context;
            var Id = id;
            var product = _context.ProductList.FirstOrDefault(_ => _.Id == Id);
            var shoppingListDetails = new ShoppingListDetails();

            shoppingListDetails.ProductId = product.Id;
            shoppingListDetails.Quantity = 1;
            shoppingListDetails.Price = product.Price * shoppingListDetails.Quantity;
            shoppingListDetails.Product = product;

            _context.ShoppingListDetails.Add(shoppingListDetails);
            _context.SaveChanges();
            return product;
        }

    }
}