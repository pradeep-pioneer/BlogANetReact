using System;
using System.Collections.Generic;
using BlogANetReact.Data.Entities;
using BlogANetReact.Data.Entities.Auth;

namespace BlogANetReact.Migrations.Data
{
    public static class Masters
    {
        public static DateTime TimeStamp => DateTime.Now;
        public static int CreatedBy = -1;
        #region [ Languages ]
        public static List<LanguageEntity> Languages => new List<LanguageEntity>()
        {
            new LanguageEntity()
            {
                LanguageName = "Abkhazian",
                LanguageCode = "ab",
                LocalName = "аҧсуа бызшәа",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Afar",
                LanguageCode = "aa",
                LocalName = "Afaraf",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Afrikaans",
                LanguageCode = "af",
                LocalName = "Afrikaans",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Albanian",
                LanguageCode = "sq",
                LocalName = "Shqip",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Amharic",
                LanguageCode = "am",
                LocalName = "አማርኛ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Arabic",
                LanguageCode = "ar",
                LocalName = "العربية",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Aragonese",
                LanguageCode = "an",
                LocalName = "aragonés",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Armenian",
                LanguageCode = "hy",
                LocalName = "Հայերեն",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Assamese",
                LanguageCode = "as",
                LocalName = "অসমীয়া",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Avaric",
                LanguageCode = "av",
                LocalName = "авар мацӀ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Avestan",
                LanguageCode = "ae",
                LocalName = "avesta",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Aymara",
                LanguageCode = "ay",
                LocalName = "aymar aru",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Azerbaijani",
                LanguageCode = "az",
                LocalName = "azərbaycan dili",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bambara",
                LanguageCode = "bm",
                LocalName = "bamanankan",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bashkir",
                LanguageCode = "ba",
                LocalName = "башҡорт теле",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Basque",
                LanguageCode = "eu",
                LocalName = "euskara",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Belarusian",
                LanguageCode = "be",
                LocalName = "Беларуская мова",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bengali",
                LanguageCode = "bn",
                LocalName = "বাংলা",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bhojpuri",
                LanguageCode = "bh",
                LocalName = "भोजपुरी",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bislama",
                LanguageCode = "bi",
                LocalName = "Bislama",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bosnian",
                LanguageCode = "bs",
                LocalName = "bosanski jezik",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Breton",
                LanguageCode = "br",
                LocalName = "brezhoneg",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bulgarian",
                LanguageCode = "bg",
                LocalName = "български език",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Burmese",
                LanguageCode = "my",
                LocalName = "ဗမာစာ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Catalan",
                LanguageCode = "ca",
                LocalName = "català",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Khmer",
                LanguageCode = "km",
                LocalName = "ភាសាខ្មែរ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Chamorro",
                LanguageCode = "ch",
                LocalName = "Chamoru",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Chechen",
                LanguageCode = "ce",
                LocalName = "нохчийн мотт",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },

            new LanguageEntity()
            {
                LanguageName = "Chichewa",
                LanguageCode = "ny",
                LocalName = "chiCheŵa",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Chinese",
                LanguageCode = "zh",
                LocalName = "汉语",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Church Slavic",
                LanguageCode = "cu",
                LocalName = "ѩзыкъ словѣньскъ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Chuvash",
                LanguageCode = "cv",
                LocalName = "чӑваш чӗлхи",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Cornish",
                LanguageCode = "kw",
                LocalName = "Kernewek",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Corsican",
                LanguageCode = "co",
                LocalName = "corsu",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Cree",
                LanguageCode = "cr",
                LocalName = "ᓀᐦᐃᔭᐍᐏᐣ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Croatian",
                LanguageCode = "hr",
                LocalName = "hrvatski jezik",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Czech",
                LanguageCode = "cs",
                LocalName = "čeština",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Danish",
                LanguageCode = "da",
                LocalName = "dansk",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Dutch",
                LanguageCode = "nl",
                LocalName = "Nederlands",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Dzongkha",
                LanguageCode = "dz",
                LocalName = "རྫོང་ཁ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "English",
                LanguageCode = "en",
                LocalName = "English",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Estonian",
                LanguageCode = "et",
                LocalName = "eesti",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Ewe",
                LanguageCode = "ee",
                LocalName = "Eʋegbe",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Faroese",
                LanguageCode = "fo",
                LocalName = "føroyskt",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Fijian",
                LanguageCode = "fj",
                LocalName = "vosa Vakaviti",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Finnish",
                LanguageCode = "fi",
                LocalName = "suomi",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Macedonian",
                LanguageCode = "mk",
                LocalName = "македонски јазик",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Persian - Farsi",
                LanguageCode = "fa",
                LocalName = "فارسی",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "French",
                LanguageCode = "fr",
                LocalName = "français",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Fulah",
                LanguageCode = "ff",
                LocalName = "Fulfulde",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Gaelic",
                LanguageCode = "gd",
                LocalName = "Gàidhlig",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Galician",
                LanguageCode = "gl",
                LocalName = "Galego",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Ganda",
                LanguageCode = "lg",
                LocalName = "Luganda",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Georgian",
                LanguageCode = "ka",
                LocalName = "ქართული",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "German",
                LanguageCode = "de",
                LocalName = "Deutsch",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Greek",
                LanguageCode = "el",
                LocalName = "ελληνικά",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Guarani - Paraguay",
                LanguageCode = "gn",
                LocalName = "Avañe'ẽ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Gujarati",
                LanguageCode = "gu",
                LocalName = "ગુજરાતી",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Haitian",
                LanguageCode = "ht",
                LocalName = "Kreyòl ayisyen",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Hausa",
                LanguageCode = "ha",
                LocalName = "هَوُسَ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Hebrew",
                LanguageCode = "he",
                LocalName = "עברית",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Herero",
                LanguageCode = "hz",
                LocalName = "Otjiherero",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Hindi",
                LanguageCode = "hi",
                LocalName = "हिन्दी",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Hiri Motu",
                LanguageCode = "ho",
                LocalName = "Hiri Motu",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Hungarian",
                LanguageCode = "hu",
                LocalName = "magyar",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Icelandic",
                LanguageCode = "is",
                LocalName = "Íslenska",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Igbo",
                LanguageCode = "ig",
                LocalName = "Asụsụ Igbo",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Indonesian",
                LanguageCode = "id",
                LocalName = "Bahasa",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Inuktitut",
                LanguageCode = "iu",
                LocalName = "ᐃᓄᒃᑎᑐᑦ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Inupiaq",
                LanguageCode = "ik",
                LocalName = "Iñupiaq",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Irish",
                LanguageCode = "ga",
                LocalName = "Gaeilge",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Italian",
                LanguageCode = "it",
                LocalName = "Italiano",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Japanese",
                LanguageCode = "ja",
                LocalName = "日本語",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Javanese",
                LanguageCode = "jv",
                LocalName = "Basa Jawa",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kalaallisut",
                LanguageCode = "kl",
                LocalName = "kalaallisut",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kannada",
                LanguageCode = "kn",
                LocalName = "ಕನ್ನಡ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },

            new LanguageEntity()
            {
                LanguageName = "Kanuri",
                LanguageCode = "kr",
                LocalName = "Kanuri",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kashmiri",
                LanguageCode = "ks",
                LocalName = "कश्मीरी",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kazakh",
                LanguageCode = "kk",
                LocalName = "қазақ тілі",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kikuyu",
                LanguageCode = "ki",
                LocalName = "Gĩkũyũ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kinyarwanda",
                LanguageCode = "rw",
                LocalName = "Ikinyarwanda",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kirghiz",
                LanguageCode = "ky",
                LocalName = "Кыргызча",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Komi",
                LanguageCode = "kv",
                LocalName = "коми кыв",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kongo",
                LanguageCode = "kg",
                LocalName = "Kikongo",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Konkani",
                LanguageCode = "kok",
                LocalName = "कोंकणी",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Korean",
                LanguageCode = "ko",
                LocalName = "한국어",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kuanyama",
                LanguageCode = "kj",
                LocalName = "Kuanyama",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kurdish",
                LanguageCode = "ku",
                LocalName = "کوردی",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Latin",
                LanguageCode = "la",
                LocalName = "latine",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Lao",
                LanguageCode = "lo",
                LocalName = "ພາສາລາວ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Latvian",
                LanguageCode = "lv",
                LocalName = "latviešu valoda",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Limburgan",
                LanguageCode = "li",
                LocalName = "Limburgs",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Lingala",
                LanguageCode = "ln",
                LocalName = "Lingála",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Lithuanian",
                LanguageCode = "lt",
                LocalName = "lietuvių kalba",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Luba-Katanga",
                LanguageCode = "lu",
                LocalName = "Kiluba",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Luxembourgish",
                LanguageCode = "lb",
                LocalName = "Lëtzebuergesch",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Malagasy",
                LanguageCode = "mg",
                LocalName = "fiteny malagasy",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Malay",
                LanguageCode = "ms",
                LocalName = "بهاس ملايو",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Malayalam",
                LanguageCode = "ml",
                LocalName = "മലയാളം",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Maltese",
                LanguageCode = "mt",
                LocalName = "Malti",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Manx",
                LanguageCode = "gv",
                LocalName = "Gaelg",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Meitei",
                LanguageCode = "mni",
                LocalName = "Manipuri",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Maori",
                LanguageCode = "mi",
                LocalName = "te reo Māori",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Marathi",
                LanguageCode = "mr",
                LocalName = "मराठी",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Marshallese",
                LanguageCode = "mh",
                LocalName = "Kajin M̧ajeļ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Mongolian",
                LanguageCode = "mn",
                LocalName = "Монгол хэл",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Nauru",
                LanguageCode = "na",
                LocalName = "Dorerin Naoero",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Navajo",
                LanguageCode = "nv",
                LocalName = "Diné bizaad",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Ndonga",
                LanguageCode = "ng",
                LocalName = "Owambo",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Nepali",
                LanguageCode = "ne",
                LocalName = "नेपाली",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "North Ndebele",
                LanguageCode = "nd",
                LocalName = "isiNdebele",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Northern Sami",
                LanguageCode = "se",
                LocalName = "Davvisámegiella",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Norwegian",
                LanguageCode = "no",
                LocalName = "Norsk",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Norwegian Bokmål",
                LanguageCode = "nb",
                LocalName = "Norsk Bokmål",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Norwegian Nynorsk",
                LanguageCode = "nn",
                LocalName = "Norsk Nynorsk",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Occitan",
                LanguageCode = "oc",
                LocalName = "occitan",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Ojibwa",
                LanguageCode = "oj",
                LocalName = "ᐊᓂᔑᓈᐯᒧᐎᓐ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Oriya",
                LanguageCode = "or",
                LocalName = "ଓଡ଼ିଆ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Oromo",
                LanguageCode = "om",
                LocalName = "Afaan Oromoo",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Ossetian",
                LanguageCode = "os",
                LocalName = "ирон æвзаг",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Pali",
                LanguageCode = "pi",
                LocalName = "पालि",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Pashto",
                LanguageCode = "ps",
                LocalName = "پښتو",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Polish",
                LanguageCode = "pl",
                LocalName  = "język polski",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Portuguese",
                LanguageCode = "pt",
                LocalName = "Português",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Punjabi",
                LanguageCode = "pa",
                LocalName = "ਪੰਜਾਬੀ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Quechua",
                LanguageCode = "qu",
                LocalName = "Runa Simi",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Romansh",
                LanguageCode = "rm",
                LocalName = "Rumantsch Grischun",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Romanian",
                LanguageCode = "ro",
                LocalName = "Română",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Rundi",
                LanguageCode = "rn",
                LocalName = "Ikirundi",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Russian",
                LanguageCode = "ru",
                LocalName = "русский",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Samoan",
                LanguageCode = "sm",
                LocalName = "gagana fa'a Samoa",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sango",
                LanguageCode = "sg",
                LocalName = "yângâ tî sängö",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sanskrit",
                LanguageCode = "sa",
                LocalName = "संस्कृतम्",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sardinian",
                LanguageCode = "sc",
                LocalName = "sardu",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Serbian",
                LanguageCode = "sr",
                LocalName = "српски језик",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },

            new LanguageEntity()
            {
                LanguageName = "Shona",
                LanguageCode = "sn",
                LocalName = "chiShona",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sindhi",
                LanguageCode = "sd",
                LocalName = "सिन्धी",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sinhala",
                LanguageCode = "si",
                LocalName = "සිංහල",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Slovak",
                LanguageCode = "sk",
                LocalName = "Slovenčina",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Slovenian",
                LanguageCode = "sl",
                LocalName = "Slovenski Jezik",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Somali",
                LanguageCode = "so",
                LocalName = "Soomaaliga",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Southern Sotho",
                LanguageCode = "st",
                LocalName = "Sesotho",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Spanish",
                LanguageCode = "es",
                LocalName = "Español",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sundanese",
                LanguageCode = "su",
                LocalName = "Basa Sunda",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Swahili",
                LanguageCode = "sw",
                LocalName = "Kiswahili",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Swedish",
                LanguageCode = "sv",
                LocalName = "Svenska",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Swati",
                LanguageCode = "ss",
                LocalName = "SiSwati",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tajik",
                LanguageCode = "tg",
                LocalName = "тоҷикӣ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tamil",
                LanguageCode = "ta",
                LocalName = "தமிழ்",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tatar",
                LanguageCode = "tt",
                LocalName = "татар теле",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Telugu",
                LanguageCode = "te",
                LocalName = "తెలుగు",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Thai",
                LanguageCode = "th",
                LocalName = "ไทย",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },

            new LanguageEntity()
            {
                LanguageName = "Tigrinya",
                LanguageCode = "ti",
                LocalName = "ትግርኛ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tibetan",
                LanguageCode = "bo",
                LocalName = "བོད་ཡིག",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Turkmen",
                LanguageCode = "tk",
                LocalName = "Türkmen",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tagalog",
                LanguageCode = "tl",
                LocalName = "Wikang Tagalog",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tswana",
                LanguageCode = "tn",
                LocalName = "Setswana",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tonga",
                LanguageCode = "to",
                LocalName = "Faka Tonga",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tsonga",
                LanguageCode = "ts",
                LocalName = "Xitsonga",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Turkish",
                LanguageCode = "tr",
                LocalName = "Türkçe",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Twi",
                LanguageCode = "tw",
                LocalName = "Twi",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tahitian",
                LanguageCode = "ty",
                LocalName = "Reo Tahiti",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Uighur",
                LanguageCode = "ug",
                LocalName = "ئۇيغۇرچە",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Ukrainian",
                LanguageCode = "uk",
                LocalName = "Українська",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Urdu",
                LanguageCode = "ur",
                LocalName = "اردو",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Uzbek",
                LanguageCode = "uz",
                LocalName = "oʻzbekcha",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Venda",
                LanguageCode = "ve",
                LocalName = "Tshivenḓa",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Vietnamese",
                LanguageCode = "vi",
                LocalName = "Tiếng Việt",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Walloon",
                LanguageCode = "wa",
                LocalName = "Walon",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Welsh",
                LanguageCode = "cy",
                LocalName = "Cymraeg",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Wolof",
                LanguageCode = "wo",
                LocalName = "Wollof",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Western Frisian",
                LanguageCode = "fy",
                LocalName = "Frysk",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Xhosa",
                LanguageCode = "xh",
                LocalName = "isiXhosa",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Yiddish",
                LanguageCode = "yi",
                LocalName = "ייִדיש",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },

            new LanguageEntity()
            {
                LanguageName = "Yoruba",
                LanguageCode = "yo",
                LocalName = "Yorùbá",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Zhuang",
                LanguageCode = "za",
                LocalName = "Saɯ cueŋƅ",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Zulu",
                LanguageCode = "zu",
                LocalName = "isiZulu",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
        };
        #endregion

        #region [ Locales ]
        public static List<LocaleEntity> Locales => new List<LocaleEntity>()
        {
            new LocaleEntity(){ LocaleName = "Pali - India", LCID = "pi-IN", Slug = "pi-IN" },
            new LocaleEntity(){ LocaleName = "Bhojpuri", LCID = "bh-IN", Slug = "bh-IN" },
            new LocaleEntity(){ LocaleName = "Arabic - Saudi Arabia", LCID = "ar-SA", Slug = "ar-SA" },
            new LocaleEntity(){ LocaleName = "Bulgarian", LCID = "bg-BG", Slug = "bg-BG" },
            new LocaleEntity(){ LocaleName = "Catalan", LCID = "ca-ES", Slug = "ca-ES" },
            new LocaleEntity(){ LocaleName = "Chinese - Taiwan", LCID = "zh-TW", Slug = "zh-TW" },
            new LocaleEntity(){ LocaleName = "Czech", LCID = "cs-CZ", Slug = "cs-CZ" },
            new LocaleEntity(){ LocaleName = "Danish", LCID = "da-DK", Slug = "da-DK" },
            new LocaleEntity(){ LocaleName = "German - Germany", LCID = "de-DE", Slug = "de-DE" },
            new LocaleEntity(){ LocaleName = "Greek", LCID = "el-GR", Slug = "el-GR" },
            new LocaleEntity(){ LocaleName = "English - United States", LCID = "en-US", Slug = "en-US" },
            new LocaleEntity(){ LocaleName = "Spanish - Spain (Traditional Sort)", LCID = "es-ES", Slug = "es-ES" },
            new LocaleEntity(){ LocaleName = "Finnish", LCID = "fi-FI", Slug = "fi-FI" },
            new LocaleEntity(){ LocaleName = "French - France", LCID = "fr-FR", Slug = "fr-FR" },
            new LocaleEntity(){ LocaleName = "Hebrew", LCID = "he-IL", Slug = "he-IL" },
            new LocaleEntity(){ LocaleName = "Hungarian", LCID = "hu-HU", Slug = "hu-HU" },
            new LocaleEntity(){ LocaleName = "Icelandic", LCID = "is-IS", Slug = "is-IS" },
            new LocaleEntity(){ LocaleName = "Italian - Italy", LCID = "it-IT", Slug = "it-IT" },
            new LocaleEntity(){ LocaleName = "Japanese", LCID = "ja-JP", Slug = "ja-JP" },
            new LocaleEntity(){ LocaleName = "Korean", LCID = "ko-KR", Slug = "ko-KR" },
            new LocaleEntity(){ LocaleName = "Dutch - Netherlands", LCID = "nl-NL", Slug = "nl-NL" },
            new LocaleEntity(){ LocaleName = "Norwegian (Bokmål)", LCID = "nb-NO", Slug = "nb-NO" },
            new LocaleEntity(){ LocaleName = "Polish", LCID = "pl-PL", Slug = "pl-PL" },
            new LocaleEntity(){ LocaleName = "Portuguese - Brazil", LCID = "pt-BR", Slug = "pt-BR" },
            new LocaleEntity(){ LocaleName = "Rhaeto-Romanic", LCID = "rm-CH", Slug = "rm-CH" },
            new LocaleEntity(){ LocaleName = "Romanian", LCID = "ro-RO", Slug = "ro-RO" },
            new LocaleEntity(){ LocaleName = "Russian", LCID = "ru-RU", Slug = "ru-RU" },
            new LocaleEntity(){ LocaleName = "Croatian", LCID = "hr-HR", Slug = "hr-HR" },
            new LocaleEntity(){ LocaleName = "Slovak", LCID = "sk-SK", Slug = "sk-SK" },
            new LocaleEntity(){ LocaleName = "Albanian - Albania", LCID = "sq-AL", Slug = "sq-AL" },
            new LocaleEntity(){ LocaleName = "Swedish", LCID = "sv-SE", Slug = "sv-SE" },
            new LocaleEntity(){ LocaleName = "Thai", LCID = "th-TH", Slug = "th-TH" },
            new LocaleEntity(){ LocaleName = "Turkish", LCID = "tr-TR", Slug = "tr-TR" },
            new LocaleEntity(){ LocaleName = "Urdu - Pakistan", LCID = "ur-PK", Slug = "ur-PK" },
            new LocaleEntity(){ LocaleName = "Indonesian", LCID = "id-ID", Slug = "id-ID" },
            new LocaleEntity(){ LocaleName = "Ukrainian", LCID = "uk-UA", Slug = "uk-UA" },
            new LocaleEntity(){ LocaleName = "Belarusian", LCID = "be-BY", Slug = "be-BY" },
            new LocaleEntity(){ LocaleName = "Slovenian", LCID = "sl-SI", Slug = "sl-SI" },
            new LocaleEntity(){ LocaleName = "Estonian", LCID = "et-EE", Slug = "et-EE" },
            new LocaleEntity(){ LocaleName = "Latvian", LCID = "lv-LV", Slug = "lv-LV" },
            new LocaleEntity(){ LocaleName = "Lithuanian", LCID = "lt-LT", Slug = "lt-LT" },
            new LocaleEntity(){ LocaleName = "Tajik", LCID = "tg-Cyrl-TJ", Slug = "tg-Cyrl-TJ" },
            new LocaleEntity(){ LocaleName = "Persian", LCID = "fa-IR", Slug = "fa-IR" },
            new LocaleEntity(){ LocaleName = "Vietnamese", LCID = "vi-VN", Slug = "vi-VN" },
            new LocaleEntity(){ LocaleName = "Armenian - Armenia", LCID = "hy-AM", Slug = "hy-AM" },
            new LocaleEntity(){ LocaleName = "Azeri (Latin)", LCID = "az-Latn-AZ", Slug = "az-Latn-AZ" },
            new LocaleEntity(){ LocaleName = "Basque", LCID = "eu-ES", Slug = "eu-ES" },
            new LocaleEntity(){ LocaleName = "Sorbian", LCID = "wen-DE", Slug = "wen-DE" },
            new LocaleEntity(){ LocaleName = "F.Y.R.O. Macedonian", LCID = "mk-MK", Slug = "mk-MK" },
            new LocaleEntity(){ LocaleName = "Sutu", LCID = "st-ZA", Slug = "st-ZA" },
            new LocaleEntity(){ LocaleName = "Tsonga", LCID = "ts-ZA", Slug = "ts-ZA" },
            new LocaleEntity(){ LocaleName = "Tswana", LCID = "tn-ZA", Slug = "tn-ZA" },
            new LocaleEntity(){ LocaleName = "Venda", LCID = "ve-ZA", Slug = "ven-ZA" },
            new LocaleEntity(){ LocaleName = "Xhosa", LCID = "xh-ZA", Slug = "xh-ZA" },
            new LocaleEntity(){ LocaleName = "Zulu", LCID = "zu-ZA", Slug = "zu-ZA" },
            new LocaleEntity(){ LocaleName = "Afrikaans - South Africa", LCID = "af-ZA", Slug = "af-ZA" },
            new LocaleEntity(){ LocaleName = "Georgian", LCID = "ka-GE", Slug = "ka-GE" },
            new LocaleEntity(){ LocaleName = "Faroese", LCID = "fo-FO", Slug = "fo-FO" },
            new LocaleEntity(){ LocaleName = "Hindi", LCID = "hi-IN", Slug = "hi-IN" },
            new LocaleEntity(){ LocaleName = "Maltese", LCID = "mt-MT", Slug = "mt-MT" },
            new LocaleEntity(){ LocaleName = "Sami", LCID = "se-NO", Slug = "se-NO" },
            new LocaleEntity(){ LocaleName = "Gaelic (Scotland)", LCID = "gd-GB", Slug = "gd-GB" },
            new LocaleEntity(){ LocaleName = "Yiddish", LCID = "yi", Slug = "yi" },
            new LocaleEntity(){ LocaleName = "Malay - Malaysia", LCID = "ms-MY", Slug = "ms-MY" },
            new LocaleEntity(){ LocaleName = "Kazakh", LCID = "kk-KZ", Slug = "kk-KZ" },
            new LocaleEntity(){ LocaleName = "Kyrgyz (Cyrillic)", LCID = "ky-KG", Slug = "ky-KG" },
            new LocaleEntity(){ LocaleName = "Swahili", LCID = "sw-KE", Slug = "sw-KE" },
            new LocaleEntity(){ LocaleName = "Turkmen", LCID = "tk-TM", Slug = "tk-TM" },
            new LocaleEntity(){ LocaleName = "Uzbek (Latin)", LCID = "uz-Latn-UZ", Slug = "uz-Latn-UZ" },
            new LocaleEntity(){ LocaleName = "Tatar", LCID = "tt-RU", Slug = "tt-RU" },
            new LocaleEntity(){ LocaleName = "Bengali (India)", LCID = "bn-IN", Slug = "bn-IN" },
            new LocaleEntity(){ LocaleName = "Punjabi", LCID = "pa-IN", Slug = "pa-IN" },
            new LocaleEntity(){ LocaleName = "Gujarati", LCID = "gu-IN", Slug = "gu-IN" },
            new LocaleEntity(){ LocaleName = "Oriya", LCID = "or-IN", Slug = "or-IN" },
            new LocaleEntity(){ LocaleName = "Tamil", LCID = "ta-IN", Slug = "ta-IN" },
            new LocaleEntity(){ LocaleName = "Telugu", LCID = "te-IN", Slug = "te-IN" },
            new LocaleEntity(){ LocaleName = "Kannada", LCID = "kn-IN", Slug = "kn-IN" },
            new LocaleEntity(){ LocaleName = "Malayalam", LCID = "ml-IN", Slug = "ml-IN" },
            new LocaleEntity(){ LocaleName = "Assamese", LCID = "as-IN", Slug = "as-IN" },
            new LocaleEntity(){ LocaleName = "Marathi", LCID = "mr-IN", Slug = "mr-IN" },
            new LocaleEntity(){ LocaleName = "Sanskrit", LCID = "sa-IN", Slug = "sa-IN" },
            new LocaleEntity(){ LocaleName = "Mongolian (Cyrillic)", LCID = "mn-MN", Slug = "mn-MN" },
            new LocaleEntity(){ LocaleName = "Tibetan - People's Republic of China", LCID = "bo-CN", Slug = "bo-CN" },
            new LocaleEntity(){ LocaleName = "Welsh", LCID = "cy-GB", Slug = "cy-GB" },
            new LocaleEntity(){ LocaleName = "Khmer", LCID = "km-KH", Slug = "km-KH" },
            new LocaleEntity(){ LocaleName = "Lao", LCID = "lo-LA", Slug = "lo-LA" },
            new LocaleEntity(){ LocaleName = "Burmese", LCID = "my-MM", Slug = "my-MM" },
            new LocaleEntity(){ LocaleName = "Galician", LCID = "gl-ES", Slug = "gl-ES" },
            new LocaleEntity(){ LocaleName = "Konkani", LCID = "kok-IN", Slug = "kok-IN" },
            new LocaleEntity(){ LocaleName = "Manipuri", LCID = "mni", Slug = "mni" },
            new LocaleEntity(){ LocaleName = "Sindhi - India", LCID = "sd-IN", Slug = "sd-IN" },
            new LocaleEntity(){ LocaleName = "Syriac", LCID = "syr-SY", Slug = "syr-SY" },
            new LocaleEntity(){ LocaleName = "Sinhalese - Sri Lanka", LCID = "si-LK", Slug = "si-LK" },
            new LocaleEntity(){ LocaleName = "Cherokee - United States", LCID = "chr-US", Slug = "chr-US" },
            new LocaleEntity(){ LocaleName = "Inuktitut", LCID = "iu-Cans-CA", Slug = "iu-Cans-CA" },
            new LocaleEntity(){ LocaleName = "Amharic - Ethiopia", LCID = "am-ET", Slug = "am-ET" },
            new LocaleEntity(){ LocaleName = "Tamazight (Arabic)", LCID = "tmz", Slug = "tmz" },
            new LocaleEntity(){ LocaleName = "Kashmiri (Arabic)", LCID = "ks-Arab-IN", Slug = "ks-Arab-IN" },
            new LocaleEntity(){ LocaleName = "Nepali - Nepal", LCID = "ne-NP", Slug = "ne-NP" },
            new LocaleEntity(){ LocaleName = "Frisian - Netherlands", LCID = "fy-NL", Slug = "fy-NL" },
            new LocaleEntity(){ LocaleName = "Pashto", LCID = "ps-AF", Slug = "ps-AF" },
            new LocaleEntity(){ LocaleName = "Filipino", LCID = "fil-PH", Slug = "fil-PH" },
            new LocaleEntity(){ LocaleName = "Divehi", LCID = "dv-MV", Slug = "dv-MV" },
            new LocaleEntity(){ LocaleName = "Edo", LCID = "bin-NG", Slug = "bin-NG" },
            new LocaleEntity(){ LocaleName = "Fulfulde - Nigeria", LCID = "ff-NG", Slug = "fuv-NG" },
            new LocaleEntity(){ LocaleName = "Hausa - Nigeria", LCID = "ha-Latn-NG", Slug = "ha-Latn-NG" },
            new LocaleEntity(){ LocaleName = "Ibibio - Nigeria", LCID = "ibb-NG", Slug = "ibb-NG" },
            new LocaleEntity(){ LocaleName = "Yoruba", LCID = "yo-NG", Slug = "yo-NG" },
            new LocaleEntity(){ LocaleName = "Quecha - Bolivia", LCID = "quz-BO", Slug = "quz-BO" },
            new LocaleEntity(){ LocaleName = "Sepedi", LCID = "nso-ZA", Slug = "nso-ZA" },
            new LocaleEntity(){ LocaleName = "Igbo - Nigeria", LCID = "ig-NG", Slug = "ig-NG" },
            new LocaleEntity(){ LocaleName = "Kanuri - Nigeria", LCID = "kr-NG", Slug = "kr-NG" },
            new LocaleEntity(){ LocaleName = "Oromo", LCID = "om-ET", Slug = "gaz-ET" },
            new LocaleEntity(){ LocaleName = "Tigrigna - Ethiopia", LCID = "ti-ER", Slug = "ti-ER" },
            new LocaleEntity(){ LocaleName = "Guarani - Paraguay", LCID = "gn-PY", Slug = "gn-PY" },
            new LocaleEntity(){ LocaleName = "Hawaiian - United States", LCID = "haw-US", Slug = "haw-US" },
            new LocaleEntity(){ LocaleName = "Latin", LCID = "la", Slug = "la" },
            new LocaleEntity(){ LocaleName = "Somali", LCID = "so-SO", Slug = "so-SO" },
            new LocaleEntity(){ LocaleName = "Yi", LCID = "ii-CN", Slug = "ii-CN" },
            new LocaleEntity(){ LocaleName = "Papiamentu", LCID = "pap-AN", Slug = "pap-AN" },
            new LocaleEntity(){ LocaleName = "Uighur - China", LCID = "ug-Arab-CN", Slug = "ug-Arab-CN" },
            new LocaleEntity(){ LocaleName = "Maori - New Zealand", LCID = "mi-NZ", Slug = "mi-NZ" },
            new LocaleEntity(){ LocaleName = "Arabic - Iraq", LCID = "ar-IQ", Slug = "ar-IQ" },
            new LocaleEntity(){ LocaleName = "Chinese - People's Republic of China", LCID = "zh-CN", Slug = "zh-CN" },
            new LocaleEntity(){ LocaleName = "German - Switzerland", LCID = "de-CH", Slug = "de-CH" },
            new LocaleEntity(){ LocaleName = "English - United Kingdom", LCID = "en-GB", Slug = "en-GB" },
            new LocaleEntity(){ LocaleName = "Spanish - Mexico", LCID = "es-MX", Slug = "es-MX" },
            new LocaleEntity(){ LocaleName = "French - Belgium", LCID = "fr-BE", Slug = "fr-BE" },
            new LocaleEntity(){ LocaleName = "Italian - Switzerland", LCID = "it-CH", Slug = "it-CH" },
            new LocaleEntity(){ LocaleName = "Dutch - Belgium", LCID = "nl-BE", Slug = "nl-BE" },
            new LocaleEntity(){ LocaleName = "Norwegian (Nynorsk)", LCID = "nn-NO", Slug = "nn-NO" },
            new LocaleEntity(){ LocaleName = "Portuguese - Portugal", LCID = "pt-PT", Slug = "pt-PT" },
            new LocaleEntity(){ LocaleName = "Romanian - Moldava", LCID = "ro-MD", Slug = "ro-MD" },
            new LocaleEntity(){ LocaleName = "Russian - Moldava", LCID = "ru-MD", Slug = "ru-MD" },
            new LocaleEntity(){ LocaleName = "Serbian (Latin)", LCID = "sr-Latn-CS", Slug = "sr-Latn-CS" },
            new LocaleEntity(){ LocaleName = "Swedish - Finland", LCID = "sv-FI", Slug = "sv-FI" },
            new LocaleEntity(){ LocaleName = "Urdu - India", LCID = "ur-IN", Slug = "ur-IN" },
            new LocaleEntity(){ LocaleName = "Azeri (Cyrillic)", LCID = "az-Cyrl-AZ", Slug = "az-Cyrl-AZ" },
            new LocaleEntity(){ LocaleName = "Gaelic (Ireland)", LCID = "ga-IE", Slug = "ga-IE" },
            new LocaleEntity(){ LocaleName = "Malay - Brunei Darussalam", LCID = "ms-BN", Slug = "ms-BN" },
            new LocaleEntity(){ LocaleName = "Uzbek (Cyrillic)", LCID = "uz-Cyrl-UZ", Slug = "uz-Cyrl-UZ" },
            new LocaleEntity(){ LocaleName = "Bengali (Bangladesh)", LCID = "bn-BD", Slug = "bn-BD" },
            new LocaleEntity(){ LocaleName = "Punjabi (Pakistan)", LCID = "pa-PK", Slug = "pa-PK" },
            new LocaleEntity(){ LocaleName = "Mongolian (Mongolian)", LCID = "mn-Mong-CN", Slug = "mn-Mong-CN" },
            new LocaleEntity(){ LocaleName = "Tibetan - Bhutan", LCID = "bo-BT", Slug = "bo-BT" },
            new LocaleEntity(){ LocaleName = "Sindhi - Pakistan", LCID = "sd-PK", Slug = "sd-PK" },
            new LocaleEntity(){ LocaleName = "Tamazight (Latin)", LCID = "tzm-Latn-DZ", Slug = "tzm-Latn-DZ" },
            new LocaleEntity(){ LocaleName = "Kashmiri (Devanagari)", LCID = "ks-Deva-IN", Slug = "ks-Deva-IN" },
            new LocaleEntity(){ LocaleName = "Nepali - India", LCID = "ne-IN", Slug = "ne-IN" },
            new LocaleEntity(){ LocaleName = "Quecha - Ecuador", LCID = "quz-EC", Slug = "quz-EC" },
            new LocaleEntity(){ LocaleName = "Tigrigna - Eritrea", LCID = "ti-ET", Slug = "ti-ET" },
            new LocaleEntity(){ LocaleName = "Arabic - Egypt", LCID = "ar-EG", Slug = "ar-EG" },
            new LocaleEntity(){ LocaleName = "Chinese - Hong Kong SAR", LCID = "zh-HK", Slug = "zh-HK" },
            new LocaleEntity(){ LocaleName = "German - Austria", LCID = "de-AT", Slug = "de-AT" },
            new LocaleEntity(){ LocaleName = "English - Australia", LCID = "en-AU", Slug = "en-AU" },
            new LocaleEntity(){ LocaleName = "Spanish - Spain (Modern Sort)", LCID = "es-ES", Slug = "es-ES" },
            new LocaleEntity(){ LocaleName = "French - Canada", LCID = "fr-CA", Slug = "fr-CA" },
            new LocaleEntity(){ LocaleName = "Serbian (Cyrillic)", LCID = "sr-Cyrl-CS", Slug = "sr-Cyrl-CS" },
            new LocaleEntity(){ LocaleName = "Quecha - Peru", LCID = "quz-PE", Slug = "quz-PE" },
            new LocaleEntity(){ LocaleName = "Arabic - Libya", LCID = "ar-LY", Slug = "ar-LY" },
            new LocaleEntity(){ LocaleName = "Chinese - Singapore", LCID = "zh-SG", Slug = "zh-SG" },
            new LocaleEntity(){ LocaleName = "German - Luxembourg", LCID = "de-LU", Slug = "de-LU" },
            new LocaleEntity(){ LocaleName = "English - Canada", LCID = "en-CA", Slug = "en-CA" },
            new LocaleEntity(){ LocaleName = "Spanish - Guatemala", LCID = "es-GT", Slug = "es-GT" },
            new LocaleEntity(){ LocaleName = "French - Switzerland", LCID = "fr-CH", Slug = "fr-CH" },
            new LocaleEntity(){ LocaleName = "Croatian (Bosnia/Herzegovina)", LCID = "hr-BA", Slug = "hr-BA" },
            new LocaleEntity(){ LocaleName = "Arabic - Algeria", LCID = "ar-DZ", Slug = "ar-DZ" },
            new LocaleEntity(){ LocaleName = "Chinese - Macao SAR", LCID = "zh-MO", Slug = "zh-MO" },
            new LocaleEntity(){ LocaleName = "German - Liechtenstein", LCID = "de-LI", Slug = "de-LI" },
            new LocaleEntity(){ LocaleName = "English - New Zealand", LCID = "en-NZ", Slug = "en-NZ" },
            new LocaleEntity(){ LocaleName = "Spanish - Costa Rica", LCID = "es-CR", Slug = "es-CR" },
            new LocaleEntity(){ LocaleName = "French - Luxembourg", LCID = "fr-LU", Slug = "fr-LU" },
            new LocaleEntity(){ LocaleName = "Bosnian (Bosnia/Herzegovina)", LCID = "bs-Latn-BA", Slug = "bs-Latn-BA" },
            new LocaleEntity(){ LocaleName = "Arabic - Morocco", LCID = "ar-MO", Slug = "ar-MO" },
            new LocaleEntity(){ LocaleName = "English - Ireland", LCID = "en-IE", Slug = "en-IE" },
            new LocaleEntity(){ LocaleName = "Spanish - Panama", LCID = "es-PA", Slug = "es-PA" },
            new LocaleEntity(){ LocaleName = "French - Monaco", LCID = "fr-MC", Slug = "fr-MC" },
            new LocaleEntity(){ LocaleName = "Arabic - Tunisia", LCID = "ar-TN", Slug = "ar-TN" },
            new LocaleEntity(){ LocaleName = "English - South Africa", LCID = "en-ZA", Slug = "en-ZA" },
            new LocaleEntity(){ LocaleName = "Spanish - Dominican Republic", LCID = "es-DO", Slug = "es-DO" },
            new LocaleEntity(){ LocaleName = "French - West Indies", LCID = "fr-029", Slug = "fr-029" },
            new LocaleEntity(){ LocaleName = "Arabic - Oman", LCID = "ar-OM", Slug = "ar-OM" },
            new LocaleEntity(){ LocaleName = "English - Jamaica", LCID = "en-JM", Slug = "en-JM" },
            new LocaleEntity(){ LocaleName = "Spanish - Venezuela", LCID = "es-VE", Slug = "es-VE" },
            new LocaleEntity(){ LocaleName = "French - Reunion", LCID = "fr-RE", Slug = "fr-RE" },
            new LocaleEntity(){ LocaleName = "Arabic - Yemen", LCID = "ar-YE", Slug = "ar-YE" },
            new LocaleEntity(){ LocaleName = "English - Caribbean", LCID = "en-029", Slug = "en-029" },
            new LocaleEntity(){ LocaleName = "Spanish - Colombia", LCID = "es-CO", Slug = "es-CO" },
            new LocaleEntity(){ LocaleName = "French - Democratic Rep. of Congo", LCID = "fr-CG", Slug = "fr-CG" },
            new LocaleEntity(){ LocaleName = "Arabic - Syria", LCID = "ar-SY", Slug = "ar-SY" },
            new LocaleEntity(){ LocaleName = "English - Belize", LCID = "en-BZ", Slug = "en-BZ" },
            new LocaleEntity(){ LocaleName = "Spanish - Peru", LCID = "es-PE", Slug = "es-PE" },
            new LocaleEntity(){ LocaleName = "French - Senegal", LCID = "fr-SN", Slug = "fr-SN" },
            new LocaleEntity(){ LocaleName = "Arabic - Jordan", LCID = "ar-JO", Slug = "ar-JO" },
            new LocaleEntity(){ LocaleName = "English - Trinidad", LCID = "en-TT", Slug = "en-TT" },
            new LocaleEntity(){ LocaleName = "Spanish - Argentina", LCID = "es-AR", Slug = "es-AR" },
            new LocaleEntity(){ LocaleName = "French - Cameroon", LCID = "fr-CM", Slug = "fr-CM" },
            new LocaleEntity(){ LocaleName = "Arabic - Lebanon", LCID = "ar-LB", Slug = "ar-LB" },
            new LocaleEntity(){ LocaleName = "English - Zimbabwe", LCID = "en-ZW", Slug = "en-ZW" },
            new LocaleEntity(){ LocaleName = "Spanish - Ecuador", LCID = "es-EC", Slug = "es-EC" },
            new LocaleEntity(){ LocaleName = "French - Cote d'Ivoire", LCID = "fr-CI", Slug = "fr-CI" },
            new LocaleEntity(){ LocaleName = "Arabic - Kuwait", LCID = "ar-KW", Slug = "ar-KW" },
            new LocaleEntity(){ LocaleName = "English - Philippines", LCID = "en-PH", Slug = "en-PH" },
            new LocaleEntity(){ LocaleName = "Spanish - Chile", LCID = "es-CL", Slug = "es-CL" },
            new LocaleEntity(){ LocaleName = "French - Mali", LCID = "fr-ML", Slug = "fr-ML" },
            new LocaleEntity(){ LocaleName = "Arabic - U.A.E.", LCID = "ar-AE", Slug = "ar-AE" },
            new LocaleEntity(){ LocaleName = "English - Indonesia", LCID = "en-ID", Slug = "en-ID" },
            new LocaleEntity(){ LocaleName = "Spanish - Uruguay", LCID = "es-UY", Slug = "es-UY" },
            new LocaleEntity(){ LocaleName = "French - Morocco", LCID = "fr-MA", Slug = "fr-MA" },
            new LocaleEntity(){ LocaleName = "Arabic - Bahrain", LCID = "ar-BH", Slug = "ar-BH" },
            new LocaleEntity(){ LocaleName = "English - Hong Kong SAR", LCID = "en-HK", Slug = "en-HK" },
            new LocaleEntity(){ LocaleName = "Spanish - Paraguay", LCID = "es-PY", Slug = "es-PY" },
            new LocaleEntity(){ LocaleName = "French - Haiti", LCID = "fr-HT", Slug = "fr-HT" },
            new LocaleEntity(){ LocaleName = "Arabic - Qatar", LCID = "ar-QA", Slug = "ar-QA" },
            new LocaleEntity(){ LocaleName = "English - India", LCID = "en-IN", Slug = "en-IN" },
            new LocaleEntity(){ LocaleName = "Spanish - Bolivia", LCID = "es-BO", Slug = "es-BO" },
            new LocaleEntity(){ LocaleName = "English - Malaysia", LCID = "en-MY", Slug = "en-MY" },
            new LocaleEntity(){ LocaleName = "Spanish - El Salvador", LCID = "es-SV", Slug = "es-SV" },
            new LocaleEntity(){ LocaleName = "English - Singapore", LCID = "en-SG", Slug = "en-SG" },
            new LocaleEntity(){ LocaleName = "Spanish - Honduras", LCID = "es-HN", Slug = "es-HN" },
            new LocaleEntity(){ LocaleName = "Spanish - Nicaragua", LCID = "es-NI", Slug = "es-NI" },
            new LocaleEntity(){ LocaleName = "Spanish - Puerto Rico", LCID = "es-PR", Slug = "es-PR" },
            new LocaleEntity(){ LocaleName = "Spanish - United States", LCID = "es-US", Slug = "es-US" },
            new LocaleEntity(){ LocaleName = "Spanish - Latin America", LCID = "es-419", Slug = "es-419" },
            new LocaleEntity(){ LocaleName = "French - North Africa", LCID = "fr-015", Slug = "fr-015" },
        };
        #endregion

        #region [ Users ]
        public static List<UserEntity> Users => new List<UserEntity>()
        {
            new UserEntity()
            {
                UserName = "Anonymous",
                Email = "Anonymous@Email.NotRequired",
                PhoneNumber = "0000000000",
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = true,
                Active = false,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            }
        };
        #endregion

        #region [ Roles ]
        public static List<RoleEntity> RoleEntities => new List<RoleEntity>()
        {
            new RoleEntity()
            {
                Name = "Anonymous",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new RoleEntity()
            {
                Name = "Administrator",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new RoleEntity()
            {
                Name = "Writer",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new RoleEntity()
            {
                Name = "Editor",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            },
            new RoleEntity()
            {
                Name = "Contributor",
                Active = true,
                CreatedBy = CreatedBy,
                CreatedOn = TimeStamp
            }
        };
        #endregion
    }
}
