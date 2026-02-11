using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TartuTouristGuide.Models;
using TartuTouristGuide.Models;

namespace TartuTouristGuide.Data
{
    public static class RewardsData
    {
        public static List<Reward> GetRewards()
        {
            return new List<Reward>
            {
                new Reward
                {
                    Id = "historien-amateur",
                    Name = "Amateur Historian",
                    Description = "You've visited all the historic sites in Tartu! The history of this thousand-year-old city holds no secrets for you.",
                    Image = "https://images.unsplash.com/photo-1764874299025-d8b2251f307d?w=1080",
                    RequiredPlaceIds = new List<string> { "hotel-de-ville", "universite-tartu", "cathedrale-tartu" },
                    Category = "History"
                },
                new Reward
                {
                    Id = "explorateur-zen",
                    Name = "Zen Explorer",
                    Description = "You've discovered all the relaxation spots in Tartu. Calm and serenity are now part of your journey.",
                    Image = "https://images.unsplash.com/photo-1667918140078-9db890beab86?w=1080",
                    RequiredPlaceIds = new List<string> { "jardin-botanique", "parc-toomemagi" },
                    Category = "Relaxation"
                },
                new Reward
                {
                    Id = "amateur-culture",
                    Name = "Culture Enthusiast",
                    Description = "You've explored all the cultural attractions! Tartu's art and science have amazed you.",
                    Image = "https://images.unsplash.com/photo-1764874299025-d8b2251f307d?w=1080",
                    RequiredPlaceIds = new List<string> { "musee-art", "centre-science-ahhaa" },
                    Category = "Entertainment"
                },
                new Reward
                {
                    Id = "gourmet-tartu",
                    Name = "Tartu Gourmet",
                    Description = "You've tasted the culinary delights of Tartu! Estonian gastronomy holds no secrets for you.",
                    Image = "https://images.unsplash.com/photo-1689245780587-a9a6725718b1?w=1080",
                    RequiredPlaceIds = new List<string> { "restaurant-hõlm", "cafe-werner" },
                    Category = "Restaurants"
                },
                new Reward
                {
                    Id = "maitre-tartu",
                    Name = "Master of Tartu",
                    Description = "Congratulations! You've discovered all the iconic places in Tartu. You are now a true expert of this fascinating city!",
                    Image = "https://images.unsplash.com/photo-1764874299025-d8b2251f307d?w=1080",
                    RequiredPlaceIds = new List<string>
                    {
                        "hotel-de-ville", "universite-tartu", "cathedrale-tartu",
                        "jardin-botanique", "parc-toomemagi", "musee-art",
                        "centre-science-ahhaa", "restaurant-hõlm", "cafe-werner"
                    },
                    Category = "Complete"
                }
            };
        }
    }
}