using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone_ShoppingList.Context;

namespace Capstone_ShoppingList.Services
{
    public interface IDBSetup
    {
        public void createNew(CapstoneShoppingListDBContext context);
    }
}
