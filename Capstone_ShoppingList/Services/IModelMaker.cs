using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone_ShoppingList.Context;
using Capstone_ShoppingList.Models;

namespace Capstone_ShoppingList.Services
{
    public interface IModelMaker
    {
        public Models.CheckoutModel MakeModel(CapstoneShoppingListDBContext c);
    }
}
