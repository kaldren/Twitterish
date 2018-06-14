using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twitterish.Models;
using Twitterish.Repositories.Interfaces;
using Twitterish.ViewModels;

namespace Twitterish.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITweetRepository _tweetRepo;

        public HomeController(ITweetRepository tweetRepo)
        {
            _tweetRepo = tweetRepo;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ShowAllTweets = _tweetRepo.GeAllTweets()
            };

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
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
