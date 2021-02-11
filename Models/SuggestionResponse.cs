using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TopRestaurants.Models
{
    public class SuggestionResponse
    {
        public string Name { get; set; }

        public string RestaurantName { get; set; }

        public string FavoriteDish { get; set; }

        public string RestaurantPhone { get; set; }
    }
}
