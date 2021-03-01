using Lab27_PoorMansReddit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27_PoorMansReddit.Controllers
{
    public class HomeController : Controller
        
    {
        private readonly ILogger<HomeController> _logger;
        private RedditDAL redditDAL = new RedditDAL();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(string subredditName)
        //{
        //    try
        //    {
        //        return RedirectToAction("ViewSubReddit", "Home", subredditName);
        //    }
        //    catch (Exception)
        //    {

        //        return RedirectToAction("ErrorSubReddit");
        //    }
            
        //}
        public IActionResult ErrorSubReddit()
        {
            return View();
        }

        public IActionResult ViewSubReddit(string subredditName)
        {
            try
            {
                SubReddit sub = redditDAL.ConvertToSubReddit(subredditName);
                return View(sub);
            }
            catch (Exception)
            {
                return RedirectToAction("ErrorSubReddit");

            } 
            
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
