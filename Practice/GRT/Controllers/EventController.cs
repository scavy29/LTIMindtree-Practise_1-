using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GRT.Models;

namespace GRT.Controllers
{
    public class EventController : Controller
    {
        private AppDbContext db;
        public EventController(AppDbContext context)
        {
            this.db=context;
        }
 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AvailableEventSpaces()
        {
            var list=db.EventSpaces;
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}