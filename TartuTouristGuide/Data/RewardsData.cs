using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    Id = "test-succes",
                    Name = "Test des Succès",
                    Description = "C'est un test des succès, pour tester si ça marche.",
                    Image = "Rewards/TestRewards.jpg",
                    RequiredPlaceIds = new List<string> { "ruines-cathedral-tartu", "eglise-saint-jean", "toome-hill-park-toomemagi" },
                    Category = "History"
                },
                new Reward
                {
                    Id = "historien-amateur",
                    Name = "Amateur Historian",
                    Description = "You've visited all the historic sites in Tartu! The history of this thousand-year-old city holds no secrets for you.",
                    Image = "https://images.unsplash.com/photo-1764874299025-d8b2251f307d?w=1080",
                    RequiredPlaceIds = new List<string> {
                        "ruines-cathedral-tartu",
                        "eglise-saint-jean",
                        "musee-national-estonien",
                        "observatoire-tartu",
                        "musee-chambres-kgb",
                        "musee-universite-tartu-arts",
                        "papagoi-keskus",
                        "musee-arts-tartu",
                        "musee-sport-tartu",
                        "tartu-linnamuuseum",
                        "estonian-literary-museum",
                        "laulupeomuuseum",
                        "19th-century-citizens-museum",
                        "musee-agriculture-estonie",
                        "tartu-automuuseum",
                        "museum-national-defence-college",
                        "estonian-aviation-museum",
                        "oskar-lutsu-majamuuseum",
                        "typa-letterpress-centre",
                        "baeri-muuseum"
                        },
                    Category = "History"
                },
                new Reward
                {
                    Id = "explorateur-zen",
                    Name = "Zen Explorer",
                    Description = "You've discovered all the relaxation spots in Tartu. Calm and serenity are now part of your journey.",
                    Image = "https://images.unsplash.com/photo-1667918140078-9db890beab86?w=1080",
                    RequiredPlaceIds = new List<string> {
                        "toome-hill-park-toomemagi",
                        "aura-water-centre",
                        "v-spa-conference-hotel",
                        "botanical-garden-outdoor-area",
                        "emajogi-river-banks",
                        "massaz-massage-lomi-lomi-kahuna",
                        "raamatupood-biblioteek"
                        },
                    Category = "Relaxation"
                },
                new Reward
                {
                    Id = "amateur-culture",
                    Name = "Culture Enthusiast",
                    Description = "You've explored all the cultural attractions! Tartu's art and science have amazed you.",
                    Image = "https://images.unsplash.com/photo-1764874299025-d8b2251f307d?w=1080",
                    RequiredPlaceIds = new List<string> {
                        "ahhaa-science-centre",
                        "vanemuine-theater",
                        "tartu-toy-museum",
                        "a-le-coq-beer-museum",
                        "ice-age-centre",
                        "devil-bridge-kuradisild",
                        "tartu-lumepark",
                        "escape-tartu",
                        "tartu-adventure-park",
                        "bowlex-ltd",
                        "lange-motokeskus",
                        "lounakeskuse-seikluspark"
                        },
                    Category = "Entertainment"
                },
                new Reward
                {
                    Id = "gourmet-tartu",
                    Name = "Tartu Gourmet",
                    Description = "You've tasted the culinary delights of Tartu! Estonian gastronomy holds no secrets for you.",
                    Image = "https://images.unsplash.com/photo-1689245780587-a9a6725718b1?w=1080",
                    RequiredPlaceIds = new List<string> {
                        "cafe-werner",
                        "restaurant-aparaat",
                        "la-dolce-vita",
                        "zone-aparaaditehas",
                        "crepp",
                        "pierre",
                        "gunpowder-cellar-püssirohukelder",
                        "hansa-tall-hoov",
                        "restaurant-munchen-weihenstephaner-wirtshaus",
                        "chez-andre"
                        },
                    Category = "Restaurants"
                },
                new Reward
                {
                    Id = "maitre-tartu",
                    Name = "Master of Tartu",
                    Description = "Congratulations! You've discovered all the iconic places in Tartu. You are now a true expert of this fascinating city!",
                    Image = "https://images.unsplash.com/photo-1764874299025-d8b2251f307d?w=1080",
                    RequiredPlaceIds = new List<string> {
                        "ruines-cathedral-tartu",
                        "eglise-saint-jean",
                        "musee-national-estonien",
                        "observatoire-tartu",
                        "musee-chambres-kgb",
                        "musee-universite-tartu-arts",
                        "papagoi-keskus",
                        "musee-arts-tartu",
                        "musee-sport-tartu",
                        "tartu-linnamuuseum",
                        "estonian-literary-museum",
                        "laulupeomuuseum",
                        "19th-century-citizens-museum",
                        "musee-agriculture-estonie",
                        "tartu-automuuseum",
                        "museum-national-defence-college",
                        "estonian-aviation-museum",
                        "oskar-lutsu-majamuuseum",
                        "typa-letterpress-centre",
                        "baeri-muuseum",
                        "toome-hill-park-toomemagi",
                        "aura-water-centre",
                        "v-spa-conference-hotel",
                        "botanical-garden-outdoor-area",
                        "emajogi-river-banks",
                        "massaz-massage-lomi-lomi-kahuna",
                        "raamatupood-biblioteek",
                        "ahhaa-science-centre",
                        "vanemuine-theater",
                        "tartu-toy-museum",
                        "a-le-coq-beer-museum",
                        "ice-age-centre",
                        "devil-bridge-kuradisild",
                        "tartu-lumepark",
                        "escape-tartu",
                        "tartu-adventure-park",
                        "bowlex-ltd",
                        "lange-motokeskus",
                        "lounakeskuse-seikluspark",
                        "cafe-werner",
                        "restaurant-aparaat",
                        "la-dolce-vita",
                        "zone-aparaaditehas",
                        "crepp",
                        "pierre",
                        "gunpowder-cellar-püssirohukelder",
                        "hansa-tall-hoov",
                        "restaurant-munchen-weihenstephaner-wirtshaus",
                        "chez-andre"
                        },
                    Category = "Complete"
                }
            };
        }
    }
}