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
                    Image = "HistoryCategory/ruinscathedraltartu.png",
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
                    Image = "HistoryCategory/churchstjohn.png",
                    Hours = "Mon: Closed\nJan–May: Tue–Sun 12:00–17:00\nJun–Aug: Tue–Sun 10:00–18:00\nSep–Dec: Tue–Sun 11:00–17:00",
                    Address = "Jaani tn 5, 51007 Tartu"
                },
                new Place
                {
                    Id = "musee-national-estonien",
                    Name = "Estonian National Museum (ERM)",
                    Category = "History",
                    ShortDescription = "Large modern museum dedicated to Estonia's history, culture, and traditions.",
                    FullDescription = "Interactive exhibitions cover Estonian history, minorities, and daily life in an impressive contemporary building.",
                    Image = "HistoryCategory/estoniannationalmuseum.png",
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
                    Image = "HistoryCategory/tartuobservatory.png",
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
                    Image = "HistoryCategory/kgbcellsmuseum.png",
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
                    Image = "HistoryCategory/tartuuniversityartmuseum.png",
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
                    Image = "HistoryCategory/papagoikeskus.png",
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
                    Image = "HistoryCategory/tartuartmuseum.png",
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
                    Image = "HistoryCategory/tartusportmuseum.png",
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
                    Image = "HistoryCategory/tartucitymuseum.png",
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
                    Image = "HistoryCategory/estonianliterarymuseum.png",
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
                    Image = "HistoryCategory/songfestivalmuseum.png",
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
                    Image = "HistoryCategory/nineteencenturytartucitizenmuseum.png",
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
                    Image = "HistoryCategory/estonianagriculturemuseum.png",
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
                    Image = "HistoryCategory/tartuautomuseum.png",
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
                    Image = "HistoryCategory/estoniannationalmuseumdefencecollege.png",
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
                    Image = "HistoryCategory/estonianavationmuseum.png",
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
                    Image = "HistoryCategory/oskarlutshousemuseum.png",
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
                    Image = "HistoryCategory/typaletterpresspaperartcenter.png",
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
                    Image = "HistoryCategory/baermuseum.png",
                    Hours = "Mon–Fri 10:00–17:00\nWeekends: Closed",
                    Address = "Veski tn 4, 51005 Tartu"
                },
                
                // Relaxation Category
                new Place
                {
                    Id = "toome-hill-park-toomemagi",
                    Name = "Toome Hill Park (Toomemägi)",
                    Category = "Relaxation",
                    ShortDescription = "Urban wooded hill park perfect for walks, reading, and city/river views.",
                    FullDescription = "Toome Hill Park (Toomemägi) combines nature, historic ruins, and scenic bridges on a hilltop. Open anytime for strolls, relaxation, and panoramic Tartu views.",
                    Image = "RelaxationCategory/toomehillpark.png",
                    Hours = "24h/24",
                    Address = "Lossi 15b, 51003 Tartu"
                },
                new Place
                {
                    Id = "aura-water-centre",
                    Name = "Aura Water Centre",
                    Category = "Relaxation",
                    ShortDescription = "Aquatic center with pools, slides, saunas, and family/sports facilities.",
                    FullDescription = "Aura Water Centre is popular for relaxation, swimming, and indoor leisure with pools, toboggans, saunas, and wellness areas for families and athletes.",
                    Image = "RelaxationCategory/aquawatercentre.png",
                    Hours = "Mon-Thu: 12:00pm-10:00pm\nFri-Sun: 10:00am-10:00pm",
                    Address = "Turu tn 10, 51004 Tartu"
                },
                new Place
                {
                    Id = "v-spa-conference-hotel",
                    Name = "V Spa & Conference Hotel",
                    Category = "Relaxation",
                    ShortDescription = "Modern spa in Kvartal mall with saunas, pools, treatments, and massages.",
                    FullDescription = "V Spa & Conference Hotel offers numerous saunas, pools, spa care, and massages—ideal for wellness breaks after city sightseeing.",
                    Image = "RelaxationCategory/vspaconferencehotel.png",
                    Hours = "Mon-Sun: 9:00am-9:00pm",
                    Address = "Riia tn 2, 51004 Tartu"
                },
                new Place
                {
                    Id = "botanical-garden-outdoor-area",
                    Name = "Botanical Garden – Outdoor Area",
                    Category = "Relaxation",
                    ShortDescription = "Outdoor botanical garden area for calm walks and flora observation.",
                    FullDescription = "The outdoor zone of Tartu Botanical Garden provides a serene setting for strolling, plant viewing, and relaxing amid greenery.",
                    Image = "RelaxationCategory/botanicalgardenoutdoorarea.png",
                    Hours = "Mon-Sun: 7:00am-9:00pm",
                    Address = "Lai tn 38, 51005 Tartu"
                },
                new Place
                {
                    Id = "emajogi-river-banks",
                    Name = "Emajõgi River Banks",
                    Category = "Relaxation",
                    ShortDescription = "Riverside promenade with benches, paths, and seasonal tourist cruises.",
                    FullDescription = "Emajõgi River Banks feature landscaped walkways for jogging, sunset strolls, picnics, and occasional tourist boat cruises.",
                    Image = "RelaxationCategory/emajogiriverbanks.png",
                    Hours = "Always open",
                    Address = "Along Emajõgi River, Tartu"
                },
                new Place
                {
                    Id = "massaz-massage-lomi-lomi-kahuna",
                    Name = "Massaaz Massage Lomi Lomi KaHuna",
                    Category = "Relaxation",
                    ShortDescription = "Studio specializing in Hawaiian Lomi Lomi KaHuna massage for deep healing.",
                    FullDescription = "Massaaž Massage Lomi Lomi KaHuna (Studio Pure Wellness) offers fluid 1-2h Hawaiian massages using forearms, oils, and rhythmic moves to release physical/emotional blockages, boost circulation, flexibility, and harmony in ALOHA spirit.",
                    Image = "RelaxationCategory/massazlomicomikahuna.png",
                    Hours = "By appointment",
                    Address = "Nõmme t1, 50303 Tartu"
                },
                new Place
                {
                    Id = "raamatupood-biblioteek",
                    Name = "Raamatupood Biblioteek",
                    Category = "Relaxation",
                    ShortDescription = "Cozy independent bookstore in former Aparaaditehas factory.",
                    FullDescription = "Raamatupood Biblioteek, opened in 2021 via crowdfunding (180+ backers), offers curated new/used books (Estonian lit, essays, comics, imports), Chado tea, coffee, wine, and events like reading clubs.",
                    Image = "RelaxationCategory/raamatupoodbiblioteek.png",
                    Hours = "Mon-Fri: 10:00am-6:00pm\nSat: 11:00am-4:00pm\nSun: Closed",
                    Address = "Kastani tn 42, 50410 Tartu"
                },
                
                // Entertainment Category
                new Place
                {
                    Id = "ahhaa-science-centre",
                    Name = "AHHAA Science Centre",
                    Category = "Entertainment",
                    ShortDescription = "Large interactive science center with hands-on experiments, exhibits, shows, and planetarium.",
                    FullDescription = "AHHAA Science Centre offers practical experiments, interactive exhibits, shows, and a planetarium suitable for kids and adults alike, with plenty of fun educational activities.",
                    Image = "EntertainmentCategory/ahhaasciencecentre.png",
                    Hours = "Mon-Thu: 10:00am-7:00pm\nFri-Sat: 10:00am-8:00pm\nSun: 10:00am-7:00pm",
                    Address = "Sadama 1, 51004 Tartu"
                },
                new Place
                {
                    Id = "vanemuine-theater",
                    Name = "Vanemuine Theater",
                    Category = "Entertainment",
                    ShortDescription = "Tartu's main theater for operas, ballets, plays, and musicals.",
                    FullDescription = "Vanemuine Theater, Tartu's principal venue, features operas, ballets, plays, and musicals. Some shows have English surtitles; tickets available online or on-site.",
                    Image = "EntertainmentCategory/vanemuinetheater.png",
                    Hours = "Mon-Sat: 10:00am-7:00pm",
                    Address = "Vanemuise tn 6, 51003 Tartu"
                },
                new Place
                {
                    Id = "tartu-toy-museum",
                    Name = "Tartu Toy Museum",
                    Category = "Entertainment",
                    ShortDescription = "Fun museum showcasing Estonian and international toys with play areas for kids.",
                    FullDescription = "Tartu Toy Museum displays Estonian and global toys, plus kids' play zones, exhibits, workshops, and regular animations—ideal for families.",
                    Image = "EntertainmentCategory/tartutoymuseum.png",
                    Hours = "Mon-Tue: Closed\nWed-Sun: 11:00am-6:00pm",
                    Address = "Lutsu tn 8, 51005 Tartu"
                },
                new Place
                {
                    Id = "a-le-coq-beer-museum",
                    Name = "A. Le Coq Beer Museum",
                    Category = "Entertainment",
                    ShortDescription = "Museum tracing A. Le Coq brewery and Estonian beer history.",
                    FullDescription = "A. Le Coq Beer Museum explores the brewery's history and Estonia's beer heritage. Guided tours often end with adult tastings.",
                    Image = "EntertainmentCategory/alecoqbeermuseum.png",
                    Hours = "Mon: Closed\nTue-Fri: 11:00am-6:00pm\nSat: 11:00am-5:00pm\nSun: Closed",
                    Address = "Laulupeo pst 15, 51007 Tartu"
                },
                new Place
                {
                    Id = "ice-age-centre",
                    Name = "Ice Age Centre",
                    Category = "Entertainment",
                    ShortDescription = "Themed center near Tartu on Ice Age, prehistoric animals, and climate.",
                    FullDescription = "Ice Age Centre features interactive exhibits and models on the Ice Age, prehistoric fauna, and climate—great for families.",
                    Image = "EntertainmentCategory/iceagecentre.png",
                    Hours = "Mon: Closed\nTue-Sun: 10:00am-5:00pm",
                    Address = "Saadjärve tn 20, Äksi, 60543 Tartu maakond"
                },
                new Place
                {
                    Id = "devil-bridge-kuradisild",
                    Name = "Devil's Bridge (Kuradisild)",
                    Category = "Entertainment",
                    ShortDescription = "Stone bridge with local legends on Toome Hill.",
                    FullDescription = "Devil's Bridge (Kuradisild) is a historic stone bridge tied to local legends, ideal for walks and photos, especially evenings on Toome Hill.",
                    Image = "EntertainmentCategory/devilbridge.png",
                    Hours = "Always open",
                    Address = "Lossi 36a, 51003 Tartu"
                },
                new Place
                {
                    Id = "tartu-lumepark",
                    Name = "Tartu Lumepark",
                    Category = "Entertainment",
                    ShortDescription = "Family winter attraction park with snow tubing and ski/snowboard.",
                    FullDescription = "Tartu Lumepark offers family snow activities like tubing slides (tuubiradas) and ski/snowboard in a dedicated winter fun zone.",
                    Image = "EntertainmentCategory/tartulumepark.png",
                    Hours = "Mon: Closed\nTue-Fri: 12:00pm-8:00pm\nSat: 10:00am-8:00pm\nSun: 10:00am-6:00pm",
                    Address = "Muuseumi tee 5, 60534 Tartu"
                },
                new Place
                {
                    Id = "escape-tartu",
                    Name = "Escape Tartu",
                    Category = "Entertainment",
                    ShortDescription = "Dynamic escape room center with immersive team adventures.",
                    FullDescription = "Escape Tartu features themed escape games (prison, zombie virus, time travel) with puzzles and effects, plus lasertag for groups—perfect for team-building.",
                    Image = "EntertainmentCategory/escapetartu.png",
                    Hours = "Mon-Fri: 10:00am-10:00pm\nSat: 9:00am-10:00pm\nSun: 10:00am-10:00pm",
                    Address = "Tiigi tn 78, 50410 Tartu"
                },
                new Place
                {
                    Id = "tartu-adventure-park",
                    Name = "Tartu Adventure Park Ltd.",
                    Category = "Entertainment",
                    ShortDescription = "Dynamic treetop adventure park with 50+ aerial challenges.",
                    FullDescription = "Tartu Adventure Park offers 4 progressive courses (kids to expert) with bridges, nets, ziplines up to 300m, plus kids' zone—great for families and teams.",
                    Image = "EntertainmentCategory/tartuadventurepark.png",
                    Hours = "Mon-Fri: Closed\nSat-Sun: 11:00am-7:00pm",
                    Address = "Narva mnt 126b, 50303 Tartu"
                },
                new Place
                {
                    Id = "bowlex-ltd",
                    Name = "Bowlex Ltd.",
                    Category = "Entertainment",
                    ShortDescription = "Largest bowling in South Estonia with 10 modern lanes.",
                    FullDescription = "Bowlex Ltd. (FunBowling) features 10 AMF lanes with touchscreens, bumpers for kids, billiards, bar, and neon light shows for fun evenings.",
                    Image = "EntertainmentCategory/bowlex.png",
                    Hours = "Mon-Tue: Closed\nWed-Thu: 2:00pm-11:00pm\nFri: 2:00pm-12:00am\nSat: 12:00pm-12:00am\nSun: 12:00pm-10:00pm",
                    Address = "Võru tn 55F, 50111 Tartu"
                },
                new Place
                {
                    Id = "lange-motokeskus",
                    Name = "Lange Motokeskus",
                    Category = "Entertainment",
                    ShortDescription = "Largest Nordic moto center near Tartu for extreme and family motorsports.",
                    FullDescription = "Lange Motokeskus, just 9km from Tartu, features a professional motocross track (winter closed), international-standard outdoor karting, and indoor hall with 16 silent electric Sodi RSX karts on a 300m track with live timing screens.",
                    Image = "EntertainmentCategory/langemotokeskus.png",
                    Hours = "Mon-Tue: Closed\nWed-Sun: 12:00pm-9:00pm",
                    Address = "Pärnavälja tee 1, Lange, 62115 Tartu maakond"
                },
                new Place
                {
                    Id = "lounakeskuse-seikluspark",
                    Name = "Lõunakeskuse Seikluspark",
                    Category = "Entertainment",
                    ShortDescription = "Indoor treetop adventure park above ice rink in largest southern Estonia mall.",
                    FullDescription = "Lõunakeskuse Seikluspark is the indoor version of Tartu Adventure Park in Lõunakeskus mall. Suspended over the ice rink, it has 3 progressive courses (33 elements total) with suspended bridges, nets, and a thrilling zipline across the rink.",
                    Image = "EntertainmentCategory/lounakeskuseseikluspark.png",
                    Hours = "Mon-Fri: 4:00pm-8:00pm\nSat: 12:00pm-8:00pm\nSun: 12:00pm-7:00pm",
                    Address = "Ringtee 75g, 51014 Tartu"
                },
                
                // Food places Category
                new Place
                {
                    Id = "cafe-werner",
                    Name = "Werner coffee",
                    Category = "Restaurants",
                    ShortDescription = "Historic café founded in 1890, famous for cakes, pastries, and student atmosphere.",
                    FullDescription = "Café Werner is a historic spot established in 1890, renowned for its delicious cakes, pastries, and lively student vibe in Tartu city center. It's popular all day for breakfast, coffee, or afternoon snacks in a cozy setting.",
                    Image = "FoodPlacesCategory/coffeewerner.png",
                    Hours = "Mon-Fri: 7:30am-9:30pm\nSat-Sun: 9am-9:30pm",
                    Address = "Ülikooli tn 11, 51003 Tartu"
                },
                new Place
                {
                    Id = "restaurant-aparaat",
                    Name = "Aparaat Restaurant",
                    Category = "Restaurants",
                    ShortDescription = "Modern cuisine in a former creative factory Aparaaditehas.",
                    FullDescription = "Restaurant Aparaat offers contemporary dishes in an industrial setting within the old Aparaaditehas creative factory. Its trendy decor and innovative plates make it a top spot in Tartu.",
                    Image = "FoodPlacesCategory/restaurantaparaat.png",
                    Hours = "Mon-Thu: 12pm-11pm\nFri-Sat: 12pm-12am\nSun: 12pm-6pm",
                    Address = "Kastani tn 42, 50410 Tartu"
                },
                new Place
                {
                    Id = "la-dolce-vita",
                    Name = "La Dolce Vita",
                    Category = "Restaurants",
                    ShortDescription = "Popular Italian spot specializing in pizzas and pastas.",
                    FullDescription = "La Dolce Vita is a bustling Italian restaurant known for authentic pizzas and pastas. It's often full on weekends, so reservations are advised for this Tartu favorite.",
                    Image = "FoodPlacesCategory/ladolcevita.png",
                    Hours = "Mon-Thu: 11:30am-11pm\nFri-Sat: 11:30am-12am\nSun: 12pm-11pm",
                    Address = "Kompanii tn 10, 51007 Tartu"
                },
                new Place
                {
                    Id = "zone-aparaaditehas",
                    Name = "Zone Aparaaditehas",
                    Category = "Restaurants",
                    ShortDescription = "Former factory turned creative hub with restaurants, cafés, and bars.",
                    FullDescription = "Zone Aparaaditehas is a vibrant converted factory area featuring multiple restaurants, cafés, and bars. It's lively in the evenings, perfect for sampling various cuisines in one spot.",
                    Image = "FoodPlacesCategory/zoneaparaaditehas.png",
                    Hours = "Mon-Fri: 10am-6pm\nSat: 11am-4pm",
                    Address = "Kastani tn 42, 50410 Tartu"
                },
                new Place
                {
                    Id = "crepp",
                    Name = "CREPP",
                    Category = "Restaurants",
                    ShortDescription = "Cozy French café famous for large salads and sweet/savory crêpes.",
                    FullDescription = "CREPP is a comfortable French-style café in Tartu's old town, renowned for its generous salads and both sweet and savory crêpes in a welcoming atmosphere.",
                    Image = "FoodPlacesCategory/crepp.png",
                    Hours = "Mon-Thu: 11:30am-10pm\nFri: 11:30am-11pm\nSat: 11am-11pm\nSun: 11am-8pm",
                    Address = "Rüütli tn 16, 51007 Tartu"
                },
                new Place
                {
                    Id = "pierre",
                    Name = "PIERRE",
                    Category = "Restaurants",
                    ShortDescription = "Charming café-restaurant on town hall square with French-inspired dishes.",
                    FullDescription = "PIERRE is a delightful café-restaurant on Tartu's town hall square, serving French-inspired plates, chocolate cakes, and truffles in a warm Parisian ambiance.",
                    Image = "FoodPlacesCategory/pierre.png",
                    Hours = "Mon-Thu: 8am-9pm\nFri: 8am-11pm\nSat-Sun: 10am-11pm",
                    Address = "Raekoja plats 12, 51004 Tartu"
                },
                new Place
                {
                    Id = "gunpowder-cellar-püssirohukelder",
                    Name = "Gunpowder Cellar (Püssirohukelder)",
                    Category = "Restaurants",
                    ShortDescription = "Cozy pub in historic gunpowder cellar with hearty pub food.",
                    FullDescription = "Gunpowder Cellar (Püssirohukelder) is a warm restaurant and beer bar in a historic brick-vaulted gunpowder cellar, offering hearty pub cuisine.",
                    Image = "FoodPlacesCategory/gunpowdercellar.png",
                    Hours = "Mon-Tue: 12pm-10pm\nWed-Sat: 12pm-1am\nSun: 12pm-10pm",
                    Address = "Lossi 28, 51003 Tartu"
                },
                new Place
                {
                    Id = "hansa-tall-hoov",
                    Name = "Hansa Tall & Hansa Hoov",
                    Category = "Restaurants",
                    ShortDescription = "Iconic gastronomic complex in historic 1870s building.",
                    FullDescription = "Hansa Tall & Hansa Hoov is an emblematic culinary and event complex in a renovated 1870s building. Hansa Tall offers rustic Hanseatic Estonian dishes; Hansa Hoov features lively courtyard events.",
                    Image = "FoodPlacesCategory/hansatall.png",
                    Hours = "Mon: 12pm-9pm\nTue-Thu: 8am-9pm\nFri-Sat: 8am-11pm\nSun: 8am-7pm",
                    Address = "Turu tn 27a, 50106 Tartu"
                },
                new Place
                {
                    Id = "restaurant-munchen-weihenstephaner-wirtshaus",
                    Name = "Restaurant München - Weihenstephaner Wirtshaus",
                    Category = "Restaurants",
                    ShortDescription = "Authentic Bavarian restaurant with German classics and Weihenstephaner beers.",
                    FullDescription = "Restaurant München - Weihenstephaner Wirtshaus serves traditional German dishes like schnitzels, sausages, and goulash with Weihenstephaner beers in a cozy setting near Tartu University.",
                    Image = "FoodPlacesCategory/munchenweihenstephanerwirtshaus.png",
                    Hours = "Mon-Thu: 12pm-11pm\nFri-Sat: 12pm-12am\nSun: 12pm-9pm",
                    Address = "Küütri tn 2, 51007 Tartu"
                },
                new Place
                {
                    Id = "chez-andre",
                    Name = "Chez Andre",
                    Category = "Restaurants",
                    ShortDescription = "Elegant gourmet spot blending European classics and international influences.",
                    FullDescription = "Chez André is an upscale restaurant in central Tartu offering innovative European dishes like brisket, popcorn chicken salads, and pork belly in a refined, cozy ambiance.",
                    Image = "FoodPlacesCategory/chezandre.png",
                    Hours = "Mon-Thu: 12pm-11pm\nFri-Sat: 12pm-12am\nSun: 3pm-9pm",
                    Address = "Küütri tn 3, 51007 Tartu"
                }
            };
        }
    }
}