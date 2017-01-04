﻿using Nager.Date.Contract;
using Nager.Date.Model;
using System;
using System.Collections.Generic;

namespace Nager.Date.PublicHolidays
{
    public class BelgiumProvider : IPublicHolidayProvider
    {
        public IEnumerable<PublicHoliday> Get(DateTime easterSunday, int year)
        {
            //Belgium
            //https://en.wikipedia.org/wiki/Public_holidays_in_Belgium

            var countryCode = CountryCode.BE;

            var items = new List<PublicHoliday>();
            items.Add(new PublicHoliday(1, 1, year, "Nieuwjaar", "New Year's Day", countryCode, 1967));
            items.Add(new PublicHoliday(easterSunday.AddDays(1), " Paasmaandag", "Easter Monday", countryCode, 1642));
            items.Add(new PublicHoliday(1, 5, year, "Dag van de arbeid", "Labor Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(39), "Onze Lieve Heer hemel", "Ascension Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(50), "Pinkstermaandag", "Whit Monday", countryCode));
            items.Add(new PublicHoliday(21, 7, year, "Nationale feestdag", "Belgian National Day", countryCode));
            items.Add(new PublicHoliday(15, 8, year, "Onze Lieve Vrouw hemelvaart", "Assumption of the Virgin Mary", countryCode));
            items.Add(new PublicHoliday(1, 11, year, "Allerheiligen", "All Saints' Day", countryCode));
            items.Add(new PublicHoliday(11, 11, year, "Wapenstilstand", "Armistice Day", countryCode));
            items.Add(new PublicHoliday(25, 12, year, "Weihnachten", "Christmas Day", countryCode));

            return items;
        }
    }
}
