namespace SabagkitMidtermApp.Data;

using SabagkitMidtermApp.Models;

public static class TournamentSeedData
{
    public static List<TournamentEvent> GetTournaments()
    {
        return new List<TournamentEvent>
        {
            new TournamentEvent
            {
                Id = 1,
                Title = "2026 Opendoor Pickleball World Championships",
                Subtitle = "Opendoor WORLD CHAMPIONSHIPS",
                Location = "Farmers Branch, TX, USA",
                Country = "USA",
                DateRange = "Nov 2, 2026 - Nov 8, 2026",
                Currency = "AUD",
                Fee = 1897.00m,
                PlayerCount = 0,
                IsClosingSoon = false,
                ThemeGradient = "from-blue-50 to-indigo-100",
                GraphicType = "world-champ",
                Divisions = new List<EventDivision>
                {
                    new EventDivision { Id = 101, Name = "Men's Singles Open (5.0+)", Fee = 1897.00m, IsDoubles = false },
                    new EventDivision { Id = 102, Name = "Women's Singles Open (5.0+)", Fee = 1897.00m, IsDoubles = false },
                    new EventDivision { Id = 103, Name = "Men's Doubles Open (5.0+)", Fee = 2100.00m, IsDoubles = true },
                    new EventDivision { Id = 104, Name = "Mixed Doubles Open (5.0+)", Fee = 2100.00m, IsDoubles = true },
                    new EventDivision { Id = 105, Name = "Masters 50+ Skill Level (3.5 - 4.5)", Fee = 1250.00m, IsDoubles = true }
                }
            },
            new TournamentEvent
            {
                Id = 2,
                Title = "IMPROVE YOUR PICKLEBALL while...",
                Subtitle = "Australia's Only Adult Pickleball Camp",
                Location = "Lovedale, NSW, AUS",
                Country = "AUS",
                DateRange = "Oct 23, 2026 - Oct 25, 2026",
                Currency = "AUD",
                Fee = 1897.00m,
                PlayerCount = 12,
                IsClosingSoon = false,
                ThemeGradient = "from-emerald-900 to-green-950",
                GraphicType = "adult-camp",
                Divisions = new List<EventDivision>
                {
                    new EventDivision { Id = 201, Name = "3-Day Intensive Boot Camp (All Skills)", Fee = 1897.00m, IsDoubles = false },
                    new EventDivision { Id = 202, Name = "Master Strategy & Dinking Workshop", Fee = 950.00m, IsDoubles = false }
                }
            },
            new TournamentEvent
            {
                Id = 3,
                Title = "AUCKLAND, City of Sails Pickleball CLASSIC",
                Subtitle = "CITY OF SAILS CLASSIC 2026",
                Location = "Auckland, NZL",
                Country = "NZL",
                DateRange = "Oct 24, 2026 - Oct 25, 2026",
                Currency = "NZD",
                Fee = 60.00m,
                PlayerCount = 68,
                IsClosingSoon = false,
                ThemeGradient = "from-sky-100 to-blue-200",
                GraphicType = "auckland",
                Divisions = new List<EventDivision>
                {
                    new EventDivision { Id = 301, Name = "Men's Doubles 3.5 & Below", Fee = 60.00m, IsDoubles = true },
                    new EventDivision { Id = 302, Name = "Women's Doubles 3.5 & Below", Fee = 60.00m, IsDoubles = true },
                    new EventDivision { Id = 303, Name = "Mixed Doubles 4.0+", Fee = 60.00m, IsDoubles = true },
                    new EventDivision { Id = 304, Name = "Open Singles", Fee = 50.00m, IsDoubles = false }
                }
            },
            new TournamentEvent
            {
                Id = 4,
                Title = "House of Pickle - Serve and Rally Tournament",
                Subtitle = "HOUSE OF PICKLE INDOOR SLAM",
                Location = "Tauranga, NZL",
                Country = "NZL",
                DateRange = "Oct 25, 2026 - Oct 25, 2026",
                Currency = "NZD",
                Fee = 30.00m,
                PlayerCount = 74,
                IsClosingSoon = false,
                ThemeGradient = "from-amber-900 to-stone-900",
                GraphicType = "indoor-rally",
                Divisions = new List<EventDivision>
                {
                    new EventDivision { Id = 401, Name = "Mixed Doubles Round Robin", Fee = 30.00m, IsDoubles = true },
                    new EventDivision { Id = 402, Name = "Men's Doubles Express 3.5", Fee = 30.00m, IsDoubles = true },
                    new EventDivision { Id = 403, Name = "Women's Doubles Express 3.5", Fee = 30.00m, IsDoubles = true }
                }
            },
            new TournamentEvent
            {
                Id = 5,
                Title = "Open Singles Slam III",
                Subtitle = "OPEN SINGLES SLAM",
                Location = "Bayswater, Vic, AUS",
                Country = "AUS",
                DateRange = "Oct 26, 2026 - Oct 26, 2026",
                Currency = "AUD",
                Fee = 32.85m,
                PlayerCount = 27,
                IsClosingSoon = true,
                ThemeGradient = "from-slate-900 to-indigo-950",
                GraphicType = "singles-slam",
                Divisions = new List<EventDivision>
                {
                    new EventDivision { Id = 501, Name = "Men's Open Singles (All Ages)", Fee = 32.85m, IsDoubles = false },
                    new EventDivision { Id = 502, Name = "Women's Open Singles", Fee = 32.85m, IsDoubles = false },
                    new EventDivision { Id = 503, Name = "Junior Singles (U18)", Fee = 20.00m, IsDoubles = false }
                }
            },
            new TournamentEvent
            {
                Id = 6,
                Title = "PPA Asia 125 Skechers Nanjing Challenger 2026",
                Subtitle = "NANJING CHALLENGER 2026",
                Location = "Nanjing, CHN",
                Country = "CHN",
                DateRange = "Oct 28, 2026 - Oct 31, 2026",
                Currency = "USD",
                Fee = 40.00m,
                PlayerCount = 29,
                IsClosingSoon = true,
                ThemeGradient = "from-blue-950 via-indigo-900 to-slate-900",
                GraphicType = "nanjing-ppa",
                Divisions = new List<EventDivision>
                {
                    new EventDivision { Id = 601, Name = "PPA Challenger Men's Singles", Fee = 40.00m, IsDoubles = false },
                    new EventDivision { Id = 602, Name = "PPA Challenger Men's Doubles", Fee = 50.00m, IsDoubles = true },
                    new EventDivision { Id = 603, Name = "PPA Challenger Mixed Doubles", Fee = 50.00m, IsDoubles = true },
                    new EventDivision { Id = 604, Name = "PPA Challenger Women's Doubles", Fee = 50.00m, IsDoubles = true }
                }
            },
            new TournamentEvent
            {
                Id = 7,
                Title = "Manila Metro Pickleball Masters Cup 2026",
                Subtitle = "PHILIPPINES INVITATIONAL",
                Location = "Pasig City, Philippines",
                Country = "Philippines",
                DateRange = "Nov 14, 2026 - Nov 16, 2026",
                Currency = "PHP",
                Fee = 1500.00m,
                PlayerCount = 52,
                IsClosingSoon = false,
                ThemeGradient = "from-blue-800 to-teal-800",
                GraphicType = "manila-cup",
                Divisions = new List<EventDivision>
                {
                    new EventDivision { Id = 701, Name = "Men's Doubles Intermediate 3.5", Fee = 1500.00m, IsDoubles = true },
                    new EventDivision { Id = 702, Name = "Women's Doubles Intermediate 3.5", Fee = 1500.00m, IsDoubles = true },
                    new EventDivision { Id = 703, Name = "Mixed Doubles Open (4.0+)", Fee = 1800.00m, IsDoubles = true }
                }
            },
            new TournamentEvent
            {
                Id = 8,
                Title = "California Coastal Classic & Senior Pro",
                Subtitle = "COASTAL CLASSIC 2026",
                Location = "Thousand Oaks, CA, USA",
                Country = "USA",
                DateRange = "Dec 04, 2026 - Dec 07, 2026",
                Currency = "USD",
                Fee = 65.00m,
                PlayerCount = 88,
                IsClosingSoon = false,
                ThemeGradient = "from-amber-600 to-orange-700",
                GraphicType = "california-classic",
                Divisions = new List<EventDivision>
                {
                    new EventDivision { Id = 801, Name = "Senior Pro 50+ Doubles", Fee = 90.00m, IsDoubles = true },
                    new EventDivision { Id = 802, Name = "Age 19+ Doubles 4.0", Fee = 65.00m, IsDoubles = true },
                    new EventDivision { Id = 803, Name = "Open Singles", Fee = 55.00m, IsDoubles = false }
                }
            }
        };
    }
}