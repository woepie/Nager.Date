﻿using Nager.Date.Contract;
using Nager.Date.Model;
using System;
using System.Collections.Generic;

namespace Nager.Date.PublicHolidays
{
    public class GermanyProvider : IPublicHolidayProvider
    {
        public IEnumerable<PublicHoliday> Get(DateTime easterSunday, int year)
        {
            //Germany
            //https://en.wikipedia.org/wiki/Public_holidays_in_Germany

            var countryCode = CountryCode.DE;

            var items = new List<PublicHoliday>();
            items.Add(new PublicHoliday(1, 1, year, "Neujahr", "New Year's Day", countryCode, 1967));
            items.Add(new PublicHoliday(6, 1, year, "Heilige Drei Könige", "Epiphany", countryCode, 1967, new string[] { "BW", "BY", "ST" }));
            items.Add(new PublicHoliday(easterSunday.AddDays(-2), "Karfreitag", "Good Friday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(1), "Ostermontag", "Easter Monday", countryCode, 1642));
            items.Add(new PublicHoliday(1, 5, year, "Tag der Arbeit", "Labor Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(39), "Christi Himmelfahrt", "Ascension Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(50), "Pfingstmontag", "Whit Monday", countryCode));
            items.Add(new PublicHoliday(3, 10, year, "Tag der Deutschen Einheit", "German Unity Day", countryCode));
            items.Add(new PublicHoliday(31, 10, year, "Reformationstag", "Reformation Day", countryCode, null, new string[] { "BB", "MV", "SN", "ST", "TH" }));
            items.Add(new PublicHoliday(1, 11, year, "Allerheiligen", "All Saints' Day", countryCode, null, new string[] { "BW", "BY", "NW", "RP", "SL" }));
            items.Add(new PublicHoliday(25, 12, year, "Weihnachten", "Christmas Day", countryCode));
            items.Add(new PublicHoliday(26, 12, year, "Stefanitag", "St. Stephen's Day", countryCode));

            return items;
        }
    }
}
