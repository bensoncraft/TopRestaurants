using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class Restaurant
    {

        public Restaurant(int iRank)
        {
            Rank = iRank;
        }

        public int? Rank { get; }
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; } = "It’s all tasty!";
        public string Address { get; set; }
        public string RestaurantPhone { get; set; }
        public string Website { get; set; } = "Coming soon.";



        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Spicy Thai",
                FavoriteDish = "Pad Thai",
                Address = "3230 North University Ave, Provo, UT 84604",
                RestaurantPhone = "(801) 370-0707",
  
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Zupas",
                Address = "3230 North University Ave, Provo, UT 84604",
                RestaurantPhone = "(801) 370-0707",
                Website = ""
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Cafe Rio",
                FavoriteDish = "Chicken Salad",
                Address = "3230 North University Ave, Provo, UT 84604",
                RestaurantPhone = "(801) 370-0707",
                Website = "https://www.caferio.com/"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Five Guys",
                FavoriteDish = "Burger",
                Address = "3230 North University Ave, Provo, UT 84604",
                RestaurantPhone = "(801) 370-0707",
                Website = ""
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Olive Garden",
                Address = "3230 North University Ave, Provo, UT 84604",
                RestaurantPhone = "(801) 370-0707",
                Website = ""
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
