using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlphaShoeStore.Models;
using Microsoft.EntityFrameworkCore;

namespace AlphaShoeStore.Controllers
{
    public class StoreController : Controller
    {
        StoreContext storeDb = new StoreContext();
        public IActionResult Index()
        {
            var categories = storeDb.Category.ToList();
            return View(categories);
        }

        public ActionResult Details(int id)
        {
            var item = new Item { Name = "Item " + id };
            return View(item);
        }

        public ActionResult Browse(string category)
        {
            var cat = storeDb.Category.Include("Item")
                .Single(c => c.CategoryName == category);
            return View(cat);
        }
    }
}