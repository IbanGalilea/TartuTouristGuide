using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TartuTouristGuide.Models;

namespace TartuTouristGuide.Data
{
    public static class PlacesData
    {
        public static List<Place> GetPlaces()
        {
            return new List<Place>
            {
                // History Category
                new Place
                {
                    Id = "hotel-de-ville",
                    Name = "Tartu Town Hall",
                    Category = "History",
                    ShortDescription = "Iconic 18th-century Place in the heart of the main square.",
                    FullDescription = "Tartu Town Hall, built between 1782 and 1789, is a magnificent example of classical architecture. Located on Town Hall Square, this pink Place has become the symbol of the city. It now houses reception halls and the Citizens' Museum. The tower offers a panoramic view over Tartu.",
                    Image = "https://images.unsplash.com/photo-1563273026-d342cef8f723?w=1080",
                    Hours = "Mon-Sat: 10am-6pm",
                    Address = "Raekoja plats, 50089 Tartu"
                },
                new Place
                {
                    Id = "universite-tartu",
                    Name = "University of Tartu",
                    Category = "History",
                    ShortDescription = "One of the oldest universities in Northern Europe, founded in 1632.",
                    FullDescription = "The University of Tartu is a prestigious institution founded by King Gustavus Adolphus of Sweden. The main Place, with its neoclassical columns, is an architectural masterpiece. The university has trained many Estonian scientists and thinkers. The university museum traces its fascinating history.",
                    Image = "https://images.unsplash.com/photo-1719667947943-ecd1c154f0c2?w=1080",
                    Hours = "Mon-Fri: 9am-5pm",
                    Address = "Ülikooli 18, 50090 Tartu"
                },
                new Place
                {
                    Id = "cathedrale-tartu",
                    Name = "Tartu Cathedral",
                    Category = "History",
                    ShortDescription = "Impressive medieval ruins on Toomemägi Hill.",
                    FullDescription = "Tartu Cathedral, built in the 13th century, is one of the most important medieval monuments in Estonia. Although partially in ruins, it now houses the University History Museum. The restored towers offer a spectacular view of the city. Visitors can admire the Gothic architecture and discover Tartu's history through the centuries.",
                    Image = "https://images.unsplash.com/photo-1576424784533-855d56cb3c44?w=1080",
                    Hours = "Tue-Sun: 11am-5pm",
                    Address = "Lossi 25, 50090 Tartu"
                },
                
                // Relaxation Category
                new Place
                {
                    Id = "jardin-botanique",
                    Name = "Tartu Botanical Garden",
                    Category = "Relaxation",
                    ShortDescription = "Green oasis with over 6,500 plant species.",
                    FullDescription = "The University of Tartu Botanical Garden, founded in 1803, is a true haven of peace. It houses tropical greenhouses, an arboretum and thematic gardens. Visitors can stroll among plants from around the world, including rare and exotic species. It's the perfect place to relax and recharge in an exceptional natural setting.",
                    Image = "https://images.unsplash.com/photo-1661264047307-4d692250a7ac?w=1080",
                    Hours = "Daily: 10am-5pm",
                    Address = "Lai 38/40, 51005 Tartu"
                },
                new Place
                {
                    Id = "parc-toomemagi",
                    Name = "Toomemägi Park",
                    Category = "Relaxation",
                    ShortDescription = "Historic hill with shaded trails and monuments.",
                    FullDescription = "Toomemägi Park is Tartu's green lung, located on a historic hill in the heart of the city. This romantic park offers picturesque trails, historic monuments and panoramic views. It's the favorite spot for locals to walk, jog or simply enjoy nature. The park also features sculptures and artistic installations.",
                    Image = "https://images.unsplash.com/photo-1741004421389-6f225bf38c10?w=1080",
                    Hours = "Open 24/7",
                    Address = "Toomemägi, 50090 Tartu"
                },
                
                // Entertainment Category
                new Place
                {
                    Id = "musee-art",
                    Name = "Tartu Art Museum",
                    Category = "Entertainment",
                    ShortDescription = "Exceptional collection of Estonian and international art.",
                    FullDescription = "The Tartu Art Museum, located in the Leaning House on Town Hall Square, presents a rich collection of Estonian art from the 18th century to the present day. Temporary exhibitions showcase contemporary artists. The Place itself is an attraction, with its unique baroque architecture and characteristic tilt.",
                    Image = "https://images.unsplash.com/photo-1694376390682-8a5222d40fa9?w=1080",
                    Hours = "Wed-Sun: 11am-6pm",
                    Address = "Raekoja plats 18, 51004 Tartu"
                },
                new Place
                {
                    Id = "centre-science-ahhaa",
                    Name = "AHHAA Science Centre",
                    Category = "Entertainment",
                    ShortDescription = "Interactive science museum for the whole family.",
                    FullDescription = "AHHAA is the largest science center in the Baltic countries, offering more than 170 interactive exhibitions. Visitors of all ages can explore science through hands-on experiences, a modern planetarium and educational workshops. It's a must-visit destination for families and curious minds who want to learn while having fun.",
                    Image = "https://images.unsplash.com/photo-1614636401882-aa1a36704629?w=1080",
                    Hours = "Mon-Sun: 10am-7pm",
                    Address = "Sadama 1, 50051 Tartu"
                },
                
                // Food places Category
                new Place
                {
                    Id = "restaurant-hõlm",
                    Name = "Restaurant Hõlm",
                    Category = "Restaurants",
                    ShortDescription = "Modern Estonian cuisine with local products.",
                    FullDescription = "Hõlm offers an exceptional gastronomic experience with a menu based on seasonal Estonian ingredients. The chef highlights local culinary traditions with a contemporary touch. The warm atmosphere and attentive service make this restaurant a popular destination for gourmets. Reservation recommended.",
                    Image = "https://images.unsplash.com/photo-1758648207365-df458d3e83f4?w=1080",
                    Hours = "Tue-Sat: 12pm-10pm",
                    Address = "Rüütli 16, 51007 Tartu"
                },
                new Place
                {
                    Id = "cafe-werner",
                    Name = "Café Werner",
                    Category = "Restaurants",
                    ShortDescription = "Historic café in the heart of the main square.",
                    FullDescription = "Café Werner has been an institution in Tartu since 1898. This elegant café offers a selection of homemade pastries, quality coffees and light dishes. The interior preserves the charm of yesteryear with its chandeliers and antique furniture. It's the perfect place for a coffee break while admiring the animation of Town Hall Square.",
                    Image = "https://images.unsplash.com/photo-1769867967096-e31141e37d49?w=1080",
                    Hours = "Daily: 9am-9pm",
                    Address = "Ülikooli 11, 51003 Tartu"
                }
            };
        }
    }
}