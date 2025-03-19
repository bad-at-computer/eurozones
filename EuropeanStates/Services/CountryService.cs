using EuropeanStates.Data;

namespace EuropeanStates.Services;

public class CountryService
{
    public List<Countries> FilterCountries(bool isEuropeanUnion, bool isEuropeanEconomicArea,
        bool isEurozone, bool isSchengenArea, bool isNato)
    {
        var countries = GetCountries();
        var filteredCountries = new List<Countries>();
        
        // if no checkboxes are selected then show all countries
        if (!isEuropeanUnion && !isEuropeanEconomicArea && !isEurozone && !isSchengenArea && !isNato)
        {
            return countries;
        }

        // if a country INCLUDES ALL the CHECKED boxes then add it to the list
        foreach (var country in countries)
        {
            var addToList = !(isEuropeanUnion && !country.IsEuropeanUnion);
            if(isEuropeanEconomicArea && !country.IsEuropeanEconomicArea) addToList = false;
            if (isEurozone && !country.IsEurozone) addToList = false;
            if(isSchengenArea && !country.IsSchengenArea) addToList = false;
            if(isNato && !country.IsNato) addToList = false;
            if(addToList) filteredCountries.Add(country);
        }
        
        return filteredCountries.OrderBy(c => c.Name).ToList();
    }
    
    public List<Countries> GetCountries() => new()
    {
        new Countries
        {
            Name = "Albania",
            Currency = "Lek",
            CurrencyAbbreviation = "ALL",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Andorra",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Armenia",
            Currency = "Dram",
            CurrencyAbbreviation = "AMD",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Austria",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = false
        },
        new Countries
        {
            Name = "Azerbaijan",
            Currency = "Manat",
            CurrencyAbbreviation = "AZN",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Belarus",
            Currency = "Ruble",
            CurrencyAbbreviation = "BYN",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Belgium",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Bosnia and Herzegovina",
            Currency = "Marka",
            CurrencyAbbreviation = "BAM",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Bulgaria",
            Currency = "Lev",
            CurrencyAbbreviation = "BGN",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Croatia",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },

        new Countries
        {
            Name = "Cyprus",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = false,
            IsEurozone = true,
            IsNato = false
        },
        new Countries
        {
            Name = "Czech Republic",
            Currency = "Koruna",
            CurrencyAbbreviation = "CZK",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Denmark",
            Currency = "Krone",
            CurrencyAbbreviation = "DKK",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Estonia",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Finland",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "France",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Georgia",
            Currency = "Lari",
            CurrencyAbbreviation = "GEL",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Germany",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Greece",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Hungary",
            Currency = "Forint",
            CurrencyAbbreviation = "HUF",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Iceland",
            Currency = "Króna",
            CurrencyAbbreviation = "ISK",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = false,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Ireland",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = false,
            IsEurozone = true,
            IsNato = false
        },
        new Countries
        {
            Name = "Italy",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Latvia",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Liechtenstein",
            Currency = "Franc",
            CurrencyAbbreviation = "CHF",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = false,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Lithuania",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Luxembourg",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Malta",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = false
        },
        new Countries
        {
            Name = "Monaco",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Montenegro",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Netherlands",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "The former Yugoslav Republic of Macedonia", // TODO check this
            Currency = "Denar",
            CurrencyAbbreviation = "MKD",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Republic of Moldova",
            Currency = "Leu",
            CurrencyAbbreviation = "MDL",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Norway",
            Currency = "Krone",
            CurrencyAbbreviation = "NOK",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = false,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Poland",
            Currency = "Zloty",
            CurrencyAbbreviation = "PLN",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Portugal",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Romania",
            Currency = "Leu",
            CurrencyAbbreviation = "RON",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Countries
        {
            Name = "Russia",
            Currency = "Ruble",
            CurrencyAbbreviation = "RUB",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Serbia",
            Currency = "Dinar",
            CurrencyAbbreviation = "RSD",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },
        new Countries
        {
            Name = "Slovakia",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },
        new Countries
        {
            Name = "Slovenia",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },

        new Countries
        {
            Name = "Spain",
            Currency = "Euro",
            CurrencyAbbreviation = "EUR",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = true,
            IsNato = true
        },

        new Countries
        {
            Name = "Sweden",
            Currency = "Krona",
            CurrencyAbbreviation = "SEK",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },

        new Countries
        {
            Name = "Switzerland",
            Currency = "Franc",
            CurrencyAbbreviation = "CHF",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = false
        },

        new Countries
        {
            Name = "Turkey",
            Currency = "Lira",
            CurrencyAbbreviation = "TRY",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = true
        },

        new Countries
        {
            Name = "Ukraine",
            Currency = "Hryvnia",
            CurrencyAbbreviation = "UAH",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = false
        },

        new Countries
        {
            Name = "United Kingdom",
            Currency = "Pound Sterling",
            CurrencyAbbreviation = "GBP",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = true
        }
    };
}