using System.Collections.ObjectModel;
namespace Iban.Data;


public class IbanCountryData
{
    public string CountryCode { get; set; } = string.Empty;
    public string CountryName { get; set;} = string.Empty;
    public int Length { get; set; }
    public string IBANFormatRegex { get; set; } = string.Empty;
}
public static class IbanData
{
    public static ReadOnlyDictionary<string, IbanCountryData> CountryData = new ReadOnlyDictionary<string, IbanCountryData>(new Dictionary<string, IbanCountryData>
    {
        { "AD", new IbanCountryData { CountryCode = "AD", CountryName = "Andorra", Length = 24, IBANFormatRegex = "AD[0-9]{2}[0-9]{4}[0-9]{4}[a-zA-Z0-9]{12}$" } },
        { "AE", new IbanCountryData { CountryCode = "AE", CountryName = "United Arab Emirates", Length = 23, IBANFormatRegex = "AE[0-9]{2}[0-9]{3}[0-9]{16}$" } },
        { "AL", new IbanCountryData { CountryCode = "AL", CountryName = "Albania", Length = 28, IBANFormatRegex = "AL[0-9]{2}[0-9]{8}[a-zA-Z0-9]{16}$" } },
        { "AT", new IbanCountryData { CountryCode = "AT", CountryName = "Austria", Length = 20, IBANFormatRegex = "AT[0-9]{2}[0-9]{5}[0-9]{11}$" } },
        { "AZ", new IbanCountryData { CountryCode = "AZ", CountryName = "Azerbaijan", Length = 28, IBANFormatRegex = "AZ[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{20}$" } },
        { "BA", new IbanCountryData { CountryCode = "BA", CountryName = "Bosnia and Herzegovina", Length = 20, IBANFormatRegex = "BA[0-9]{2}[0-9]{3}[0-9]{3}[0-9]{8}[0-9]{2}$" } },
        { "BE", new IbanCountryData { CountryCode = "BE", CountryName = "Belgium", Length = 16, IBANFormatRegex = "BE[0-9]{2}[0-9]{3}[0-9]{9}$" } },
        { "BG", new IbanCountryData { CountryCode = "BG", CountryName = "Bulgaria", Length = 22, IBANFormatRegex = "BG[0-9]{2}[A-Z]{4}[0-9]{4}[0-9]{2}[a-zA-Z0-9]{8}$" } },
        { "BH", new IbanCountryData { CountryCode = "BH", CountryName = "Bahrain", Length = 22, IBANFormatRegex = "BH[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{14}$" } },
        { "BI", new IbanCountryData { CountryCode = "BI", CountryName = "Burundi", Length = 27, IBANFormatRegex = "BI[0-9]{2}[0-9]{5}[0-9]{5}[0-9]{11}[0-9]{2}$" } },
        { "BR", new IbanCountryData { CountryCode = "BR", CountryName = "Brazil", Length = 29, IBANFormatRegex = "BR[0-9]{2}[0-9]{8}[0-9]{5}[0-9]{10}[A-Z]{1}[a-zA-Z0-9]{1}$" } },
        { "BY", new IbanCountryData { CountryCode = "BY", CountryName = "Belarus", Length = 28, IBANFormatRegex = "BY[0-9]{2}[a-zA-Z0-9]{4}[0-9]{4}[a-zA-Z0-9]{16}$" } },
        { "CH", new IbanCountryData { CountryCode = "CH", CountryName = "Switzerland", Length = 21, IBANFormatRegex = "CH[0-9]{2}[0-9]{5}[a-zA-Z0-9]{12}$" } },
        { "CR", new IbanCountryData { CountryCode = "CR", CountryName = "Costa Rica", Length = 22, IBANFormatRegex = "CR[0-9]{2}[0-9]{4}[0-9]{14}$" } },
        { "CY", new IbanCountryData { CountryCode = "CY", CountryName = "Cyprus", Length = 28, IBANFormatRegex = "CY[0-9]{2}[0-9]{3}[0-9]{5}[a-zA-Z0-9]{16}$" } },
        { "CZ", new IbanCountryData { CountryCode = "CZ", CountryName = "Czech Republic", Length = 24, IBANFormatRegex = "CZ[0-9]{2}[0-9]{4}[0-9]{6}[0-9]{10}$" } },
        { "DE", new IbanCountryData { CountryCode = "DE", CountryName = "Germany", Length = 22, IBANFormatRegex = "DE[0-9]{2}[0-9]{8}[0-9]{10}$" } },
        { "DJ", new IbanCountryData { CountryCode = "DJ", CountryName = "Djibouti", Length = 27, IBANFormatRegex = "DJ[0-9]{2}[0-9]{5}[0-9]{5}[0-9]{11}[0-9]{2}$" } },
        { "DK", new IbanCountryData { CountryCode = "DK", CountryName = "Denmark", Length = 18, IBANFormatRegex = "DK[0-9]{2}[0-9]{4}[0-9]{9}[0-9]{1}$" } },
        { "DO", new IbanCountryData { CountryCode = "DO", CountryName = "Dominican Republic", Length = 28, IBANFormatRegex = "DO[0-9]{2}[a-zA-Z0-9]{4}[0-9]{20}$" } },
        { "EE", new IbanCountryData { CountryCode = "EE", CountryName = "Estonia", Length = 20, IBANFormatRegex = "EE[0-9]{2}[0-9]{2}[0-9]{2}[0-9]{11}[0-9]{1}$" } },
        { "EG", new IbanCountryData { CountryCode = "EG", CountryName = "Egypt", Length = 29, IBANFormatRegex = "EG[0-9]{2}[0-9]{4}[0-9]{4}[0-9]{17}$" } },
        { "ES", new IbanCountryData { CountryCode = "ES", CountryName = "Spain", Length = 24, IBANFormatRegex = "ES[0-9]{2}[0-9]{4}[0-9]{4}[0-9]{1}[0-9]{1}[0-9]{10}$" } },
        { "FI", new IbanCountryData { CountryCode = "FI", CountryName = "Finland", Length = 18, IBANFormatRegex = "FI[0-9]{2}[0-9]{3}[0-9]{11}$" } },
        { "FK", new IbanCountryData { CountryCode = "FK", CountryName = "Falkland Islands", Length = 18, IBANFormatRegex = "FK[0-9]{2}[A-Z]{2}[0-9]{12}$" } },
        { "FO", new IbanCountryData { CountryCode = "FO", CountryName = "Faroe Islands", Length = 18, IBANFormatRegex = "FO[0-9]{2}[0-9]{4}[0-9]{9}[0-9]{1}$" } },
        { "FR", new IbanCountryData { CountryCode = "FR", CountryName = "France", Length = 27, IBANFormatRegex = "FR[0-9]{2}[0-9]{5}[0-9]{5}[a-zA-Z0-9]{11}[0-9]{2}$" } },
        { "GB", new IbanCountryData { CountryCode = "GB", CountryName = "United Kingdom", Length = 22, IBANFormatRegex = "GB[0-9]{2}[A-Z]{4}[0-9]{6}[0-9]{8}$" } },
        { "GE", new IbanCountryData { CountryCode = "GE", CountryName = "Georgia", Length = 22, IBANFormatRegex = "GE[0-9]{2}[A-Z]{2}[0-9]{16}$" } },
        { "GI", new IbanCountryData { CountryCode = "GI", CountryName = "Gibraltar", Length = 23, IBANFormatRegex = "GI[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{15}$" } },
        { "GL", new IbanCountryData { CountryCode = "GL", CountryName = "Greenland", Length = 18, IBANFormatRegex = "GL[0-9]{2}[0-9]{4}[0-9]{9}[0-9]{1}$" } },
        { "GR", new IbanCountryData { CountryCode = "GR", CountryName = "Greece", Length = 27, IBANFormatRegex = "GR[0-9]{2}[0-9]{3}[0-9]{4}[a-zA-Z0-9]{16}$" } },
        { "GT", new IbanCountryData { CountryCode = "GT", CountryName = "Guatemala", Length = 28, IBANFormatRegex = "GT[0-9]{2}[a-zA-Z0-9]{4}[a-zA-Z0-9]{20}$" } },
        { "HR", new IbanCountryData { CountryCode = "HR", CountryName = "Croatia", Length = 21, IBANFormatRegex = "HR[0-9]{2}[0-9]{7}[0-9]{10}$" } },
        { "HU", new IbanCountryData { CountryCode = "HU", CountryName = "Hungary", Length = 28, IBANFormatRegex = "HU[0-9]{2}[0-9]{3}[0-9]{4}[0-9]{1}[0-9]{15}[0-9]{1}$" } },
        { "IE", new IbanCountryData { CountryCode = "IE", CountryName = "Ireland", Length = 22, IBANFormatRegex = "IE[0-9]{2}[A-Z]{4}[0-9]{6}[0-9]{8}$" } },
        { "IL", new IbanCountryData { CountryCode = "IL", CountryName = "Israel", Length = 23, IBANFormatRegex = "IL[0-9]{2}[0-9]{3}[0-9]{3}[0-9]{13}$" } },
        { "IQ", new IbanCountryData { CountryCode = "IQ", CountryName = "Iraq", Length = 23, IBANFormatRegex = "IQ[0-9]{2}[A-Z]{4}[0-9]{3}[0-9]{12}$" } },
        { "IS", new IbanCountryData { CountryCode = "IS", CountryName = "Iceland", Length = 26, IBANFormatRegex = "IS[0-9]{2}[0-9]{4}[0-9]{2}[0-9]{6}[0-9]{10}$" } },
        { "IT", new IbanCountryData { CountryCode = "IT", CountryName = "Italy", Length = 27, IBANFormatRegex = "IT[0-9]{2}[A-Z]{1}[0-9]{5}[0-9]{5}[a-zA-Z0-9]{12}$" } },
        { "JO", new IbanCountryData { CountryCode = "JO", CountryName = "Jordan", Length = 30, IBANFormatRegex = "JO[0-9]{2}[A-Z]{4}[0-9]{4}[a-zA-Z0-9]{18}$" } },
        { "KW", new IbanCountryData { CountryCode = "KW", CountryName = "Kuwait", Length = 30, IBANFormatRegex = "KW[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{22}$" } },
        { "KZ", new IbanCountryData { CountryCode = "KZ", CountryName = "Kazakhstan", Length = 20, IBANFormatRegex = "KZ[0-9]{2}[0-9]{3}[a-zA-Z0-9]{13}$" } },
        { "LB", new IbanCountryData { CountryCode = "LB", CountryName = "Lebanon", Length = 28, IBANFormatRegex = "LB[0-9]{2}[0-9]{4}[a-zA-Z0-9]{20}$" } },
        { "LC", new IbanCountryData { CountryCode = "LC", CountryName = "Saint Lucia", Length = 32, IBANFormatRegex = "LC[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{24}$" } },
        { "LI", new IbanCountryData { CountryCode = "LI", CountryName = "Liechtenstein", Length = 21, IBANFormatRegex = "LI[0-9]{2}[0-9]{5}[a-cA-Z0-9]{12}$" } },
        { "LT", new IbanCountryData { CountryCode = "LT", CountryName = "Lithuania", Length = 20, IBANFormatRegex = "LT[0-9]{2}[0-9]{5}[0-9]{11}$" } },
        { "LU", new IbanCountryData { CountryCode = "LU", CountryName = "Luxembourg", Length = 20, IBANFormatRegex = "LU[0-9]{2}[0-9]{3}[a-zA-Z0-9]{13}$" } },
        { "LV", new IbanCountryData { CountryCode = "LV", CountryName = "Latvia", Length = 21, IBANFormatRegex = "LV[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{13}$" } },
        { "LY", new IbanCountryData { CountryCode = "LY", CountryName = "Libya", Length = 25, IBANFormatRegex = "LY[0-9]{2}[0-9]{3}[0-9]{3}[0-9]{15}$" } },
        { "MC", new IbanCountryData { CountryCode = "MC", CountryName = "Monaco", Length = 27, IBANFormatRegex = "MC[0-9]{2}[0-9]{5}[0-9]{5}[a-zA-Z0-9]{11}[0-9]{2}$" } },
        { "MD", new IbanCountryData { CountryCode = "MD", CountryName = "Moldova", Length = 24, IBANFormatRegex = "MD[0-9]{2}[a-zA-Z0-9]{2}[a-zA-Z0-9]{18}$" } },
        { "ME", new IbanCountryData { CountryCode = "ME", CountryName = "Montenegro", Length = 22, IBANFormatRegex = "ME[0-9]{2}[0-9]{3}[0-9]{13}[0-9]{2}$" } },
        { "MK", new IbanCountryData { CountryCode = "MK", CountryName = "Macedonia", Length = 19, IBANFormatRegex = "MK[0-9]{2}[0-9]{3}[a-zA-Z0-9]{10}[0-9]{2}$" } },
        { "MN", new IbanCountryData { CountryCode = "MN", CountryName = "Mongolia", Length = 20, IBANFormatRegex = "MN[0-9]{2}[0-9]{4}[0-9]{12}$" } },
        { "MR", new IbanCountryData { CountryCode = "MR", CountryName = "Mauritania", Length = 27, IBANFormatRegex = "MR[0-9]{2}[0-9]{5}[0-9]{5}[0-9]{11}[0-9]{2}$" } },
        { "MT", new IbanCountryData { CountryCode = "MT", CountryName = "Malta", Length = 31, IBANFormatRegex = "MT[0-9]{2}[A-Z]{4}[0-9]{5}[a-zA-Z0-9]{18}$" } },
        { "MU", new IbanCountryData { CountryCode = "MU", CountryName = "Mauritius", Length = 30, IBANFormatRegex = "MU[0-9]{2}[A-Z]{4}[0-9]{2}[0-9]{2}[0-9]{12}[0-9]{3}[A-Z]{3}$" } },
        { "NI", new IbanCountryData { CountryCode = "NI", CountryName = "Nicaragua", Length = 28, IBANFormatRegex = "NI[0-9]{2}[A-Z]{4}[0-9]{20}$" } },
        { "NL", new IbanCountryData { CountryCode = "NL", CountryName = "Netherlands", Length = 18, IBANFormatRegex = "NL[0-9]{2}[A-Z]{4}[0-9]{10}$" } },
        { "NO", new IbanCountryData { CountryCode = "NO", CountryName = "Norway", Length = 15, IBANFormatRegex = "NO[0-9]{2}[0-9]{4}[0-9]{6}[0-9]{1}$" } },
        { "OM", new IbanCountryData { CountryCode = "OM", CountryName = "Oman", Length = 23, IBANFormatRegex = "OM[0-9]{2}[0-9]{3}[a-zA-Z0-9]{16}$" } },
        { "PK", new IbanCountryData { CountryCode = "PK", CountryName = "Pakistan", Length = 24, IBANFormatRegex = "PK[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{16}$" } },
        { "PL", new IbanCountryData { CountryCode = "PL", CountryName = "Poland", Length = 28, IBANFormatRegex = "PL[0-9]{2}[0-9]{8}[0-9]{16}$" } },
        { "PS", new IbanCountryData { CountryCode = "PS", CountryName = "Palestine, State of", Length = 29, IBANFormatRegex = "PS[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{21}$" } },
        { "PT", new IbanCountryData { CountryCode = "PT", CountryName = "Portugal", Length = 25, IBANFormatRegex = "PT[0-9]{2}[0-9]{4}[0-9]{4}[0-9]{11}[0-9]{2}$" } },
        { "QA", new IbanCountryData { CountryCode = "QA", CountryName = "Qatar", Length = 29, IBANFormatRegex = "QA[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{21}$" } },
        { "RO", new IbanCountryData { CountryCode = "RO", CountryName = "Romania", Length = 24, IBANFormatRegex = "RO[0-9]{2}[A-Z]{4}[a-zA-Z0-9]{16}$" } },
        { "RS", new IbanCountryData { CountryCode = "RS", CountryName = "Serbia", Length = 22, IBANFormatRegex = "RS[0-9]{2}[0-9]{3}[0-9]{13}[0-9]{2}$" } },
        { "RU", new IbanCountryData { CountryCode = "RU", CountryName = "Russian Federation", Length = 33, IBANFormatRegex = "RU[0-9]{2}[0-9]{9}[0-9]{5}[a-zA-Z0-9]{15}$" } },
        { "SA", new IbanCountryData { CountryCode = "SA", CountryName = "Saudi Arabia", Length = 24, IBANFormatRegex = "SA[0-9]{2}[0-9]{2}[a-zA-Z0-9]{18}$" } },
        { "SC", new IbanCountryData { CountryCode = "SC", CountryName = "Seychelles", Length = 31, IBANFormatRegex = "SC[0-9]{2}[A-Z]{4}[0-9]{2}[0-9]{2}[0-9]{16}[A-Z]{3}$" } },
        { "SD", new IbanCountryData { CountryCode = "SD", CountryName = "Sudan", Length = 18, IBANFormatRegex = "SD[0-9]{2}[0-9]{2}[0-9]{12}$" } },
        { "SE", new IbanCountryData { CountryCode = "SE", CountryName = "Sweden", Length = 24, IBANFormatRegex = "SE[0-9]{2}[0-9]{3}[0-9]{16}[0-9]{1}$" } },
        { "SI", new IbanCountryData { CountryCode = "SI", CountryName = "Slovenia", Length = 19, IBANFormatRegex = "SI[0-9]{2}[0-9]{5}[0-9]{8}[0-9]{2}$" } },
        { "SK", new IbanCountryData { CountryCode = "SK", CountryName = "Slovakia", Length = 24, IBANFormatRegex = "SK[0-9]{2}[0-9]{4}[0-9]{6}[0-9]{10}$" } },
        { "SM", new IbanCountryData { CountryCode = "SM", CountryName = "San Marino", Length = 27, IBANFormatRegex = "SM[0-9]{2}[A-Z]{1}[0-9]{5}[0-9]{5}[a-zA-Z0-9]{12}$" } },
        { "SO", new IbanCountryData { CountryCode = "SO", CountryName = "Somalia", Length = 23, IBANFormatRegex = "SO[0-9]{2}[0-9]{4}[0-9]{3}[0-9]{12}$" } },
        { "ST", new IbanCountryData { CountryCode = "ST", CountryName = "Sao Tome and Principe", Length = 25, IBANFormatRegex = "ST[0-9]{2}[0-9]{4}[0-9]{4}[0-9]{11}[0-9]{2}$" } },
        { "SV", new IbanCountryData { CountryCode = "SV", CountryName = "El Salvador", Length = 28, IBANFormatRegex = "SV[0-9]{2}[A-Z]{4}[0-9]{20}$" } },
        { "TL", new IbanCountryData { CountryCode = "TL", CountryName = "Timor-Leste", Length = 23, IBANFormatRegex = "TL[0-9]{2}[0-9]{3}[0-9]{14}[0-9]{2}$" } },
        { "TN", new IbanCountryData { CountryCode = "TN", CountryName = "Tunisia", Length = 24, IBANFormatRegex = "TN[0-9]{2}[0-9]{2}[0-9]{3}[0-9]{13}[0-9]{2}$" } },
        { "TR", new IbanCountryData { CountryCode = "TR", CountryName = "Turkey", Length = 26, IBANFormatRegex = "TR[0-9]{2}[0-9]{5}[0-9]{1}[a-zA-Z0-9]{16}$" } },
        { "UA", new IbanCountryData { CountryCode = "UA", CountryName = "Ukraine", Length = 29, IBANFormatRegex = "UA[0-9]{2}[0-9]{6}[a-zA-Z0-9]{19}$" } },
        { "VA", new IbanCountryData { CountryCode = "VA", CountryName = "Vatican City State", Length = 22, IBANFormatRegex = "VA[0-9]{2}[0-9]{3}[0-9]{15}$" } },
        { "VG", new IbanCountryData { CountryCode = "VG", CountryName = "Virgin Islands, British", Length = 24, IBANFormatRegex = "VG[0-9]{2}[A-Z]{4}[0-9]{16}$" } },
        { "XK", new IbanCountryData { CountryCode = "XK", CountryName = "Kosovo", Length = 20, IBANFormatRegex = "XK[0-9]{2}[0-9]{4}[0-9]{10}[0-9]{2}$" } }
    });

    public static ReadOnlyDictionary<string, int> Lengths {get;} = new ReadOnlyDictionary<string, int>(new Dictionary<string, int>
        {
            { "AD", 24 },
            { "AE", 23 },
            { "AL", 28 },
            { "AT", 20 },
            { "AZ", 28 },
            { "BA", 20 },
            { "BE", 16 },
            { "BG", 22 },
            { "BH", 22 },
            { "BI", 27 },
            { "BR", 29 },
            { "BY", 28 },
            { "CH", 21 },
            { "CR", 22 },
            { "CY", 28 },
            { "CZ", 24 },
            { "DE", 22 },
            { "DJ", 27 },
            { "DK", 18 },
            { "DO", 28 },
            { "EE", 20 },
            { "EG", 29 },
            { "ES", 24 },
            { "FI", 18 },
            { "FK", 18 },
            { "FO", 18 },
            { "FR", 27 },
            { "GB", 22 },
            { "GE", 22 },
            { "GI", 23 },
            { "GL", 18 },
            { "GR", 27 },
            { "GT", 28 },
            { "HR", 21 },
            { "HU", 28 },
            { "IE", 22 },
            { "IL", 23 },
            { "IQ", 23 },
            { "IS", 26 },
            { "IT", 27 },
            { "JO", 30 },
            { "KW", 30 },
            { "KZ", 20 },
            { "LB", 28 },
            { "LC", 32 },
            { "LI", 21 },
            { "LT", 20 },
            { "LU", 20 },
            { "LV", 21 },
            { "LY", 25 },
            { "MC", 27 },
            { "MD", 24 },
            { "ME", 22 },
            { "MK", 19 },
            { "MN", 20 },
            { "MR", 27 },
            { "MT", 31 },
            { "MU", 30 },
            { "NI", 28 },
            { "NL", 18 },
            { "NO", 15 },
            { "OM", 23 },
            { "PK", 24 },
            { "PL", 28 },
            { "PS", 29 },
            { "PT", 25 },
            { "QA", 29 },
            { "RO", 24 },
            { "RS", 22 },
            { "RU", 33 },
            { "SA", 24 },
            { "SC", 31 },
            { "SD", 18 },
            { "SE", 24 },
            { "SI", 19 },
            { "SK", 24 },
            { "SM", 27 },
            { "SO", 23 },
            { "ST", 25 },
            { "SV", 28 },
            { "TL", 23 },
            { "TN", 24 },
            { "TR", 26 },
            { "UA", 29 },
            { "VA", 22 },
            { "VG", 24 },
            { "XK", 20 }
        });

    public static ReadOnlyDictionary<string, int> CharacterValues {get;} = new ReadOnlyDictionary<string, int>(new Dictionary<string, int>
        {
            { "A", 10 },
            { "B", 11 },
            { "C", 12 },
            { "D", 13 },
            { "E", 14 },
            { "F", 15 },
            { "G", 16 },
            { "H", 17 },
            { "I", 18 },
            { "J", 19 },
            { "K", 20 },
            { "L", 21 },
            { "M", 22 },
            { "N", 23 },
            { "O", 24 },
            { "P", 25 },
            { "Q", 26 },
            { "R", 27 },
            { "S", 28 },
            { "T", 29 },
            { "U", 30 },
            { "V", 31 },
            { "W", 32 },
            { "X", 33 },
            { "Y", 34 },
            { "Z", 35 }
        });

}
