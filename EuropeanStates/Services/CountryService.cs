using EuropeanStates.Data;

namespace EuropeanStates.Services;

public class CountryService
{
    public List<Country> FilterCountries(bool isEuropeanUnion, bool isEuropeanEconomicArea,
        bool isEurozone, bool isSchengenArea, bool isNato)
    {
        var countries = GetCountries();
        var filteredCountries = new List<Country>();
        
        // if no checkboxes are selected then show all countries
        if (!isEuropeanUnion && !isEuropeanEconomicArea && !isEurozone && !isSchengenArea && !isNato)
        {
            return countries;
        }

        // if a country matches ANY of the checked boxes then add it to the list
        foreach (var country in countries)
        {
            if(isEuropeanUnion && country.IsEuropeanUnion) filteredCountries.Add(country);
            if(isEuropeanEconomicArea && country.IsEuropeanEconomicArea) filteredCountries.Add(country);
            if(isEurozone && country.IsEurozone) filteredCountries.Add(country);
            if(isSchengenArea && country.IsSchengenArea) filteredCountries.Add(country);
            if(isNato && country.IsNato) filteredCountries.Add(country);
        }
        
        return filteredCountries.OrderByDescending(c => c.Name).ToList();
    }
    
    public List<Country> GetCountries() => new()
    {
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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

        new Country
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
        new Country
        {
            Name = "Czechia",
            Currency = "Koruna",
            CurrencyAbbreviation = "CZK",
            IsEuropeanEconomicArea = true,
            IsEuropeanUnion = true,
            IsSchengenArea = true,
            IsEurozone = false,
            IsNato = true
        },
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
        {
            Name = "North Macedonia",
            Currency = "Denar",
            CurrencyAbbreviation = "MKD",
            IsEuropeanEconomicArea = false,
            IsEuropeanUnion = false,
            IsSchengenArea = false,
            IsEurozone = false,
            IsNato = true
        },
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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
        new Country
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

        new Country
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

        new Country
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

        new Country
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

        new Country
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

        new Country
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

        new Country
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