using System.Text;
using Microsoft.Extensions.Primitives;

namespace EuropeanStates.Data;

public class Country
{
    public string Name = string.Empty;
    public string Currency = string.Empty;
    public string CurrencyAbbreviation = string.Empty;
    public bool IsEuropeanEconomicArea = false;
    public bool IsEuropeanUnion = false;
    public bool IsSchengenArea = false;
    public bool IsEurozone = false;
    public bool IsNato = false;


    public string GetMemberships()
    {
        StringBuilder sb = new StringBuilder();
        bool isSubsequent = false;
        if (IsEuropeanUnion)
        {
            sb.Append("EU");
            isSubsequent = true;
        }

        if (IsEuropeanEconomicArea)
        {
            if (isSubsequent) sb.Append(", ");
            sb.Append("EEA");
            isSubsequent = true;
        }

        if (IsEurozone)
        {
            if (isSubsequent) sb.Append(", ");
            sb.Append("Eurozone");
            isSubsequent = true;
        }

        if (IsSchengenArea)
        {
            if (isSubsequent) sb.Append(", ");
            sb.Append("Schengen");
            isSubsequent = true;
        }

        if (IsNato)
        {
            if (isSubsequent) sb.Append(", ");
            sb.Append("NATO");
            isSubsequent = true;
        }
        
        return sb.ToString();
    }
}