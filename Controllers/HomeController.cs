using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopRestaurants.Models;

namespace TopRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add($"#{r.Rank}: {r.RestaurantName} / Address: {r.Address} / Phone: {r.RestaurantPhone} / Favorite Dish: {r.FavoriteDish} / Website: {r.Website}");
            }

            return View(restaurantList);
        }

        [HttpPost]
        public IActionResult SubmitSuggestion(SuggestionResponse sugResponse)
        {
            TempStorage.AddRestaurant(sugResponse);
            return View();
        }

        public IActionResult RestaurantList()
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
