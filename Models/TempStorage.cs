using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class TempStorage
    {
        private static List<SuggestionResponse> restaurants = new List<SuggestionResponse>();

        public static IEnumerable<SuggestionResponse> Restaurants => restaurants;

        public static void AddRestaurant(SuggestionResponse restaurant)
        {
            restaurants.Add(restaurant);
        }

    }
}
