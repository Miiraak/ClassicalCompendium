﻿using System.Collections.Generic;
using System.Linq;

namespace ClassicalCompendium
{
    public class PresetLists
    {
        public class Time
        {
            /// <summary>
            /// A list of the months of the year.
            /// </summary>
            public static List<string> Months = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            /// <summary>
            /// A list of the days of the week.
            /// </summary>
            public static List<string> WeekDays = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            /// <summary>
            /// A list of the hours of the day.
            /// </summary>
            public static List<string> Hours = new List<string>
            {
                "12 PM",
                "1 AM",
                "2 AM",
                "3 AM",
                "4 AM",
                "5 AM",
                "6 AM",
                "7 AM",
                "8 AM",
                "9 AM",
                "10 AM",
                "11 AM",
                "12 AM",
                "1 PM",
                "2 PM",
                "3 PM",
                "4 PM",
                "5 PM",
                "6 PM",
                "7 PM",
                "8 PM",
                "9 PM",
                "10 PM",
                "11 PM"
            };
        }

        /// <summary>
        /// A tuple of the name of the country, the ISO 3166-1 alpha-2 code, the ISO 3166-1 alpha-3 code, and the ISO 3166-1 numeric code. Sorted alphabetically.
        /// </summary>
        public class Countries
        {
            public static List<(string, string, string, int)> CountryISO = new List<(string, string, string, int)>
            {
                ("Afghanistan", "AF", "AFG", 4),
                ("Åland Islands", "AX", "ALA", 248),
                ("Albania", "AL", "ALB", 8),
                ("Algeria", "DZ", "DZA", 12),
                ("American Samoa", "AS", "ASM", 16),
                ("Andorra", "AD", "AND", 20),
                ("Angola", "AO", "AGO", 24),
                ("Anguilla", "AI", "AIA", 660),
                ("Antarctica", "AQ", "ATA", 10),
                ("Antigua and Barbuda", "AG", "ATG", 28),
                ("Argentina", "AR", "ARG", 32),
                ("Armenia", "AM", "ARM", 51),
                ("Aruba", "AW", "ABW", 533),
                ("Australia", "AU", "AUS", 36),
                ("Austria", "AT", "AUT", 40),
                ("Azerbaijan", "AZ", "AZE", 31),
                ("Bahamas", "BS", "BHS", 44),
                ("Bahrain", "BH", "BHR", 48),
                ("Bangladesh", "BD", "BGD", 50),
                ("Barbados", "BB", "BRB", 52),
                ("Belarus", "BY", "BLR", 112),
                ("Belgium", "BE", "BEL", 56),
                ("Belize", "BZ", "BLZ", 84),
                ("Benin", "BJ", "BEN", 204),
                ("Bermuda", "BM", "BMU", 60),
                ("Bhutan", "BT", "BTN", 64),
                ("Bolivia (Plurinational State of)", "BO", "BOL", 68),
                ("Bonaire, Sint Eustatius and Saba", "BQ", "BES", 535),
                ("Bosnia and Herzegovina", "BA", "BIH", 70),
                ("Botswana", "BW", "BWA", 72),
                ("Bouvet Island", "BV", "BVT", 74),
                ("Brazil", "BR", "BRA", 76),
                ("British Indian Ocean Territory", "IO", "IOT", 86),
                ("Brunei Darussalam", "BN", "BRN", 96),
                ("Bulgaria", "BG", "BGR", 100),
                ("Burkina Faso", "BF", "BFA", 854),
                ("Burundi", "BI", "BDI", 108),
                ("Cabo Verde", "CV", "CPV", 132),
                ("Cambodia", "KH", "KHM", 116),
                ("Cameroon", "CM", "CMR", 120),
                ("Canada", "CA", "CAN", 124),
                ("Cayman Islands", "KY", "CYM", 136),
                ("Central African Republic", "CF", "CAF", 140),
                ("Chad", "TD", "TCD", 148),
                ("Chile", "CL", "CHL", 152),
                ("China", "CN", "CHN", 156),
                ("Christmas Island", "CX", "CXR", 162),
                ("Cocos (Keeling) Islands", "CC", "CCK", 166),
                ("Colombia", "CO", "COL", 170),
                ("Comoros", "KM", "COM", 174),
                ("Congo", "CG", "COG", 178),
                ("Congo, Democratic Republic of the", "CD", "COD", 180),
                ("Cook Islands", "CK", "COK", 184),
                ("Costa Rica", "CR", "CRI", 188),
                ("Côte d'Ivoire", "CI", "CIV", 384),
                ("Croatia", "HR", "HRV", 191),
                ("Cuba", "CU", "CUB", 192),
                ("Curaçao", "CW", "CUW", 531),
                ("Cyprus", "CY", "CYP", 196),
                ("Czechia", "CZ", "CZE", 203),
                ("Denmark", "DK", "DNK", 208),
                ("Djibouti", "DJ", "DJI", 262),
                ("Dominica", "DM", "DMA", 212),
                ("Dominican Republic", "DO", "DOM", 214),
                ("Ecuador", "EC", "ECU", 218),
                ("Egypt", "EG", "EGY", 818),
                ("El Salvador", "SV", "SLV", 222),
                ("Equatorial Guinea", "GQ", "GNQ", 226),
                ("Eritrea", "ER", "ERI", 232),
                ("Estonia", "EE", "EST", 233),
                ("Eswatini", "SZ", "SWZ", 748),
                ("Ethiopia", "ET", "ETH", 231),
                ("Falkland Islands (Malvinas)", "FK", "FLK", 238),
                ("Faroe Islands", "FO", "FRO", 234),
                ("Fiji", "FJ", "FJI", 242),
                ("Finland", "FI", "FIN", 246),
                ("France", "FR", "FRA", 250),
                ("French Guiana", "GF", "GUF", 254),
                ("French Polynesia", "PF", "PYF", 258),
                ("French Southern Territories", "TF", "ATF", 260),
                ("Gabon", "GA", "GAB", 266),
                ("Gambia", "GM", "GMB", 270),
                ("Georgia", "GE", "GEO", 268),
                ("Germany", "DE", "DEU", 276),
                ("Ghana", "GH", "GHA", 288),
                ("Gibraltar", "GI", "GIB", 292),
                ("Greece", "GR", "GRC", 300),
                ("Greenland", "GL", "GRL", 304),
                ("Grenada", "GD", "GRD", 308),
                ("Guadeloupe", "GP", "GLP", 312),
                ("Guam", "GU", "GUM", 316),
                ("Guatemala", "GT", "GTM", 320),
                ("Guernsey", "GG", "GGY", 831),
                ("Guinea", "GN", "GIN", 324),
                ("Guinea-Bissau", "GW", "GNB", 624),
                ("Guyana", "GY", "GUY", 328),
                ("Haiti", "HT", "HTI", 332),
                ("Heard Island and McDonald Islands", "HM", "HMD", 334),
                ("Holy See", "VA", "VAT", 336),
                ("Honduras", "HN", "HND", 340),
                ("Hong Kong", "HK", "HKG", 344),
                ("Hungary", "HU", "HUN", 348),
                ("Iceland", "IS", "ISL", 352),
                ("India", "IN", "IND", 356),
                ("Indonesia", "ID", "IDN", 360),
                ("Iran (Islamic Republic of)", "IR", "IRN", 364),
                ("Iraq", "IQ", "IRQ", 368),
                ("Ireland", "IE", "IRL", 372),
                ("Isle of Man", "IM", "IMN", 833),
                ("Israel", "IL", "ISR", 376),
                ("Italy", "IT", "ITA", 380),
                ("Jamaica", "JM", "JAM", 388),
                ("Japan", "JP", "JPN", 392),
                ("Jersey", "JE", "JEY", 832),
                ("Jordan", "JO", "JOR", 400),
                ("Kazakhstan", "KZ", "KAZ", 398),
                ("Kenya", "KE", "KEN", 404),
                ("Kiribati", "KI", "KIR", 296),
                ("Korea (Democratic People's Republic of)", "KP", "PRK", 408),
                ("Korea, Republic of", "KR", "KOR", 410),
                ("Kuwait", "KW", "KWT", 414),
                ("Kyrgyzstan", "KG", "KGZ", 417),
                ("Lao People's Democratic Republic", "LA", "LAO", 418),
                ("Latvia", "LV", "LVA", 428),
                ("Lebanon", "LB", "LBN", 422),
                ("Lesotho", "LS", "LSO", 426),
                ("Liberia", "LR", "LBR", 430),
                ("Libya", "LY", "LBY", 434),
                ("Liechtenstein", "LI", "LIE", 438),
                ("Lithuania", "LT", "LTU", 440),
                ("Luxembourg", "LU", "LUX", 442),
                ("Macao", "MO", "MAC", 446),
                ("Madagascar", "MG", "MDG", 450),
                ("Malawi", "MW", "MWI", 454),
                ("Malaysia", "MY", "MYS", 458),
                ("Maldives", "MV", "MDV", 462),
                ("Mali", "ML", "MLI", 466),
                ("Malta", "MT", "MLT", 470),
                ("Marshall Islands", "MH", "MHL", 584),
                ("Martinique", "MQ", "MTQ", 474),
                ("Mauritania", "MR", "MRT", 478),
                ("Mauritius", "MU", "MUS", 480),
                ("Mayotte", "YT", "MYT", 175),
                ("Mexico", "MX", "MEX", 484),
                ("Micronesia (Federated States of)", "FM", "FSM", 583),
                ("Moldova, Republic of", "MD", "MDA", 498),
                ("Monaco", "MC", "MCO", 492),
                ("Mongolia", "MN", "MNG", 496),
                ("Montenegro", "ME", "MNE", 499),
                ("Montserrat", "MS", "MSR", 500),
                ("Morocco", "MA", "MAR", 504),
                ("Mozambique", "MZ", "MOZ", 508),
                ("Myanmar", "MM", "MMR", 104),
                ("Namibia", "NA", "NAM", 516),
                ("Nauru", "NR", "NRU", 520),
                ("Nepal", "NP", "NPL", 524),
                ("Netherlands", "NL", "NLD", 528),
                ("New Caledonia", "NC", "NCL", 540),
                ("New Zealand", "NZ", "NZL", 554),
                ("Nicaragua", "NI", "NIC", 558),
                ("Niger", "NE", "NER", 562),
                ("Nigeria", "NG", "NGA", 566),
                ("Niue", "NU", "NIU", 570),
                ("Norfolk Island", "NF", "NFK", 574),
                ("North Macedonia", "MK", "MKD", 807),
                ("Northern Mariana Islands", "MP", "MNP", 580),
                ("Norway", "NO", "NOR", 578),
                ("Oman", "OM", "OMN", 512),
                ("Pakistan", "PK", "PAK", 586),
                ("Palau", "PW", "PLW", 585),
                ("Palestine", "PS", "PSE", 275),
                ("Panama", "PA", "PAN", 591),
                ("Papua New Guinea", "PG", "PNG", 598),
                ("Paraguay", "PY", "PRY", 600),
                ("Peru", "PE", "PER", 604),
                ("Philippines", "PH", "PHL", 608),
                ("Pitcairn", "PN", "PCN", 612),
                ("Poland", "PL", "POL", 616),
                ("Portugal", "PT", "PRT", 620),
                ("Puerto Rico", "PR", "PRI", 630),
                ("Qatar", "QA", "QAT", 634),
                ("Réunion", "RE", "REU", 638),
                ("Romania", "RO", "ROU", 642),
                ("Russian Federation", "RU", "RUS", 643),
                ("Rwanda", "RW", "RWA", 646),
                ("Saint Barthelemy", "BL", "BLM", 652),
                ("Saint Helena, Ascension and Tristan da Cunha", "SH", "SHN", 654),
                ("Saint Kitts and Nevis", "KN", "KNA", 659),
                ("Saint Lucia", "LC", "LCA", 662),
                ("Saint Martin (French part)", "MF", "MAF", 663),
                ("Saint Pierre and Miquelon", "PM", "SPM", 666),
                ("Saint Vincent and the Grenadines", "VC", "VCT", 670),
                ("Samoa", "WS", "WSM", 882),
                ("San Marino", "SM", "SMR", 674),
                ("Sao Tome and Principe", "ST", "STP", 678),
                ("Saudi Arabia", "SA", "SAU", 682),
                ("Senegal", "SN", "SEN", 686),
                ("Serbia", "RS", "SRB", 688),
                ("Seychelles", "SC", "SYC", 690),
                ("Sierra Leone", "SL", "SLE", 694),
                ("Singapore", "SG", "SGP", 702),
                ("Sint Maarten (Dutch part)", "SX", "SXM", 534),
                ("Slovakia", "SK", "SVK", 703),
                ("Slovenia", "SI", "SVN", 705),
                ("Solomon Islands", "SB", "SLB", 90),
                ("Somalia", "SO", "SOM", 706),
                ("South Africa", "ZA", "ZAF", 710),
                ("South Georgia and the South Sandwich Islands", "GS", "SGS", 239),
                ("South Sudan", "SS", "SSD", 728),
                ("Spain", "ES", "ESP", 724),
                ("Sri Lanka", "LK", "LKA", 144),
                ("Sudan", "SD", "SDN", 729),
                ("Suriname", "SR", "SUR", 740),
                ("Svalbard and Jan Mayen", "SJ", "SJM", 744),
                ("Sweden", "SE", "SWE", 752),
                ("Switzerland", "CH", "CHE", 756),
                ("Syrian Arab Republic", "SY", "SYR", 760),
                ("Taiwan", "TW", "TWN", 158),
                ("Tajikistan", "TJ", "TJK", 762),
                ("Tanzania, United Republic of", "TZ", "TZA", 834),
                ("Thailand", "TH", "THA", 764),
                ("Timor-Leste", "TL", "TLS", 626),
                ("Togo", "TG", "TGO", 768),
                ("Tokelau", "TK", "TKL", 772),
                ("Tonga", "TO", "TON", 776),
                ("Trinidad and Tobago", "TT", "TTO", 780),
                ("Tunisia", "TN", "TUN", 788),
                ("Turkey", "TR", "TUR", 792),
                ("Turkmenistan", "TM", "TKM", 795),
                ("Turks and Caicos Islands", "TC", "TCA", 796),
                ("Tuvalu", "TV", "TUV", 798),
                ("Uganda", "UG", "UGA", 800),
                ("Ukraine", "UA", "UKR", 804),
                ("United Arab Emirates", "AE", "ARE", 784),
                ("United Kingdom of Great Britain and Northern Ireland", "GB", "GBR", 826),
                ("United States of America", "US", "USA", 840),
                ("Uruguay", "UY", "URY", 858),
                ("Uzbekistan", "UZ", "UZB", 860),
                ("Vanuatu", "VU", "VUT", 548),
                ("Venezuela (Bolivarian Republic of)", "VE", "VEN", 862),
                ("Viet Nam", "VN", "VNM", 704),
                ("Virgin Islands (British)", "VG", "VGB", 92),
                ("Virgin Islands (U.S.)", "VI", "VIR", 850),
                ("Wallis and Futuna", "WF", "WLF", 876),
                ("Western Sahara", "EH", "ESH", 732),
                ("Yemen", "YE", "YEM", 887),
                ("Zambia", "ZM", "ZMB", 894),
                ("Zimbabwe", "ZW", "ZWE", 716)
            };

            /// <summary>
            /// A list of the most spoken languages in the world.
            /// </summary>
            public static List<string> MostUsedLangages = new List<string>
            {
                "English",
                "French",
                "Arabic",
                "Standard Chinese",
                "Spanish",
                "Persian",
                "German",
                "Russian",
                "Malay",
                "Portuguese"
            };

            /// <summary>
            /// A list of the official languages of the world sorted alphabetically.
            /// </summary>
            public static List<string> OfficialLanguages = new List<string>
            {
                "Abkhaz",
                "Afar",
                "Afrikaans",
                "Aja-Gbe",
                "Akan",
                "Albanian",
                "Amharic",
                "Anii",
                "Arabic",
                "Armenian",
                "Assamese",
                "Aymara",
                "Azerbaijani",
                "Balanta",
                "Bambara",
                "Bariba",
                "Basque",
                "Bassari",
                "Bedik",
                "Belarusian",
                "Bengali",
                "Berber",
                "Biali",
                "Bislama",
                "Boko",
                "Bomu",
                "Bosnian",
                "Bozo",
                "Buduma",
                "Bulgarian",
                "Burmese",
                "Cantonese",
                "Catalan",
                "Chinese (Mandarin)",
                "Chichewa",
                "Chirbawe",
                "Comorian",
                "Corsican",
                "Croatian",
                "Czech",
                "Dagaare",
                "Dagbani",
                "Dangme",
                "Danish",
                "Dari",
                "Dendi",
                "Dhivehi",
                "Dioula",
                "Dogon",
                "Dutch",
                "Dzongkha",
                "English",
                "Estonian",
                "Ewe-Gbe",
                "Faroese",
                "Fijian",
                "Filipino",
                "Finnish",
                "Fon-Gbe",
                "Foodo",
                "Formosan",
                "French",
                "Fula",
                "Ga",
                "Gàidhlig",
                "Gbe",
                "Gen-Gbe",
                "Georgian",
                "German",
                "Gonja",
                "Gourmanché",
                "Greek",
                "Guarani",
                "Gujarati",
                "Haitian Creole",
                "Hakka",
                "Hassaniya",
                "Hausa",
                "Hebrew",
                "Hindi",
                "Hiri Motu",
                "Hungarian",
                "Igbo",
                "Icelandic",
                "Indonesian",
                "Irish",
                "Italian",
                "Japanese",
                "Javanese",
                "Jola",
                "Kabye",
                "Kalanga",
                "Kannada",
                "Kanuri",
                "Kasem",
                "Kazakh",
                "Khmer",
                "Kinyarwanda",
                "Kirundi",
                "Kissi",
                "Koisan",
                "Korean",
                "Kpelle",
                "Kurdish",
                "Kyrgyz",
                "Lao",
                "Latin",
                "Latvian",
                "Lituanian",
                "Lukpa",
                "Luxembourgish",
                "Macedonian",
                "Malagasy",
                "Malay",
                "Malinke",
                "Maltese",
                "Mamara",
                "Manding",
                "Mandinka",
                "Mandjak",
                "Mankanya",
                "Manx Gaelic",
                "Maori",
                "Marshallese",
                "Mauritian Creole",
                "Mbelime",
                "Meitei",
                "Mongolian",
                "Montenegrin",
                "Mossi",
                "Nambya",
                "Nateni",
                "Nauruan",
                "Ndau",
                "Ndebele",
                "Nepali",
                "Noon",
                "Northern Sotho",
                "Norwegian",
                "Nzema",
                "Oniyan",
                "Oriya",
                "Oromo",
                "Ossetian",
                "Palauan",
                "Papiamento",
                "Pashto",
                "Persian",
                "Polish",
                "Portuguese",
                "Punjabi",
                "Quechua",
                "Romanian",
                "Romansch",
                "Russian",
                "Safen",
                "Samoa",
                "Sango",
                "Sena",
                "Scots",
                "Serbian",
                "Serer",
                "Seychellois Creole",
                "Shona",
                "Sinhala",
                "Slovak",
                "Slovene",
                "Somali",
                "Songhay-Zarma",
                "Soninke",
                "Sotho",
                "Spanish",
                "Susu",
                "Swahili",
                "Swati",
                "Swedish",
                "Syenara",
                "Taiwanese Hokkien",
                "Tajik",
                "Tagalog",
                "Tamasheq",
                "Tamil",
                "Tammari",
                "Tasawaq",
                "Tebu",
                "Telugu",
                "Tetum",
                "Thai",
                "Tigrinya",
                "Tok Pisin",
                "Toma",
                "Tonga",
                "Tongan",
                "Tsonga",
                "Tswana",
                "Turkish",
                "Turkmen",
                "Tuvaluan",
                "Ukrainian",
                "Urdu",
                "Uzbek",
                "Venda",
                "Vietnamese",
                "Waama",
                "Waci-Gbe",
                "Wamey",
                "Welsh",
                "Wolof",
                "Xhosa",
                "Xwela-Gbe",
                "Yobe",
                "Yom",
                "Yoruba",
                "Zulu"
            };
        }

        public class Chars
        {
            /// <summary>
            /// A dictionary of the reverse alphabet. AZ -> ZA
            /// </summary>
            public static Dictionary<char, string> ReverseAlphabet = new Dictionary<char, string>{
              { 'A', "Z" }, { 'B', "Y" }, { 'C', "X" },
              { 'D', "W" }, { 'E', "V "}, { 'F', "U" },
              { 'G', "T" }, { 'H', "S" }, { 'I', "R" },
              { 'J', "Q" }, { 'K', "P" }, { 'L', "O" },
              { 'M', "N" }, { 'N', "M" }, { 'O', "L" },
              { 'P', "K" }, { 'Q', "J" }, { 'R', "I" },
              { 'S', "H" }, { 'T', "G" }, { 'U', "F" },
              { 'V', "E" }, { 'W', "D" }, { 'X', "C" },
              { 'Y', "B" }, { 'Z', "A" }
            };

            /// <summary>
            /// A tuple of the magnitude prefix and their order of magnitude. From -30 to 30.
            /// </summary>
            public static List<(string, int)> OrderOfMagnitude = new List<(string, int)>
            {
                ("quecto", -30),
                ("ronto", -27),
                ("yocto", -24),
                ("zepto", -21),
                ("atto", -18),
                ("femto", -15),
                ("pico", -12),
                ("nano", -9),
                ("micro", -6),
                ("milli", -3),
                ("centi", -2),
                ("deci", -1),
                ("deca", 1),
                ("hecto", 2),
                ("kilo", 3),
                ("mega", 6),
                ("giga", 9),
                ("tera", 12),
                ("peta", 15),
                ("exa", 18),
                ("zetta", 21),
                ("yotta", 24),
                ("ronna", 27),
                ("quetta", 30)
            };
        }

        public class Numbers
        {
            /// <summary>
            /// A list of the first 255 hexadecimal numbers.
            /// </summary>
            public static List<string> HexadecimalNumbers = new List<string>
            {
                ("0"), ("1"), ("2"), ("3"), ("4"), ("5"),
                ("6"), ("7"), ("8"), ("9"), ("A"),("B"),
                ("C"), ("D"), ("E"), ("F"),
                ("10"), ("11"), ("12"), ("13"), ("14"),
                ("15"), ("16"), ("17"), ("18"), ("19"),
                ("1A"), ("1B"), ("1C"), ("1D"), ("1E"),
                ("1F"), ("20"), ("21"), ("22"), ("23"),
                ("24"), ("25"), ("26"), ("27"), ("28"),
                ("29"), ("2A"), ("2B"), ("2C"), ("2D"),
                ("2E"), ("2F"), ("30"), ("31"), ("32"),
                ("33"), ("34"), ("35"), ("36"), ("37"),
                ("38"), ("39"), ("3A"), ("3B"), ("3C"),
                ("3D"), ("3E"), ("3F"), ("40"), ("41"),
                ("42"), ("43"), ("44"), ("45"), ("46"),
                ("47"), ("48"), ("49"), ("4A"), ("4B"),
                ("4C"), ("4D"), ("4E"), ("4F"), ("50"),
                ("51"), ("52"), ("53"), ("54"), ("55"),
                ("56"), ("57"), ("58"), ("59"), ("5A"),
                ("5B"), ("5C"), ("5D"), ("5E"), ("5F"),
                ("60"), ("61"), ("62"), ("63"), ("64"),
                ("65"), ("66"), ("67"), ("68"), ("69"),
                ("6A"), ("6B"), ("6C"), ("6D"), ("6E"),
                ("6F"), ("70"), ("71"), ("72"), ("73"),
                ("74"), ("75"), ("76"), ("77"), ("78"),
                ("79"), ("7A"), ("7B"), ("7C"), ("7D"),
                ("7E"), ("7F"), ("80"), ("81"), ("82"),
                ("83"), ("84"), ("85"), ("86"), ("87"),
                ("88"), ("89"), ("8A"), ("8B"), ("8C"),
                ("8D"), ("8E"), ("8F"), ("90"), ("91"),
                ("92"), ("93"), ("94"), ("95"), ("96"),
                ("97"), ("98"), ("99"), ("9A"), ("9B"),
                ("9C"), ("9D"), ("9E"), ("9F"), ("A0"),
                ("A1"), ("A2"), ("A3"), ("A4"), ("A5"),
                ("A6"), ("A7"), ("A8"), ("A9"), ("AA"),
                ("AB"), ("AC"), ("AD"), ("AE"), ("AF"),
                ("B0"), ("B1"), ("B2"), ("B3"), ("B4"),
                ("B5"), ("B6"), ("B7"), ("B8"), ("B9"),
                ("BA"), ("BB"), ("BC"), ("BD"), ("BE"),
                ("BF"), ("C0"), ("C1"), ("C2"), ("C3"),
                ("C4"), ("C5"), ("C6"), ("C7"), ("C8"),
                ("C9"), ("CA"), ("CB"), ("CC"), ("CD"),
                ("CE"), ("CF"), ("D0"), ("D1"), ("D2"),
                ("D3"), ("D4"), ("D5"), ("D6"), ("D7"),
                ("D8"), ("D9"), ("DA"), ("DB"), ("DC"),
                ("DD"), ("DE"), ("DF"), ("E0"), ("E1"),
                ("E2"), ("E3"), ("E4"), ("E5"), ("E6"),
                ("E7"), ("E8"), ("E9"), ("EA"), ("EB"),
                ("EC"), ("ED"), ("EE"), ("EF"), ("F0"),
                ("F1"), ("F2"), ("F3"), ("F4"), ("F5"),
                ("F6"), ("F7"), ("F8"), ("F9"), ("FA"),
                ("FB"), ("FC"), ("FD"), ("FE"), ("FF"),
            };


            /// <summary>
            /// This method will create a list with the N first numbers.
            /// </summary>
            /// <param name="N">The number of prime number to gather.</param>
            /// <returns>A list of integers..</returns>
            public static List<int> PrimesN(int N)
            {
                List<int> primes = new List<int> { };

                if (N <= 1)
                {
                    return new List<int> { };
                }
                else
                {
                    for (int i = 2; primes.Count < N; i++)
                    {
                        if (!primes.Any(p => i % p == 0))
                        {
                            primes.Add(i);

                        }
                    }
                    return primes;
                }
            }

            /// <summary>
            /// This method will create a list with the N first Fibonacci numbers.
            /// </summary>
            /// <param name="N">The number of fibonacci number to gather.</param>
            /// <returns>A list of integers.</returns>
            public static List<int> FibonacciN(int N)
            {
                List<int> fibonacci = new List<int> { 0, 1 };

                if (N <= 0)
                    return new List<int> { };
                else if (N == 1)
                    return new List<int> { 0 };
                else if (N == 2)
                    return new List<int> { 0, 1 };
                else
                {
                    for (int i = 2; fibonacci.Count < N; i++)
                    {
                        fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                    }
                    return fibonacci;
                }
            }

            /// <summary>
            /// This method will create a list with the N first Mersenne numbers.
            /// </summary>
            /// <param name="N">The number of mersenne integer to gather.</param>
            /// <returns>A list of integers.</returns>
            public static List<int> MersenneN(int N)
            {
                List<int> mersenne = new List<int> { };

                for (int i = 0; i < N; i++)
                {
                    mersenne.Add((int)System.Math.Pow(2, i) - 1);
                }
                return mersenne;
            }

            /// <summary>
            /// A list of the first 9 Mersenne Primal numbers.
            /// </summary>
            public static List<long> MersennePrimal = new List<long>
            {
                3,
                7,
                31,
                127,
                8191,
                131071,
                524287,
                2147483647,
                2305843009213693951
            };


            /// <summary>
            /// This method will create a list with the N first Triangular numbers.
            /// </summary>
            /// <param name="N">The number of triangular numbers to gathers.</param>
            /// <returns>A list of integers.</returns>
            public static List<int> TriangularNumberN(int N)
            {
                List<int> triangular = new List<int> { };
                for (int i = 1; i <= N; i++)
                {
                    triangular.Add(i * (i + 1) / 2);
                }
                return triangular;
            }

            /// <summary>
            /// This method will create a list with the N first hexagonal numbers.
            /// </summary>
            /// <param name="N">The number of hexagonal numbers to gathers.</param>
            /// <returns>A list of integers.</returns>
            public static List<int> HexagonalNumberN(int N)
            {
                List<int> hexagonal = new List<int> { };
                foreach (int number in TriangularNumberN(N))
                {
                    if (CalculsMethods.IsOdd(number))
                        hexagonal.Add(number);
                }

                return hexagonal;
            }
        }

        public class InternationalSystemOfUnits
        {
            /// <summary>
            /// A tuple of the base units of the International System of Units and their symbol.
            /// </summary>
            public static List<(string, string)> BaseUnits = new List<(string, string)>
            {
                ("meter", "m"),
                ("kilogram", "kg"),
                ("second", "s"),
                ("ampere", "A"),
                ("kelvin", "K"),
                ("mole", "mol"),
                ("candela", "cd")
            };

            /// <summary>
            /// A tuple of the derived units of the International System of Units and their symbol.
            /// </summary>
            public static List<(string, string)> DerivedUnits = new List<(string, string)>
            {
                ("hertz", "Hz"),
                ("radian", "rad"),
                ("steradian", "sr"),
                ("newton", "N"),
                ("pascal", "Pa"),
                ("joule", "J"),
                ("watt", "W"),
                ("coulomb", "C"),
                ("volt", "V"),
                ("farad", "F"),
                ("ohm", "Ω"),
                ("siemens", "S"),
                ("weber", "Wb"),
                ("tesla", "T"),
                ("henry", "H"),
                ("degree Celsius", "°C"),
                ("lumen", "lm"),
                ("lux", "lx"),
                ("becquerel", "Bq"),
                ("gray", "Gy"),
                ("sievert", "Sv"),
                ("katal", "kat")
            };
        }

        public class HTML
        {
            /// <summary>
            /// A list of the most used HTML codes colors.
            /// </summary>
            public static List<(string, string)> Colors = new List<(string, string)>
            {
                ("Red", "#FF0000"),
                ("Cyan", "#00FFFF"),
                ("Blue", "#0000FF"),
                ("DarkBlue", "#00008B"),
                ("LightBlue", "#ADD8E6"),
                ("Purple", "#800080"),
                ("Yellow", "#FFFF00"),
                ("Lime", "#00FF00"),
                ("Magenta", "#FF00FF"),
                ("Pink", "#FFC0CB"),
                ("White", "#FFFFFF"),
                ("Silver", "#C0C0C0"),
                ("Gray", "#808080"),
                ("Black", "#000000"),
                ("Orange", "#FFA500"),
                ("Brown", "#A52A2A"),
                ("Maroon", "#800000"),
                ("Green", "#008000"),
                ("Olive", "#808000"),
                ("Aquamarine", "#7FFFD4")
            };
        }

        public class Security
        {
            /// <summary>
            /// A list of 100 common passwords.
            /// </summary>
            public static List<string> CommonPasswords = new List<string>
            {
                "000000",
                "111111",
                "123123",
                "123321",
                "1234",
                "12345",
                "123456",
                "1234567",
                "12345678",
                "123456789",
                "1234567890",
                "123abc",
                "654321",
                "666666",
                "696969",
                "aaaaaa",
                "abc123",
                "alberto",
                "alejandra",
                "alejandro",
                "amanda",
                "andrea",
                "angel",
                "angels",
                "anthony",
                "asdf",
                "asdfasdf",
                "ashley",
                "babygirl",
                "baseball",
                "basketball",
                "beatriz",
                "blahblah",
                "bubbles",
                "buster",
                "butterfly",
                "carlos",
                "charlie",
                "cheese",
                "chocolate",
                "computer",
                "daniel",
                "diablo",
                "dragon",
                "elite",
                "estrella",
                "flower",
                "football",
                "forum",
                "freedom",
                "friends",
                "fuckyou",
                "hello",
                "hunter",
                "iloveu",
                "iloveyou",
                "internet",
                "jennifer",
                "jessica",
                "jesus",
                "jordan",
                "joshua",
                "justin",
                "killer",
                "letmein",
                "liverpool",
                "lovely",
                "loveme",
                "loveyou",
                "master",
                "matrix",
                "merlin",
                "monkey",
                "mustang",
                "nicole",
                "nothing",
                "number1",
                "pass",
                "passport",
                "password",
                "password1",
                "playboy",
                "pokemon",
                "pretty",
                "princess",
                "purple",
                "pussy",
                "qazwsx",
                "qwerty",
                "roberto",
                "sebastian",
                "secret",
                "shadow",
                "shit",
                "soccer",
                "starwars",
                "sunshine",
                "superman",
                "tequiero",
                "test",
                "testing",
                "trustno1",
                "tweety",
                "welcome",
                "westside",
                "whatever",
                "windows",
                "writer",
                "zxcvbnm",
                "zxczxc"
            };
        }
    }
}