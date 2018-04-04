using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using retrospective_meeting.Models;

namespace retrospective_meeting.Controllers
{
    public class HomeController : Controller
    {
        public IMongoDatabase Database;
        public HomeController()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            Database = client.GetDatabase("retrospective");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return Json(Database.ListCollections());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
