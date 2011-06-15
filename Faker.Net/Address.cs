using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Faker
{
    public static class Address
    {
        static Address()
        {
            CITY_PREFIXES = _CITY_PREFIXES.SelectMany(item => COMPASS_DIRECTIONS.Select(dir => dir + " " + item)).ToArray();
        }

        public static string ZipCode()
        {
            return ZIP_FORMATS.Rand().Numerify();
        }

        public static string USState()
        {
            return STATE.Rand();
        }

        public static string USStateAbbr()
        {
            return STATE_ABBR.Rand();
        }

        public static string CityPrefix()
        {
            return CITY_PREFIXES.Rand();
        }

        public static string CitySuffix()
        {
            return CITY_SUFFIXES.Rand();
        }

        public static string City()
        {
            var item = new Random().Next(4);
            switch (item)
            {
                case 0: return CityPrefix() + " " + Name.FirstName() + CitySuffix();
                case 1: return CityPrefix() + " " + Name.FirstName();
                case 2: return Name.FirstName() + CitySuffix();
                case 3: return Name.LastName() + CitySuffix();
                default: throw new ApplicationException();
            }
        }

        public static string StreetSuffix()
        {
            return STREET_SUFFIX.Rand();
        }

        public static string StreetName()
        {
            switch (new Random().Next(2))
            {
                case 0: return Name.LastName() + " " + StreetSuffix();
                case 1: return Name.FirstName() +" " + StreetSuffix();
                default: throw new ApplicationException();
            }
        }

        public static string StreetAddress(bool includeSecondary = false){
            var str = (new Random().Next(3).Times("#")) + ("### " + StreetName());
          if (includeSecondary)
              str += " " + SecondaryAddress();

          return str.Numerify();
        }

        public static string SecondaryAddress()
        {
            return SEC_ADDR.Rand().Numerify();
        }

        // UK Variants
        public static string UKCounty()
        {
            return UK_COUNTY.Rand();
        }

        public static string UKCountry()
        {
            return UK_COUNTRY.Rand();
        }

        public static string UKPostcode()
        {
            return UK_POSTCODE.Rand().Bothify().ToUpper();
        }

        public static string Neighborhood()
        {
            return NEIGHBORHOOD.Rand();
        }

        static readonly string[] ZIP_FORMATS = new[] { "#####", "#####-####" };

        static readonly string[] STATE = new[] {"Alabama", "Alaska", "Arizona", "Arkansas",
      "California", "Colorado", "Connecticut", "Delaware", "Florida",
      "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas",
      "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts",
      "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana",
      "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York",
      "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon",
      "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota",
      "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington",
      "West Virginia", "Wisconsin", "Wyoming" };

        static readonly string[] STATE_ABBR = new[] { "AL", "AK", "AS", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FM", "FL", "GA", "GU", "HI", "ID", "IL", "IN", "IA",
                     "KS", "KY", "LA", "ME", "MH", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC",
                     "ND", "MP", "OH", "OK", "OR", "PW", "PA", "PR", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VI", "VA", "WA", "WV",
                     "WI", "WY", "AE", "AA", "AP" };

        static readonly string[] COMPASS_DIRECTIONS = new[] { "North", "East", "West", "South" };
        static readonly string[] _CITY_PREFIXES = new[] { "New", "Lake", "Port" };
        static readonly string[] CITY_PREFIXES;

        static readonly string[] CITY_SUFFIXES = new[] {"town", "ton", "land", "ville", "berg", "burgh", "borough", "bury", "view", "port",
                        "mouth", "stad", "furt", "chester", "mouth", "fort", "haven", "side", "shire" };

        static readonly string[] STREET_SUFFIX = new[] {"Alley", "Avenue", "Branch", "Bridge", "Brook", "Brooks"
      ,"Burg", "Burgs", "Bypass", "Camp", "Canyon", "Cape", "Causeway", "Center", "Centers", "Circle", "Circles"
      ,"Cliff", "Cliffs", "Club", "Common", "Corner", "Corners", "Course", "Court", "Courts", "Cove", "Coves"
      ,"Creek", "Crescent", "Crest", "Crossing", "Crossroad", "Curve", "Dale", "Dam", "Divide", "Drive", "Drives"
      ,"Estate", "Estates", "Expressway", "Extension", "Extensions", "Fall", "Falls", "Ferry"
      ,"Field", "Fields", "Flat", "Flats", "Ford", "Fords", "Forest", "Forge", "Forges", "Fork", "Forks", "Fort"
      ,"Freeway", "Garden", "Gardens", "Gateway", "Glen", "Glens", "Green", "Greens", "Grove", "Groves", "Harbor"
      ,"Harbors", "Haven", "Heights", "Highway", "Hill", "Hills", "Hollow", "Inlet", "Island"
      ,"Islands", "Isle", "Junction", "Junctions", "Key", "Keys", "Knoll", "Knolls", "Lake"
      ,"Lakes", "Land", "Landing", "Lane", "Light", "Lights", "Loaf", "Lock", "Locks", "Lodge", "Loop"
      ,"Mall", "Manor", "Manors", "Meadow", "Meadows", "Mews", "Mill", "Mills", "Mission", "Motorway"
      ,"Mount", "Mountain", "Mountains", "Neck", "Orchard", "Oval", "Overpass", "Park"
      ,"Parks", "Parkway", "Parkways", "Pass", "Passage", "Path", "Pike", "Pine", "Pines", "Place", "Plain", "Plains"
      ,"Plaza", "Point", "Points", "Port", "Ports", "Prairie"
      ,"Radial", "Ramp", "Ranch", "Rapid", "Rapids", "Rest", "Ridge", "Ridges", "River", "Road", "Roads"
      ,"Route", "Row", "Rue", "Run", "Shoal", "Shoals", "Shore", "Shores", "Skyway", "Spring", "Springs"
      ,"Spur", "Spurs", "Square", "Squares", "Station", "Stravenue"
      ,"Stream", "Street", "Streets", "Summit", "Terrace"
      ,"Throughway", "Trace", "Track", "Trafficway", "Trail", "Tunnel"
      ,"Turnpike", "Underpass", "Union", "Unions", "Valley", "Valleys", "Via", "Viaduct", "View", "Views"
      ,"Village", "Villages", "Ville", "Vista", "Walk", "Walks", "Wall", "Way", "Ways", "Well", "Wells" };

        static readonly string[] SEC_ADDR = new[] { "Apt. ###", "Suite ###" };

        static readonly string[] UK_COUNTY = new[] {"Avon", "Bedfordshire", "Berkshire", "Borders",
      "Buckinghamshire", "Cambridgeshire", "Central", "Cheshire", "Cleveland",
      "Clwyd", "Cornwall", "County Antrim", "County Armagh", "County Down",
      "County Fermanagh", "County Londonderry", "County Tyrone", "Cumbria",
      "Derbyshire", "Devon", "Dorset", "Dumfries and Galloway", "Durham",
      "Dyfed", "East Sussex", "Essex", "Fife", "Gloucestershire", "Grampian",
      "Greater Manchester", "Gwent", "Gwynedd County", "Hampshire",
      "Herefordshire", "Hertfordshire", "Highlands and Islands", "Humberside",
      "Isle of Wight", "Kent", "Lancashire", "Leicestershire", "Lincolnshire",
      "Lothian", "Merseyside", "Mid Glamorgan", "Norfolk", "North Yorkshire",
      "Northamptonshire", "Northumberland", "Nottinghamshire", "Oxfordshire",
      "Powys", "Rutland", "Shropshire", "Somerset", "South Glamorgan",
      "South Yorkshire", "Staffordshire", "Strathclyde", "Suffolk", "Surrey",
      "Tayside", "Tyne and Wear", "Warwickshire", "West Glamorgan", "West Midlands",
      "West Sussex", "West Yorkshire", "Wiltshire", "Worcestershire"};

        static readonly string[] UK_COUNTRY = new[] { "England", "Scotland", "Wales", "Northern Ireland" };

        static readonly string[] UK_POSTCODE = new[] { "??# #??", "??## #??" };

        static readonly string[] NEIGHBORHOOD = new[] {"East of Telegraph Road", "North Norridge", "Northwest Midlothian/Midlothian Country Club",
      "Mott Haven/Port Morris", "Kingsbridge Heights", "Bronxdale", "Pennypack", "Bridesburg",
      "Allegheny West", "Bushwick South", "Dyker Heights", "Ocean Parkway South", "Summerlin North",
      "Seven Hills Area", "Greater Las Vegas National", "phoenix", "Central Chandler", "South of Bell Road",
      "River Heights", "White Plains Central", "Mount Kisco West", "Pound Ridge East", "Babylon Bayside",
      "Sagaponack Seaside", "South of Lake Ave", "Far Rockaway/Bayswater", "Jamaica Estates/Holliswood",
      "Murray Hill", "East Renton", "Renton West", "Auburn North", "Northwoods West", "Florissant West",
      "Ladue South", "Candlewood Country Club", "West Covina East", "North East Irwindale", "Sunshine-Gardens",
      "Cipriani", "Brentwood Central", "Jupiter South/Abacoa", "Sea Ranch Lakes", "Schall Circle/Lakeside Green",
      "Olmsted Falls Central", "South of Lake Shore Blvd", "Gates Mills North", "White Oak South of Columbia Pike",
      "Rockville East of Hungerford Dr", "Cleveland Park" };
    };
}
