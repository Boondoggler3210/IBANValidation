using System.Collections.ObjectModel;
using System.Security.AccessControl;

namespace Bic.Data;

public static class IsoCountryCodes
{
    public static List<string> CountryCodes = new List<string>()
    {
        "AD",
        "AE",
        "AF",
        "AG",
        "AI",
        "AL",
        "AM",
        "AO",
        "AQ",
        "AR",
        "AS",
        "AT",
        "AU",
        "AW",
        "AX",
        "AZ",
        "BA",
        "BB",
        "BD",
        "BE",
        "BF",
        "BG",
        "BH",
        "BI",
        "BJ",
        "BL",
        "BM",
        "BN",
        "BO",
        "BQ",
        "BR",
        "BS",
        "BT",
        "BV",
        "BW",
        "BY",
        "BZ",
        "CA",
        "CC",
        "CD",
        "CF",
        "CG",
        "CH",
        "CI",
        "CK",
        "CL",
        "CM",
        "CN",
        "CO",
        "CR",
        "CU",
        "CV",
        "CW",
        "CX",
        "CY",
        "CZ",
        "DE",
        "DJ",
        "DK",
        "DM",
        "DO",
        "DZ",
        "EC",
        "EE",
        "EG",
        "EH",
        "ER",
        "ES",
        "ET",
        "FI",
        "FJ",
        "FK",
        "FM",
        "FO",
        "FR",
        "GA",
        "GB",
        "GD",
        "GE",
        "GF",
        "GG",
        "GH",
        "GI",
        "GL",
        "GM",
        "GN",
        "GP",
        "GQ",
        "GR",
        "GS",
        "GT",
        "GU",
        "GW",
        "GY",
        "HK",
        "HM",
        "HN",
        "HR",
        "HT",
        "HU",
        "ID",
        "IE",
        "IL",
        "IM",
        "IN",
        "IO",
        "IQ",
        "IR",
        "IS",
        "IT",
        "JE",
        "JM",
        "JO",
        "JP",
        "KE",
        "KG",
        "KH",
        "KI",
        "KM",
        "KN",
        "KP",
        "KR",
        "KW",
        "KY",
        "KZ",
        "LA",
        "LB",
        "LC",
        "LI",
        "LK",
        "LR",
        "LS",
        "LT",
        "LU",
        "LV",
        "LY",
        "MA",
        "MC",
        "MD",
        "ME",
        "MF",
        "MG",
        "MH",
        "MK",
        "ML",
        "MM",
        "MN",
        "MO",
        "MP",
        "MQ",
        "MR",
        "MS",
        "MT",
        "MU",
        "MV",
        "MW",
        "MX",
        "MY",
        "MZ",
        "NA",
        "NC",
        "NE",
        "NF",
        "NG",
        "NI",
        "NL",
        "NO",
        "NP",
        "NR",
        "NU",
        "NZ",
        "OM",
        "PA",
        "PE",
        "PF",
        "PG",
        "PH",
        "PK",
        "PL",
        "PM",
        "PN",
        "PR",
        "PS",
        "PT",
        "PW",
        "PY",
        "QA",
        "RE",
        "RO",
        "RS",
        "RU",
        "RW",
        "SA",
        "SB",
        "SC",
        "SD",
        "SE",
        "SG",
        "SH",
        "SI",
        "SJ",
        "SK",
        "SL",
        "SM",
        "SN",
        "SO",
        "SR",
        "SS",
        "ST",
        "SV",
        "SX",
        "SY",
        "SZ",
        "TC",
        "TD",
        "TF",
        "TG",
        "TH",
        "TJ",
        "TK",
        "TL",
        "TM",
        "TN",
        "TO",
        "TR",
        "TT",
        "TV",
        "TW",
        "TZ",
        "UA",
        "UG",
        "UM",
        "US",
        "UY",
        "UZ",
        "VA",
        "VC",
        "VE",
        "VG",
        "VI",
        "VN",
        "VU",
        "WF",
        "WS",
        "YE",
        "YT",
        "ZA",
        "ZM",
        "ZW"
    };


    public static ReadOnlyDictionary<string, IsoCountry> IsoCountryBy2Code = new ReadOnlyDictionary<string, IsoCountry>(new Dictionary<string, IsoCountry>
    {
        { "AD", new IsoCountry{ Name = "Andorra", Alpha2Code = "AD", Alpha3Code = "AND", NumericCode = "020" } },
        { "AE", new IsoCountry{ Name = "United Arab Emirates", Alpha2Code = "AE", Alpha3Code = "ARE", NumericCode = "784" } },
        { "AF", new IsoCountry{Name = "Afghanistan", Alpha2Code = "AF", Alpha3Code = "AFG", NumericCode= "004"}},
        { "AG", new IsoCountry{Name = "Antigua and Barbuda", Alpha2Code = "AG", Alpha3Code = "ATG", NumericCode= "028"}},
        { "AI", new IsoCountry{Name = "Anguilla", Alpha2Code = "AI", Alpha3Code = "AIA", NumericCode= "660"}},
        { "AL", new IsoCountry{Name = "Albania", Alpha2Code = "AL", Alpha3Code = "ALB", NumericCode= "008"}},
        { "AM", new IsoCountry{Name = "Armenia", Alpha2Code = "AM", Alpha3Code = "ARM", NumericCode= "051"}},
        { "AO", new IsoCountry{Name = "Angola", Alpha2Code = "AO", Alpha3Code = "AGO", NumericCode= "024"}},
        { "AQ", new IsoCountry{Name = "Antarctica", Alpha2Code = "AQ", Alpha3Code = "ATA", NumericCode= "010"}},
        { "AR", new IsoCountry{Name = "Argentina", Alpha2Code = "AR", Alpha3Code = "ARG", NumericCode= "032"}},
        { "AS", new IsoCountry{Name = "American Samoa", Alpha2Code = "AS", Alpha3Code = "ASM", NumericCode= "016"}},
        { "AT", new IsoCountry{Name = "Austria", Alpha2Code = "AT", Alpha3Code = "AUT", NumericCode= "040"}},
        { "AU", new IsoCountry{Name = "Australia", Alpha2Code = "AU", Alpha3Code = "AUS", NumericCode= "036"}},
        { "AW", new IsoCountry{Name = "Aruba", Alpha2Code = "AW", Alpha3Code = "ABW", NumericCode= "533"}},
        { "AX", new IsoCountry{Name = "Åland Islands", Alpha2Code = "AX", Alpha3Code = "ALA", NumericCode= "248"}},
        { "AZ", new IsoCountry{Name = "Azerbaijan", Alpha2Code = "AZ", Alpha3Code = "AZE", NumericCode= "031"}},
        { "BA", new IsoCountry{Name = "Bosnia and Herzegovina", Alpha2Code = "BA", Alpha3Code = "BIH", NumericCode= "070"}},
        { "BB", new IsoCountry{Name = "Barbados", Alpha2Code = "BB", Alpha3Code = "BRB", NumericCode= "052"}},
        { "BD", new IsoCountry{Name = "Bangladesh", Alpha2Code = "BD", Alpha3Code = "BGD", NumericCode= "050"}},
        { "BE", new IsoCountry{Name = "Belgium", Alpha2Code = "BE", Alpha3Code = "BEL", NumericCode= "056"}},
        { "BF", new IsoCountry{Name = "Burkina Faso", Alpha2Code = "BF", Alpha3Code = "BFA", NumericCode= "854"}},
        { "BG", new IsoCountry{Name = "Bulgaria", Alpha2Code = "BG", Alpha3Code = "BGR", NumericCode= "100"}},
        { "BH", new IsoCountry{Name = "Bahrain", Alpha2Code = "BH", Alpha3Code = "BHR", NumericCode= "048"}},
        { "BI", new IsoCountry{Name = "Burundi", Alpha2Code = "BI", Alpha3Code = "BDI", NumericCode= "108"}},
        { "BJ", new IsoCountry{Name = "Benin", Alpha2Code = "BJ", Alpha3Code = "BEN", NumericCode= "204"}},
        { "BL", new IsoCountry{Name = "Saint Barthélemy", Alpha2Code = "BL", Alpha3Code = "BLM", NumericCode = "652" }},
        { "BM", new IsoCountry{Name = "Bermuda", Alpha2Code = "BM", Alpha3Code = "BMU", NumericCode = "060" }},
        { "BN", new IsoCountry{Name = "Brunei Darussalam", Alpha2Code = "BN", Alpha3Code = "BRN", NumericCode = "096" }},
        { "BO", new IsoCountry{Name = "Bolivia (Plurinational State of)", Alpha2Code = "BO", Alpha3Code = "BOL", NumericCode = "068" }},
        { "BQ", new IsoCountry{Name = "Bonaire, Sint Eustatius and Saba", Alpha2Code = "BQ", Alpha3Code = "BES", NumericCode = "535" }},
        { "BR", new IsoCountry{Name = "Brazil", Alpha2Code = "BR", Alpha3Code = "BRA", NumericCode = "076" }},
        { "BS", new IsoCountry{Name = "Bahamas (the)", Alpha2Code = "BS", Alpha3Code = "BHS", NumericCode = "044" }},
        { "BT", new IsoCountry{Name = "Bhutan", Alpha2Code = "BT", Alpha3Code = "BTN", NumericCode = "064" }},
        { "BV", new IsoCountry{Name = "Bouvet Island", Alpha2Code = "BV", Alpha3Code = "BVT", NumericCode = "074" }},
        { "BW", new IsoCountry{Name = "Botswana", Alpha2Code = "BW", Alpha3Code = "BWA", NumericCode = "072" }},
        { "BY", new IsoCountry{Name = "Belarus", Alpha2Code = "BY", Alpha3Code = "BLR", NumericCode = "112" }},
        { "BZ", new IsoCountry{Name = "Belize", Alpha2Code = "BZ", Alpha3Code = "BLZ", NumericCode = "084" }},
        { "CA", new IsoCountry{Name = "Canada", Alpha2Code = "CA", Alpha3Code = "CAN", NumericCode = "124" }},
        { "CC", new IsoCountry{Name = "Cocos (Keeling) Islands (the)", Alpha2Code = "CC", Alpha3Code = "CCK", NumericCode = "166"}},
        { "CD", new IsoCountry{Name = "Congo (the Democratic Republic of the)", Alpha2Code = "CD", Alpha3Code = "COD", NumericCode = "180"}},
        { "CF", new IsoCountry{Name = "Central African Republic (the)", Alpha2Code = "CF", Alpha3Code = "CAF", NumericCode = "140"}},
        { "CG", new IsoCountry{Name = "Congo (the)", Alpha2Code = "CG", Alpha3Code = "COG", NumericCode = "178"}},
        { "CH", new IsoCountry{Name = "Switzerland", Alpha2Code = "CH", Alpha3Code = "CHE", NumericCode = "756"}},
        { "CI", new IsoCountry{Name = "Côte d'Ivoire", Alpha2Code = "CI", Alpha3Code = "CIV", NumericCode = "384"}},
        { "CK", new IsoCountry{Name = "Cook Islands (the)", Alpha2Code = "CK", Alpha3Code = "COK", NumericCode = "184"}},
        { "CL", new IsoCountry{Name = "Chile", Alpha2Code = "CL", Alpha3Code = "CHL", NumericCode = "152"}},
        { "CM", new IsoCountry{Name = "Cameroon", Alpha2Code = "CM", Alpha3Code = "CMR", NumericCode = "120"}},
        { "CN", new IsoCountry{Name = "China", Alpha2Code = "CN", Alpha3Code = "CHN", NumericCode = "156"}},
        { "CO", new IsoCountry{Name = "Colombia", Alpha2Code = "CO", Alpha3Code = "COL", NumericCode = "170"}},
        { "CR", new IsoCountry{Name = "Costa Rica", Alpha2Code = "CR", Alpha3Code = "CRI", NumericCode = "188"}},
        { "CU", new IsoCountry{Name = "Cuba", Alpha2Code = "CU", Alpha3Code = "CUB", NumericCode = "192"}},
        { "CV", new IsoCountry{Name = "Cabo Verde", Alpha2Code = "CV", Alpha3Code = "CPV", NumericCode = "132"}},
        { "CW", new IsoCountry{Name = "Curaçao", Alpha2Code = "CW", Alpha3Code = "CUW", NumericCode = "531" }},
        { "CX", new IsoCountry{Name = "Christmas Island", Alpha2Code = "CX", Alpha3Code = "CXR", NumericCode = "162" }},
        { "CY", new IsoCountry{Name = "Cyprus", Alpha2Code = "CY", Alpha3Code = "CYP", NumericCode = "196" }},
        { "CZ", new IsoCountry{Name = "Czechia", Alpha2Code = "CZ", Alpha3Code = "CZE", NumericCode = "203" }},
        { "DE", new IsoCountry{Name = "Germany", Alpha2Code = "DE", Alpha3Code = "DEU", NumericCode = "276" }},
        { "DJ", new IsoCountry{Name = "Djibouti", Alpha2Code = "DJ", Alpha3Code = "DJI", NumericCode = "262" }},
        { "DK", new IsoCountry{Name = "Denmark", Alpha2Code = "DK", Alpha3Code = "DNK", NumericCode = "208" }},
        { "DM", new IsoCountry{Name = "Dominica", Alpha2Code = "DM", Alpha3Code = "DMA", NumericCode = "212" }},
        { "DO", new IsoCountry{Name = "Dominican Republic (the)", Alpha2Code = "DO", Alpha3Code = "DOM", NumericCode = "214" }},
        { "DZ", new IsoCountry{Name = "Algeria", Alpha2Code = "DZ", Alpha3Code = "DZA", NumericCode = "012" }},
        { "EC", new IsoCountry{Name = "Ecuador", Alpha2Code = "EC", Alpha3Code = "ECU", NumericCode = "218" }},
        { "EE", new IsoCountry{Name = "Estonia", Alpha2Code = "EE", Alpha3Code = "EST", NumericCode = "233" }},
        { "EG", new IsoCountry{Name = "Egypt", Alpha2Code = "EG", Alpha3Code = "EGY", NumericCode = "818" }},
        { "EH", new IsoCountry{Name = "Western Sahara", Alpha2Code = "EH", Alpha3Code = "ESH", NumericCode = "732" }},
        { "ER", new IsoCountry{Name = "Eritrea", Alpha2Code = "ER", Alpha3Code = "ERI", NumericCode = "232" }},
        { "ES", new IsoCountry{Name = "Spain", Alpha2Code = "ES", Alpha3Code = "ESP", NumericCode = "724" }},
        { "ET", new IsoCountry{Name = "Ethiopia", Alpha2Code = "ET", Alpha3Code = "ETH", NumericCode = "231" }},
        { "FI", new IsoCountry{Name = "Finland", Alpha2Code = "FI", Alpha3Code = "FIN", NumericCode = "246" }},
        { "FJ", new IsoCountry{Name = "Fiji", Alpha2Code = "FJ", Alpha3Code = "FJI", NumericCode = "242" }},
        { "FK", new IsoCountry{Name = "Falkland Islands (the) [Malvinas]", Alpha2Code = "FK", Alpha3Code = "FLK", NumericCode = "238" }},
        { "FM", new IsoCountry{Name = "Micronesia (Federated States of)", Alpha2Code = "FM", Alpha3Code = "FSM", NumericCode = "583" }},
        { "FO", new IsoCountry{Name = "Faroe Islands (the)", Alpha2Code = "FO", Alpha3Code = "FRO", NumericCode = "234" }},
        { "FR", new IsoCountry{Name = "France", Alpha2Code = "FR", Alpha3Code = "FRA", NumericCode = "250" }},
        { "GA", new IsoCountry{Name = "Gabon", Alpha2Code = "GA", Alpha3Code = "GAB", NumericCode = "266" }},
        { "GB", new IsoCountry{Name = "United Kingdom of Great Britain and Northern Ireland (the)", Alpha2Code = "GB", Alpha3Code = "GBR", NumericCode = "826" }},
        { "GD", new IsoCountry{Name = "Grenada", Alpha2Code = "GD", Alpha3Code = "GRD", NumericCode = "308" }},
        { "GE", new IsoCountry{Name = "Georgia", Alpha2Code = "GE", Alpha3Code = "GEO", NumericCode = "268" }},
        { "GF", new IsoCountry{Name = "French Guiana", Alpha2Code = "GF", Alpha3Code = "GUF", NumericCode = "254" }},
        { "GG", new IsoCountry{Name = "Guernsey", Alpha2Code = "GG", Alpha3Code = "GGY", NumericCode = "831" }},
        { "GH", new IsoCountry{Name = "Ghana", Alpha2Code = "GH", Alpha3Code = "GHA", NumericCode = "288" }},
        { "GI", new IsoCountry{Name = "Gibraltar", Alpha2Code = "GI", Alpha3Code = "GIB", NumericCode = "292" }},
        { "GL", new IsoCountry{Name = "Greenland", Alpha2Code = "GL", Alpha3Code = "GRL", NumericCode = "304" }},
        { "GM", new IsoCountry{Name = "Gambia (the)", Alpha2Code = "GM", Alpha3Code = "GMB", NumericCode = "270" }},
        { "GN", new IsoCountry{Name = "Guinea", Alpha2Code = "GN", Alpha3Code = "GIN", NumericCode = "324" }},
        { "GP", new IsoCountry{Name = "Guadeloupe", Alpha2Code = "GP", Alpha3Code = "GLP", NumericCode = "312" }},
        { "GQ", new IsoCountry{Name = "Equatorial Guinea", Alpha2Code = "GQ", Alpha3Code = "GNQ", NumericCode = "226" }},
        { "GR", new IsoCountry{Name = "Greece", Alpha2Code = "GR", Alpha3Code = "GRC", NumericCode = "300" }},
        { "GS", new IsoCountry{Name = "South Georgia and the South Sandwich Islands", Alpha2Code = "GS", Alpha3Code = "SGS", NumericCode = "239" }},
        { "GT", new IsoCountry{Name = "Guatemala", Alpha2Code = "GT", Alpha3Code = "GTM", NumericCode = "320" }},
        { "GU", new IsoCountry{Name = "Guam", Alpha2Code = "GU", Alpha3Code = "GUM", NumericCode = "316" }},
        { "GW", new IsoCountry{Name = "Guinea-Bissau", Alpha2Code = "GW", Alpha3Code = "GNB", NumericCode = "624" }},
        { "GY", new IsoCountry{Name = "Guyana", Alpha2Code = "GY", Alpha3Code = "GUY", NumericCode = "328" }},
        { "HK", new IsoCountry{Name = "Hong Kong", Alpha2Code = "HK", Alpha3Code = "HKG", NumericCode = "344" }},
        { "HM", new IsoCountry{Name = "Heard Island and McDonald Islands", Alpha2Code = "HM", Alpha3Code = "HMD", NumericCode = "334" }},
        { "HN", new IsoCountry{Name = "Honduras", Alpha2Code = "HN", Alpha3Code = "HND", NumericCode = "340" }},
        { "HR", new IsoCountry{Name = "Croatia", Alpha2Code = "HR", Alpha3Code = "HRV", NumericCode = "191" }},
        { "HT", new IsoCountry{Name = "Haiti", Alpha2Code = "HT", Alpha3Code = "HTI", NumericCode = "332" }},
        { "HU", new IsoCountry{Name = "Hungary", Alpha2Code = "HU", Alpha3Code = "HUN", NumericCode = "348" }},
        { "ID", new IsoCountry{Name = "Indonesia", Alpha2Code = "ID", Alpha3Code = "IDN", NumericCode = "360" }},
        { "IE", new IsoCountry{Name = "Ireland", Alpha2Code = "IE", Alpha3Code = "IRL", NumericCode = "372" }},
        { "IL", new IsoCountry{Name = "Israil", Alpha2Code = "IL", Alpha3Code = "ISR", NumericCode = "376" }},
        { "IM", new IsoCountry{Name = "Isle of Man", Alpha2Code = "IM", Alpha3Code = "IMN", NumericCode = "833" }},
        { "IN", new IsoCountry{Name = "India", Alpha2Code = "IN", Alpha3Code = "IND", NumericCode = "356" }},
        { "IO", new IsoCountry{Name = "British Indian Ocean Territory (the)", Alpha2Code = "IO", Alpha3Code = "IOT", NumericCode = "086" }},
        { "IQ", new IsoCountry{Name = "Iraq", Alpha2Code = "IQ", Alpha3Code = "IRQ", NumericCode = "368" }},
        { "IR", new IsoCountry{Name = "Iran (Islamic Republic of)", Alpha2Code = "IR", Alpha3Code = "IRN", NumericCode = "364" }},
        { "IS", new IsoCountry{Name = "Iceland", Alpha2Code = "IS", Alpha3Code = "ISL", NumericCode = "352" }},
        { "IT", new IsoCountry{Name = "Italy", Alpha2Code = "IT", Alpha3Code = "ITA", NumericCode = "380" }},
        { "JE", new IsoCountry{Name = "Jersey", Alpha2Code = "JE", Alpha3Code = "JEY", NumericCode = "832" }},
        { "JM", new IsoCountry{Name = "Jamaica", Alpha2Code = "JM", Alpha3Code = "JAM", NumericCode = "388" }},
        { "JO", new IsoCountry{Name = "Jordan", Alpha2Code = "JO", Alpha3Code = "JOR", NumericCode = "400" }},
        { "JP", new IsoCountry{Name = "Japan", Alpha2Code = "JP", Alpha3Code = "JPN", NumericCode = "392" }},
        { "KE", new IsoCountry{Name = "Kenya", Alpha2Code = "KE", Alpha3Code = "KEN", NumericCode = "404" }},
        { "KG", new IsoCountry{Name = "Kyrgyzstan", Alpha2Code = "KG", Alpha3Code = "KGZ", NumericCode = "417" }},
        { "KH", new IsoCountry{Name = "Cambodia", Alpha2Code = "KH", Alpha3Code = "KHM", NumericCode = "116" }},
        { "KI", new IsoCountry{Name = "Kiribati", Alpha2Code = "KI", Alpha3Code = "KIR", NumericCode ="296" }},
        { "KM", new IsoCountry{Name = "Comoros (the)", Alpha2Code = "KM", Alpha3Code = "COM", NumericCode = "174" }},
        { "KN", new IsoCountry{Name = "Saint Kitts and Nevis", Alpha2Code = "KN", Alpha3Code = "KNA", NumericCode = "659" }},
        { "KP", new IsoCountry{Name = "Korea (the Democratic People's Republic of)", Alpha2Code = "KP", Alpha3Code = "PRK", NumericCode = "408" }},
        { "KR", new IsoCountry{Name = "Korea (the Republic of)", Alpha2Code = "KR", Alpha3Code = "KOR", NumericCode = "410" }},
        { "KW", new IsoCountry{Name = "Kuwait", Alpha2Code = "KW", Alpha3Code = "KWT", NumericCode = "414" }},
        { "KY", new IsoCountry{Name = "Cayman Islands (the)", Alpha2Code = "KY", Alpha3Code = "CYM", NumericCode = "136" }},
        { "KZ", new IsoCountry{Name = "Kazakhstan", Alpha2Code = "KZ", Alpha3Code = "KAZ", NumericCode = "398" }},
        { "LA", new IsoCountry{Name = "Lao People's Democratic Republic (the)", Alpha2Code = "LA", Alpha3Code = "LAO", NumericCode = "418" }},
        { "LB", new IsoCountry{Name = "Lebanon", Alpha2Code = "LB", Alpha3Code = "LBN", NumericCode = "422" }},
        { "LC", new IsoCountry{Name = "Saint Lucia", Alpha2Code = "LC", Alpha3Code = "LCA", NumericCode = "662" }},
        { "LI", new IsoCountry{Name = "Liechtenstein", Alpha2Code = "LI", Alpha3Code = "LIE", NumericCode = "438" }},
        { "LK", new IsoCountry{Name = "Sri Lanka", Alpha2Code = "LK", Alpha3Code = "LKA", NumericCode = "144" }},
        { "LR", new IsoCountry{Name = "Liberia", Alpha2Code = "LR", Alpha3Code = "LBR", NumericCode = "430" }},
        { "LS", new IsoCountry{Name = "Lesotho", Alpha2Code = "LS", Alpha3Code = "LSO", NumericCode = "426" }},
        { "LT", new IsoCountry{Name = "Lithuania", Alpha2Code = "LT", Alpha3Code = "LTU", NumericCode = "440" }},
        { "LU", new IsoCountry{Name = "Luxembourg", Alpha2Code = "LU", Alpha3Code = "LUX", NumericCode = "442" }},
        { "LV", new IsoCountry{Name = "Latvia", Alpha2Code = "LV", Alpha3Code = "LVA", NumericCode = "428" }},
        { "LY", new IsoCountry{Name = "Libya", Alpha2Code = "LY", Alpha3Code = "LBY", NumericCode = "434" }},
        { "MA", new IsoCountry{Name = "Morocco", Alpha2Code = "MA", Alpha3Code = "MAR", NumericCode = "504" }},
        { "MC", new IsoCountry{Name = "Monaco", Alpha2Code = "MC", Alpha3Code = "MCO", NumericCode = "492" }},
        { "MD", new IsoCountry{Name = "Moldova (the Republic of)", Alpha2Code = "MD", Alpha3Code = "MDA", NumericCode = "498" }},
        { "ME", new IsoCountry{Name = "Montenegro", Alpha2Code = "ME", Alpha3Code = "MNE", NumericCode = "499" }},
        { "MF", new IsoCountry{Name = "Saint Martin (French part)", Alpha2Code = "MF", Alpha3Code = "MAF", NumericCode = "663" }},
        { "MG", new IsoCountry{Name = "Madagascar", Alpha2Code = "MG", Alpha3Code = "MDG", NumericCode = "450" }},
        { "MH", new IsoCountry{Name = "Marshall Islands (the)", Alpha2Code = "MH", Alpha3Code = "MHL", NumericCode = "584" }},
        { "MK", new IsoCountry{Name = "Republic of North Macedonia", Alpha2Code = "MK", Alpha3Code = "MKD", NumericCode = "807" }},
        { "ML", new IsoCountry{Name = "Mali", Alpha2Code = "ML", Alpha3Code = "MLI", NumericCode = "466" }},
        { "MM", new IsoCountry{Name = "Myanmar", Alpha2Code = "MM", Alpha3Code = "MMR", NumericCode = "104" }},
        { "MN", new IsoCountry{Name = "Mongolia", Alpha2Code = "MN", Alpha3Code = "MNG", NumericCode = "496" }},
        { "MO", new IsoCountry{Name = "Macao", Alpha2Code = "MO", Alpha3Code = "MAC", NumericCode = "446" }},
        { "MP", new IsoCountry{Name = "Northern Mariana Islands (the)", Alpha2Code = "MP", Alpha3Code = "MNP", NumericCode = "580" }},
        { "MQ", new IsoCountry{Name = "Martinique", Alpha2Code = "MQ", Alpha3Code = "MTQ", NumericCode = "474" }},
        { "MR", new IsoCountry{Name = "Mauritania", Alpha2Code = "MR", Alpha3Code = "MRT", NumericCode = "478" }},
        { "MS", new IsoCountry{Name = "Montserrat", Alpha2Code = "MS", Alpha3Code = "MSR", NumericCode = "500" }},
        { "MT", new IsoCountry{Name = "Malta", Alpha2Code = "MT", Alpha3Code = "MLT", NumericCode = "470" }},
        { "MU", new IsoCountry{Name = "Mauritius", Alpha2Code = "MU", Alpha3Code = "MUS", NumericCode = "480" }},
        { "MV", new IsoCountry{Name = "Maldives", Alpha2Code = "MV", Alpha3Code = "MDV", NumericCode = "462" }},
        { "MW", new IsoCountry{Name = "Malawi", Alpha2Code = "MW", Alpha3Code = "MWI", NumericCode = "454" }},
        { "MX", new IsoCountry{Name = "Mexico", Alpha2Code = "MX", Alpha3Code = "MEX", NumericCode = "484" }},
        { "MY", new IsoCountry{Name = "Malaysia", Alpha2Code = "MY", Alpha3Code = "MYS", NumericCode = "458" }},
        { "MZ", new IsoCountry{Name = "Mozambique", Alpha2Code = "MZ", Alpha3Code = "MOZ", NumericCode = "508" }},
        { "NA", new IsoCountry{Name = "Namibia", Alpha2Code = "NA", Alpha3Code = "NAM", NumericCode = "516" }},
        { "NC", new IsoCountry{Name = "New Caledonia", Alpha2Code = "NC", Alpha3Code = "NCL", NumericCode = "540" }},
        { "NE", new IsoCountry{Name = "Niger (the)", Alpha2Code = "NE", Alpha3Code = "NER", NumericCode = "562" }},
        { "NF", new IsoCountry{Name = "Norfolk Island", Alpha2Code = "NF", Alpha3Code = "NFK", NumericCode = "574" }},
        { "NG", new IsoCountry{Name = "Nigeria", Alpha2Code = "NG", Alpha3Code = "NGA", NumericCode = "566" }},
        { "NI", new IsoCountry{Name = "Nicaragua", Alpha2Code = "NI", Alpha3Code = "NIC", NumericCode = "558" }},
        { "NL", new IsoCountry{Name = "Netherlands (the)", Alpha2Code = "NL", Alpha3Code = "NLD", NumericCode = "528" }},
        { "NO", new IsoCountry{Name = "Norway", Alpha2Code = "NO", Alpha3Code = "NOR", NumericCode = "578" }},
        { "NP", new IsoCountry{Name = "Nepal", Alpha2Code = "NP", Alpha3Code = "NPL", NumericCode = "524" }},
        { "NR", new IsoCountry{Name = "Nauru", Alpha2Code = "NR", Alpha3Code = "NRU", NumericCode = "520" }},
        { "NU", new IsoCountry{Name = "Niue", Alpha2Code = "NU", Alpha3Code = "NIU", NumericCode = "570" }},
        { "NZ", new IsoCountry{Name = "New Zealand", Alpha2Code = "NZ", Alpha3Code = "NZL", NumericCode = "554" }},
        { "OM", new IsoCountry{Name = "Oman", Alpha2Code = "OM", Alpha3Code = "OMN", NumericCode = "512" }},
        { "PA", new IsoCountry{Name = "Panama", Alpha2Code = "PA", Alpha3Code = "PAN", NumericCode = "591" }},
        { "PE", new IsoCountry{Name = "Peru", Alpha2Code = "PE", Alpha3Code = "PER", NumericCode = "604" }},
        { "PF", new IsoCountry{Name = "French Polynesia", Alpha2Code = "PF", Alpha3Code = "PYF", NumericCode = "258" }},
        { "PG", new IsoCountry{Name = "Papua New Guinea", Alpha2Code = "PG", Alpha3Code = "PNG", NumericCode = "598" }},
        { "PH", new IsoCountry{Name = "Philippines (the)", Alpha2Code = "PH", Alpha3Code = "PHL", NumericCode = "608" }},
        { "PK", new IsoCountry{Name = "Pakistan", Alpha2Code = "PK", Alpha3Code = "PAK", NumericCode = "586" }},
        { "PL", new IsoCountry{Name = "Poland", Alpha2Code = "PL", Alpha3Code = "POL", NumericCode = "616" }},
        { "PM", new IsoCountry{Name = "Saint Pierre and Miquelon", Alpha2Code = "PM", Alpha3Code = "SPM", NumericCode = "666" }},
        { "PN", new IsoCountry{Name = "Pitcairn", Alpha2Code = "PN", Alpha3Code = "PCN", NumericCode = "612" }},
        { "PR", new IsoCountry{Name = "Puerto Rico", Alpha2Code = "PR", Alpha3Code = "PRI", NumericCode = "630" }},
        { "PS", new IsoCountry{Name = "Palestine, State of", Alpha2Code = "PS", Alpha3Code = "PSE", NumericCode ="275" }},
        { "PT", new IsoCountry{Name = "Portugal", Alpha2Code = "PT", Alpha3Code = "PRT", NumericCode = "620"}},
        { "PW", new IsoCountry{Name = "Palau", Alpha2Code = "PW", Alpha3Code = "PLW", NumericCode = "585" }},
        { "PY", new IsoCountry{Name = "Paraguay", Alpha2Code = "PY", Alpha3Code = "PRY", NumericCode = "600"}},
        { "QA", new IsoCountry{Name = "Qatar", Alpha2Code = "QA", Alpha3Code = "QAT", NumericCode = "634"}},
        { "RE", new IsoCountry{Name = "Réunion", Alpha2Code = "RE", Alpha3Code = "REU", NumericCode = "638"}},
        { "RO", new IsoCountry{Name = "Romania", Alpha2Code = "RO", Alpha3Code = "ROU", NumericCode = "642"}},
        { "RS", new IsoCountry{Name = "Serbia", Alpha2Code = "RS", Alpha3Code = "SRB", NumericCode = "688"}},
        { "RU", new IsoCountry{Name = "Russian Federation (the)", Alpha2Code = "RU", Alpha3Code = "RUS", NumericCode = "643"}},
        { "RW", new IsoCountry{Name = "Rwanda", Alpha2Code = "RW", Alpha3Code = "RWA", NumericCode = "646"}},
        { "SA", new IsoCountry{Name = "Saudi Arabia", Alpha2Code = "SA", Alpha3Code = "SAU", NumericCode = "682"}},
        { "SB", new IsoCountry{Name = "Solomon Islands", Alpha2Code = "SB", Alpha3Code = "SLB", NumericCode = "090"}},
        { "SC", new IsoCountry{Name = "Seychelles", Alpha2Code = "SC", Alpha3Code = "SYC", NumericCode = "690"}},
        { "SD", new IsoCountry{Name = "Sudan (the)", Alpha2Code = "SD", Alpha3Code = "SDN", NumericCode = "729"}},
        { "SE", new IsoCountry{Name = "Sweden", Alpha2Code = "SE", Alpha3Code = "SWE", NumericCode = "752"}},
        { "SG", new IsoCountry{Name = "Singapore", Alpha2Code = "SG", Alpha3Code = "SGP", NumericCode = "702"}},
        { "SH", new IsoCountry{Name = "Saint Helena, Ascension and Tristan da Cunha", Alpha2Code = "SH", Alpha3Code = "SHN", NumericCode = "654"}},
        { "SI", new IsoCountry{Name = "Slovenia", Alpha2Code = "SI", Alpha3Code = "SVN", NumericCode = "705"}},
        { "SJ", new IsoCountry{Name = "Svalbard and Jan Mayen", Alpha2Code = "SJ", Alpha3Code = "SJM", NumericCode = "744"}},
        { "SK", new IsoCountry{Name = "Slovakia", Alpha2Code = "SK", Alpha3Code = "SVK", NumericCode = "703"}},
        { "SL", new IsoCountry{Name = "Sierra Leone", Alpha2Code = "SL", Alpha3Code = "SLE", NumericCode = "694"}},
        { "SM", new IsoCountry{Name = "San Marino", Alpha2Code = "SM", Alpha3Code = "SMR", NumericCode = "674"}},
        { "SN", new IsoCountry{Name = "Senegal", Alpha2Code = "SN", Alpha3Code = "SEN", NumericCode = "686"}},
        { "SO", new IsoCountry{Name = "Somalia", Alpha2Code = "SO", Alpha3Code = "SOM", NumericCode = "706"}},
        { "SR", new IsoCountry{Name = "Suriname", Alpha2Code = "SR", Alpha3Code = "SUR", NumericCode = "740"}},
        { "SS", new IsoCountry{Name = "South Sudan", Alpha2Code = "SS", Alpha3Code = "SSD", NumericCode = "728"}},
        { "ST", new IsoCountry{Name = "Sao Tome and Principe", Alpha2Code = "ST", Alpha3Code = "STP", NumericCode = "678"}},
        { "SV", new IsoCountry{Name = "El Salvador", Alpha2Code = "SV", Alpha3Code = "SLV", NumericCode = "222"}},
        { "SX", new IsoCountry{Name = "Sint Maarten (Dutch part)", Alpha2Code = "SX", Alpha3Code = "SXM", NumericCode = "534"}},
        { "SY", new IsoCountry{Name = "Syrian Arab Republic", Alpha2Code = "SY", Alpha3Code = "SYR", NumericCode = "760"}},
        { "SZ", new IsoCountry{Name = "Eswatini", Alpha2Code = "SZ", Alpha3Code = "SWZ", NumericCode = "748"}},
        { "TC", new IsoCountry{Name = "Turks and Caicos Islands (the)", Alpha2Code = "TC", Alpha3Code = "TCA", NumericCode = "796"}},
        { "TD", new IsoCountry{Name = "Chad", Alpha2Code = "TD", Alpha3Code = "TCD", NumericCode = "148"}},
        { "TF", new IsoCountry{Name = "French Southern Territories (the)", Alpha2Code = "TF", Alpha3Code = "ATF", NumericCode = "260"}},
        { "TG", new IsoCountry{Name = "Togo", Alpha2Code = "TG", Alpha3Code = "TGO", NumericCode = "768"}},
        { "TH", new IsoCountry{Name = "Thailand", Alpha2Code = "TH", Alpha3Code = "THA", NumericCode = "764"}},
        { "TJ", new IsoCountry{Name = "Tajikistan", Alpha2Code = "TJ", Alpha3Code = "TJK", NumericCode = "762"}},
        { "TK", new IsoCountry{Name = "Tokelau", Alpha2Code = "TK", Alpha3Code = "TKL", NumericCode = "772"}},
        { "TL", new IsoCountry{Name = "Timor-Leste", Alpha2Code = "TL", Alpha3Code = "TLS", NumericCode = "626"}},
        { "TM", new IsoCountry{Name = "Turkmenistan", Alpha2Code = "TM", Alpha3Code = "TKM", NumericCode = "795"}},
        { "TN", new IsoCountry{Name = "Tunisia", Alpha2Code = "TN", Alpha3Code = "TUN", NumericCode = "788"}},
        { "TO", new IsoCountry{Name = "Tonga", Alpha2Code = "TO", Alpha3Code = "TON", NumericCode = "776"}},
        { "TR", new IsoCountry{Name = "Turkey", Alpha2Code = "TR", Alpha3Code = "TUR", NumericCode = "792"}},
        { "TT", new IsoCountry{Name = "Trinidad and Tobago", Alpha2Code = "TT", Alpha3Code = "TTO", NumericCode = "780"}},
        { "TV", new IsoCountry{Name = "Tuvalu", Alpha2Code = "TV", Alpha3Code = "TUV", NumericCode = "798"}},
        { "TW", new IsoCountry{Name = "Taiwan (Province of China)", Alpha2Code = "TW", Alpha3Code = "TWN", NumericCode = "158"}},
        { "TZ", new IsoCountry{Name = "Tanzania, United Republic of", Alpha2Code = "TZ", Alpha3Code = "TZA", NumericCode = "834"}},
        { "UA", new IsoCountry{Name = "Ukraine", Alpha2Code = "UA", Alpha3Code = "UKR", NumericCode = "804"}},
        { "UG", new IsoCountry{Name = "Uganda", Alpha2Code = "UG", Alpha3Code = "UGA", NumericCode = "800"}},
        { "UM", new IsoCountry{Name = "United States Minor Outlying Islands (the)", Alpha2Code = "UM", Alpha3Code = "UMI", NumericCode = "581"}},
        { "US", new IsoCountry{Name = "United States of America (the)", Alpha2Code = "US", Alpha3Code = "USA", NumericCode = "840"}},
        { "UY", new IsoCountry{Name = "Uruguay", Alpha2Code = "UY", Alpha3Code = "URY", NumericCode = "858"}},
        { "UZ", new IsoCountry{Name = "Uzbekistan", Alpha2Code = "UZ", Alpha3Code = "UZB", NumericCode = "860"}},
        { "VA", new IsoCountry{Name = "Holy See (the)", Alpha2Code = "VA", Alpha3Code = "VAT", NumericCode = "336"}},
        { "VC", new IsoCountry{Name = "Saint Vincent and the Grenadines", Alpha2Code = "VC", Alpha3Code = "VCT", NumericCode = "670"}},
        { "VE", new IsoCountry{Name = "Venezuela (Bolivarian Republic of)", Alpha2Code = "VE", Alpha3Code = "VEN", NumericCode = "862"}},
        { "VG", new IsoCountry{Name = "Virgin Islands (British)", Alpha2Code = "VG", Alpha3Code = "VGB", NumericCode = "092"}},
        { "VI", new IsoCountry{Name = "Virgin Islands (U.S.)", Alpha2Code = "VI", Alpha3Code = "VIR", NumericCode = "850"}},
        { "VN", new IsoCountry{Name = "Viet Nam", Alpha2Code = "VN", Alpha3Code = "VNM", NumericCode = "704"}},
        { "VU", new IsoCountry{Name = "Vanuatu", Alpha2Code = "VU", Alpha3Code = "VUT", NumericCode = "548"}},
        { "WF", new IsoCountry{Name = "Wallis and Futuna", Alpha2Code = "WF", Alpha3Code = "WLF", NumericCode = "876"}},
        { "WS", new IsoCountry{Name = "Samoa", Alpha2Code = "WS", Alpha3Code = "WSM", NumericCode = "882"}},
        { "YE", new IsoCountry{Name = "Yemen", Alpha2Code = "YE", Alpha3Code = "YEM", NumericCode = "887"}},
        { "YT", new IsoCountry{Name = "Mayotte", Alpha2Code = "YT", Alpha3Code = "MYT", NumericCode = "175"}},
        { "ZA", new IsoCountry{Name = "South Africa", Alpha2Code = "ZA", Alpha3Code = "ZAF", NumericCode = "710"}},
        { "ZM", new IsoCountry{Name = "Zambia", Alpha2Code = "ZM", Alpha3Code = "ZMB", NumericCode = "894"}},
        { "ZW", new IsoCountry{Name = "Zimbabwe", Alpha2Code = "ZW", Alpha3Code = "ZWE", NumericCode = "716" }}
    });
}

public class IsoCountry
{
    public string Name { get; set; }
    public string Alpha2Code { get; set; }
    public string Alpha3Code { get; set; }
    public string NumericCode { get; set; }

}
/*
Andorra	AD	AND	020
United Arab Emirates (the)	AE	ARE	784
Afghanistan	AF	AFG	004
Antigua and Barbuda	AG	ATG	028
Anguilla	AI	AIA	660
Albania	AL	ALB	008
Armenia	AM	ARM	051
Angola	AO	AGO	024
Antarctica	AQ	ATA	010
Argentina	AR	ARG	032
American Samoa	AS	ASM	016
Austria	AT	AUT	040
Australia	AU	AUS	036
Aruba	AW	ABW	533
Åland Islands	AX	ALA	248
Azerbaijan	AZ	AZE	031
Bosnia and Herzegovina	BA	BIH	070
Barbados	BB	BRB	052
Bangladesh	BD	BGD	050
Belgium	BE	BEL	056
Burkina Faso	BF	BFA	854
Bulgaria	BG	BGR	100
Bahrain	BH	BHR	048
Burundi	BI	BDI	108
Benin	BJ	BEN	204
Saint Barthélemy	BL	BLM	652
Bermuda	BM	BMU	060
Brunei Darussalam	BN	BRN	096
Bolivia (Plurinational State of)	BO	BOL	068
Bonaire, Sint Eustatius and Saba	BQ	BES	535
Brazil	BR	BRA	076
Bahamas (the)	BS	BHS	044
Bhutan	BT	BTN	064
Bouvet Island	BV	BVT	074
Botswana	BW	BWA	072
Belarus	BY	BLR	112
Belize	BZ	BLZ	084
Canada	CA	CAN	124
Cocos (Keeling) Islands (the)	CC	CCK	166
Congo (the Democratic Republic of the)	CD	COD	180
Central African Republic (the)	CF	CAF	140
Congo (the)	CG	COG	178
Switzerland	CH	CHE	756
Côte d'Ivoire	CI	CIV	384
Cook Islands (the)	CK	COK	184
Chile	CL	CHL	152
Cameroon	CM	CMR	120
China	CN	CHN	156
Colombia	CO	COL	170
Costa Rica	CR	CRI	188
Cuba	CU	CUB	192
Cabo Verde	CV	CPV	132
Curaçao	CW	CUW	531
Christmas Island	CX	CXR	162
Cyprus	CY	CYP	196
Czechia	CZ	CZE	203
Germany	DE	DEU	276
Djibouti	DJ	DJI	262
Denmark	DK	DNK	208
Dominica	DM	DMA	212
Dominican Republic (the)	DO	DOM	214
Algeria	DZ	DZA	012
Ecuador	EC	ECU	218
Estonia	EE	EST	233
Egypt	EG	EGY	818
Western Sahara	EH	ESH	732
Eritrea	ER	ERI	232
Spain	ES	ESP	724
Ethiopia	ET	ETH	231
Finland	FI	FIN	246
Fiji	FJ	FJI	242
Falkland Islands (the) [Malvinas]	FK	FLK	238
Micronesia (Federated States of)	FM	FSM	583
Faroe Islands (the)	FO	FRO	234
France	FR	FRA	250
Gabon	GA	GAB	266
United Kingdom of Great Britain and Northern Ireland (the)	GB	GBR	826
Grenada	GD	GRD	308
Georgia	GE	GEO	268
French Guiana	GF	GUF	254
Guernsey	GG	GGY	831
Ghana	GH	GHA	288
Gibraltar	GI	GIB	292
Greenland	GL	GRL	304
Gambia (the)	GM	GMB	270
Guinea	GN	GIN	324
Guadeloupe	GP	GLP	312
Equatorial Guinea	GQ	GNQ	226
Greece	GR	GRC	300
South Georgia and the South Sandwich Islands	GS	SGS	239
Guatemala	GT	GTM	320
Guam	GU	GUM	316
Guinea-Bissau	GW	GNB	624
Guyana	GY	GUY	328
Hong Kong	HK	HKG	344
Heard Island and McDonald Islands	HM	HMD	334
Honduras	HN	HND	340
Croatia	HR	HRV	191
Haiti	HT	HTI	332
Hungary	HU	HUN	348
Indonesia	ID	IDN	360
Ireland	IE	IRL	372
Israel	IL	ISR	376
Isle of Man	IM	IMN	833
India	IN	IND	356
British Indian Ocean Territory (the)	IO	IOT	086
Iraq	IQ	IRQ	368
Iran (Islamic Republic of)	IR	IRN	364
Iceland	IS	ISL	352
Italy	IT	ITA	380
Jersey	JE	JEY	832
Jamaica	JM	JAM	388
Jordan	JO	JOR	400
Japan	JP	JPN	392
Kenya	KE	KEN	404
Kyrgyzstan	KG	KGZ	417
Cambodia	KH	KHM	116
Kiribati	KI	KIR	296
Comoros (the)	KM	COM	174
Saint Kitts and Nevis	KN	KNA	659
Korea (the Democratic People's Republic of)	KP	PRK	408
Korea (the Republic of)	KR	KOR	410
Kuwait	KW	KWT	414
Cayman Islands (the)	KY	CYM	136
Kazakhstan	KZ	KAZ	398
Lao People's Democratic Republic (the)	LA	LAO	418
Lebanon	LB	LBN	422
Saint Lucia	LC	LCA	662
Liechtenstein	LI	LIE	438
Sri Lanka	LK	LKA	144
Liberia	LR	LBR	430
Lesotho	LS	LSO	426
Lithuania	LT	LTU	440
Luxembourg	LU	LUX	442
Latvia	LV	LVA	428
Libya	LY	LBY	434
Morocco	MA	MAR	504
Monaco	MC	MCO	492
Moldova (the Republic of)	MD	MDA	498
Montenegro	ME	MNE	499
Saint Martin (French part)	MF	MAF	663
Madagascar	MG	MDG	450
Marshall Islands (the)	MH	MHL	584
Republic of North Macedonia	MK	MKD	807
Mali	ML	MLI	466
Myanmar	MM	MMR	104
Mongolia	MN	MNG	496
Macao	MO	MAC	446
Northern Mariana Islands (the)	MP	MNP	580
Martinique	MQ	MTQ	474
Mauritania	MR	MRT	478
Montserrat	MS	MSR	500
Malta	MT	MLT	470
Mauritius	MU	MUS	480
Maldives	MV	MDV	462
Malawi	MW	MWI	454
Mexico	MX	MEX	484
Malaysia	MY	MYS	458
Mozambique	MZ	MOZ	508
Namibia	NA	NAM	516
New Caledonia	NC	NCL	540
Niger (the)	NE	NER	562
Norfolk Island	NF	NFK	574
Nigeria	NG	NGA	566
Nicaragua	NI	NIC	558
Netherlands (the)	NL	NLD	528
Norway	NO	NOR	578
Nepal	NP	NPL	524
Nauru	NR	NRU	520
Niue	NU	NIU	570
New Zealand	NZ	NZL	554
Oman	OM	OMN	512
Panama	PA	PAN	591
Peru	PE	PER	604
French Polynesia	PF	PYF	258
Papua New Guinea	PG	PNG	598
Philippines (the)	PH	PHL	608
Pakistan	PK	PAK	586
Poland	PL	POL	616
Saint Pierre and Miquelon	PM	SPM	666
Pitcairn	PN	PCN	612
Puerto Rico	PR	PRI	630
Palestine, State of	PS	PSE	275
Portugal	PT	PRT	620
Palau	PW	PLW	585
Paraguay	PY	PRY	600
Qatar	QA	QAT	634
Réunion	RE	REU	638
Romania	RO	ROU	642
Serbia	RS	SRB	688
Russian Federation (the)	RU	RUS	643
Rwanda	RW	RWA	646
Saudi Arabia	SA	SAU	682
Solomon Islands	SB	SLB	090
Seychelles	SC	SYC	690
Sudan (the)	SD	SDN	729
Sweden	SE	SWE	752
Singapore	SG	SGP	702
Saint Helena, Ascension and Tristan da Cunha	SH	SHN	654
Slovenia	SI	SVN	705
Svalbard and Jan Mayen	SJ	SJM	744
Slovakia	SK	SVK	703
Sierra Leone	SL	SLE	694
San Marino	SM	SMR	674
Senegal	SN	SEN	686
Somalia	SO	SOM	706
Suriname	SR	SUR	740
South Sudan	SS	SSD	728
Sao Tome and Principe	ST	STP	678
El Salvador	SV	SLV	222
Sint Maarten (Dutch part)	SX	SXM	534
Syrian Arab Republic	SY	SYR	760
Eswatini	SZ	SWZ	748
Turks and Caicos Islands (the)	TC	TCA	796
Chad	TD	TCD	148
French Southern Territories (the)	TF	ATF	260
Togo	TG	TGO	768
Thailand	TH	THA	764
Tajikistan	TJ	TJK	762
Tokelau	TK	TKL	772
Timor-Leste	TL	TLS	626
Turkmenistan	TM	TKM	795
Tunisia	TN	TUN	788
Tonga	TO	TON	776
Turkey	TR	TUR	792
Trinidad and Tobago	TT	TTO	780
Tuvalu	TV	TUV	798
Taiwan (Province of China)	TW	TWN	158
Tanzania, United Republic of	TZ	TZA	834
Ukraine	UA	UKR	804
Uganda	UG	UGA	800
United States Minor Outlying Islands (the)	UM	UMI	581
United States of America (the)	US	USA	840
Uruguay	UY	URY	858
Uzbekistan	UZ	UZB	860
Holy See (the)	VA	VAT	336
Saint Vincent and the Grenadines	VC	VCT	670
Venezuela (Bolivarian Republic of)	VE	VEN	862
Virgin Islands (British)	VG	VGB	092
Virgin Islands (U.S.)	VI	VIR	850
Viet Nam	VN	VNM	704
Vanuatu	VU	VUT	548
Wallis and Futuna	WF	WLF	876
Samoa	WS	WSM	882
Yemen	YE	YEM	887
Mayotte	YT	MYT	175
South Africa	ZA	ZAF	710
Zambia	ZM	ZMB	894
Zimbabwe	ZW	ZWE	716

*/