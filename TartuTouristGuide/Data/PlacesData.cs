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
                    Id = "ruines-cathedral-tartu",
                    Name = "Ruins of Tartu Cathedral (Toomkirik)",
                    Category = "History",
                    ShortDescription = "Medieval cathedral ruins from the Middle Ages, located on Toome Hill.",
                    FullDescription = "The towers offer a panorama over Tartu and the whole ensemble is one of the city's most striking monuments.",
                    Image = "/images/ruinscathedraltartu.png",
                    Hours = "Mon: Closed\nMay–Sep: Tue–Sun 10:00–18:00\nOct–Apr: Wed–Sun 11:00–17:00",
                    Address = "Ülikooli 18, 50090 Tartu"
                },
                new Place
                {
                    Id = "eglise-saint-jean",
                    Name = "St. John's Church (Jaani kirik)",
                    Category = "History",
                    ShortDescription = "14th-century Gothic church famous for its hundreds of unique terracotta sculptures.",
                    FullDescription = "It has survived major fires and is a religious and architectural symbol of Tartu.",
                    Image = "/images/churchstjohn.png",
                    Hours = "Mon: Closed\nJan–May: Tue–Sun 12:00–17:00\nJun–Aug: Tue–Sun 10:00–18:00\nSep–Dec: Tue–Sun 11:00–17:00",
                    Address = "Jaani tn 5, 51007 Tartu"
                },
                new Place
                {
                    Id = "musee-national-estonien",
                    Name = "Estonian National Museum (ERM)",
                    Category = "History",
                    ShortDescription = "Large modern museum dedicated to Estonia's history, culture, and traditions.",
                    FullDescription = "Interactive exhibitions cover Estonian history, minorities, and daily life in an impressive contemporary building. Closed 2026: Jun 23-24, Dec 24-26, Dec 28 & 31, Jan 1 2027.",
                    Image = "/images/estoniannationalmuseum.png",
                    Hours = "Mon: Closed\nTue–Sun 10:00–18:00",
                    Address = "Muuseumi tee 2, 60532 Tartu"
                },
                new Place
                {
                    Id = "observatoire-tartu",
                    Name = "Tartu Observatory",
                    Category = "History",
                    ShortDescription = "Historic observatory linked to the University of Tartu, important for Northern European astronomy.",
                    FullDescription = "It features ancient instruments and the history of scientific research in Tartu.",
                    Image = "/images/tartuobservatory.png",
                    Hours = "Mon: Closed\nMay–Sep: Tue–Sun 10:00–18:00\nOct–Apr: Sat–Sun 11:00–17:00",
                    Address = "Observatooriumi tn 1, Tõravere, 61602 Tartu maakond"
                },
                new Place
                {
                    Id = "musee-chambres-kgb",
                    Name = "KGB Cells Museum",
                    Category = "History",
                    ShortDescription = "Former KGB cells and offices turned into a museum on Soviet repression.",
                    FullDescription = "Exhibitions trace arrests, interrogations, and life under the Soviet regime; recommended for adults.",
                    Image = "/images/kgbcellsmuseum.png",
                    Hours = "Mon & Sun: Closed\nTue–Sat 11:00–17:00",
                    Address = "Riia tn 15b, 51010 Tartu"
                },
                new Place
                {
                    Id = "musee-universite-tartu-arts",
                    Name = "University of Tartu Museum and University Art Museum",
                    Category = "History",
                    ShortDescription = "Museum tracing the university's history and scientific research in a historic building.",
                    FullDescription = "Features ancient instruments and exhibitions on education and science in Tartu.",
                    Image = "/images/tartuuniversityartmuseum.png",
                    Hours = "Mon–Tue: Closed\nWed–Sun 11:00–17:00",
                    Address = "Lossi 25, 51003 Tartu"
                },
                new Place
                {
                    Id = "papagoi-keskus",
                    Name = "Papagoi Keskus (Zoo)",
                    Category = "History",
                    ShortDescription = "Family center with ~1-hour guided experience by owners, free-flying parrots singing or mimicking sounds.",
                    FullDescription = "Joyful atmosphere ideal for educational visits or birthdays, with sociable animals seeking pets.",
                    Image = "/images/papagoikeskus.png",
                    Hours = "Mon–Sun 12:00–18:00 (by appointment)",
                    Address = "Tartu mnt 80, 61709 Tartu"
                },
                new Place
                {
                    Id = "musee-arts-tartu",
                    Name = "Tartu Art Museum",
                    Category = "History",
                    ShortDescription = "Main art museum in southern Estonia in Tartu's famous 'leaning house'.",
                    FullDescription = "Founded in 1940, houses ~23,000 Estonian and international works from 18th century to today, focusing on modern and contemporary art.",
                    Image = "/images/tartuartmuseum.png",
                    Hours = "Mon–Tue: Closed\nWed–Sun 11:00–18:00\nThu until 20:00",
                    Address = "Raekoja plats 18, 51004 Tartu"
                },
                new Place
                {
                    Id = "musee-sport-tartu",
                    Name = "Tartu Sports Museum",
                    Category = "History",
                    ShortDescription = "Estonian Sports and Olympism Museum, largest and modern sports museum in Baltics.",
                    FullDescription = "Founded 1963, modernized 2020; interactive immersion in Estonian sports history, Olympics, and scandals like doping.",
                    Image = "/images/tartusportmuseum.png",
                    Hours = "Sep1–Jun30: Wed–Sun 10:00–18:00\nJul1–Aug31: Mon–Sun 10:00–18:00",
                    Address = "Rüütli tn 15, 51007 Tartu"
                },
                new Place
                {
                    Id = "tartu-linnamuuseum",
                    Name = "Tartu City Museum",
                    Category = "History",
                    ShortDescription = "City museum dedicated to local history from Middle Ages to today.",
                    FullDescription = "Founded 1955 in elegant 18th-century manor; permanent 'Our Tartu' exhibition and temporary on culture, legends, daily life.",
                    Image = "/images/tartucitymuseum.png",
                    Hours = "Mon–Tue: Closed\nWed–Sun 11:00–18:00",
                    Address = "Narva mnt 23, 51009 Tartu"
                },
                new Place
                {
                    Id = "estonian-literary-museum",
                    Name = "Estonian Literary Museum",
                    Category = "History",
                    ShortDescription = "Research institute on Estonian cultural history, folklore, and literary archives.",
                    FullDescription = "Founded 1909, in historic building since 1924; holds manuscripts, photos, artifacts from 19th century, focus on literature, oral traditions, ethnography.",
                    Image = "/images/estonianliterarymuseum.png",
                    Hours = "Mon–Thu 09:00–17:00\nFri 09:00–16:30\nWeekends: Closed",
                    Address = "Vanemuise tn 42, 51003 Tartu"
                },
                new Place
                {
                    Id = "laulupeomuuseum",
                    Name = "Song Festival Museum (Laulupeomuuseum)",
                    Category = "History",
                    ShortDescription = "Museum dedicated to Estonian song festivals and Vanemuine national theater history.",
                    FullDescription = "In 19th-century classicist building; traces first 1869 festival and national awakening role, with interactive exhibits, VR, workshops.",
                    Image = "/images/songfestivalmuseum.png",
                    Hours = "Mon & Sun: Closed\nTue–Sat 11:00–18:00",
                    Address = "Jaama tn 14, 51009 Tartu"
                },
                new Place
                {
                    Id = "19th-century-citizens-museum",
                    Name = "19th Century Tartu Citizen's Museum",
                    Category = "History",
                    ShortDescription = "Recreates 1830s bourgeois daily life in 1740s wooden house, one of Tartu's oldest surviving.",
                    FullDescription = "Authentic Biedermeier interior with salon, dining room, office, bedroom, kitchen with period utensils and working English stove.",
                    Image = "/images/nineteencenturytartucitizenmuseum.png",
                    Hours = "Mon–Tue: Closed\nWed–Sun 11:00–18:00",
                    Address = "Jaani tn 16, 51007 Tartu"
                },
                new Place
                {
                    Id = "musee-agriculture-estonie",
                    Name = "Estonian Agriculture Museum",
                    Category = "History",
                    ShortDescription = "Open-air museum in Ülenurme manor, 10km south of Tartu (renamed MUHK in 2026).",
                    FullDescription = "Traces Estonian agriculture and rural life 18th–21st centuries; ancient tools, rare Soviet machines, livestock, interactive beekeeping.",
                    Image = "/imgages/estonianagriculturemuseum.png",
                    Hours = "Mon–Tue: Closed\nWed–Sun 10:00–15:00",
                    Address = "Pargi 4, Ülenurme, 61714 Tartu"
                },
                new Place
                {
                    Id = "tartu-automuuseum",
                    Name = "Tartu Automuseum",
                    Category = "History",
                    ShortDescription = "Small private car museum focused on Soviet-era USSR vehicles.",
                    FullDescription = "Restored period cars and motorcycles, civil and military; in industrial area (15min bus from center).",
                    Image = "/imgages/tartuautomuseum.png",
                    Hours = "No info available",
                    Address = "Teguri 28a, 51013 Tartu"
                },
                new Place
                {
                    Id = "museum-national-defence-college",
                    Name = "Museum of the Estonian National Defence College",
                    Category = "History",
                    ShortDescription = "Military museum on Estonian defense forces and Defense League history.",
                    FullDescription = "Founded 1994 as Defense League archives; displays weapons, medals, comms gear, ammo, pioneer equipment from 20th century Estonian army.",
                    Image = "/imgages/estoniannationalmuseumdefencecollege.png",
                    Hours = "Mon–Thu 10:00–17:00\nFri 10:00–15:00\nWeekends: Closed",
                    Address = "51010 Tartu"
                },
                new Place
                {
                    Id = "estonian-aviation-museum",
                    Name = "Estonian Aviation Museum",
                    Category = "History",
                    ShortDescription = "Estonia's only aviation museum, 16km from Tartu center in Lange.",
                    FullDescription = "Founded 2002 from private collection; 32 planes, 6 helicopters, anti-air weapons, 500+ models, on-site runway.",
                    Image = "/imgages/estonianavationmuseum.png",
                    Hours = "Apr25–May22 & Sep14–Oct25: 11:00–16:00\nMay23–Sep13: 10:00–18:00",
                    Address = "Langemäe, Kastre, Lange, 62115"
                },
                new Place
                {
                    Id = "oskar-lutsu-majamuuseum",
                    Name = "Oskar Luts House Museum",
                    Category = "History",
                    ShortDescription = "House-museum of Estonian writer Oskar Luts (1887-1953), author of Kevade (Spring).",
                    FullDescription = "Built 1936; functionalist house where Luts lived last 17 years; preserves work room and guest room; branch of Tartu City Museum since 1964.",
                    Image = "/imgages/oskarlutshousemuseum.png",
                    Hours = "Mon–Tue & Sun: Closed\nWed–Sat 11:00–17:00",
                    Address = "Riia tn 38, 50405 Tartu"
                },
                new Place
                {
                    Id = "typa-letterpress-centre",
                    Name = "TYPA Letterpress and Paper Art Centre",
                    Category = "History",
                    ShortDescription = "Unique center dedicated to letterpress printing and paper art in former shoe factory.",
                    FullDescription = "Founded 2010 to save Baltic movable type presses; interactive workshops, exhibits on 19th–20th century printing history.",
                    Image = "/imgages/typaletterpresspaperartcenter.png",
                    Hours = "Mon–Tue: Closed\nWed–Sun 12:00–18:00",
                    Address = "Kastani tn 48f, 50410 Tartu"
                },
                new Place
                {
                    Id = "baeri-muuseum",
                    Name = "Baer Museum",
                    Category = "History",
                    ShortDescription = "House-museum of Karl Ernst von Baer (1792-1876), Estonian-German naturalist, embryology pioneer.",
                    FullDescription = "In 1864 classicist wooden house on Toomemägi slope; restored 1976; now science history research center linked to Estonian University of Life Sciences.",
                    Image = "/imgages/baermuseum.png",
                    Hours = "Mon–Fri 10:00–17:00\nWeekends: Closed",
                    Address = "Veski tn 4, 51005 Tartu"
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