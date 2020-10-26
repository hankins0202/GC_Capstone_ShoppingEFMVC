﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Capstone_ShoppingList.Models;
using Capstone_ShoppingList.Services;
using Capstone_ShoppingList.Context;

namespace Capstone_ShoppingList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDBSetup _DBSetup;
        private readonly CapstoneShoppingListDBContext _context;

        public HomeController(ILogger<HomeController> logger, IDBSetup setup, CapstoneShoppingListDBContext context)
        {
            _logger = logger;
            _DBSetup = setup;
            _context = context;
            _DBSetup.createNew(_context);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
