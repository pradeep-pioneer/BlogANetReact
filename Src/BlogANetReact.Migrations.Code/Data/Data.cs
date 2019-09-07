using System;
using System.Collections.Generic;
using System.Linq;
using BlogANetReact.Data.Entities;
using BlogANetReact.Data.Entities.Auth;

namespace BlogANetReact.Migrations.Code
{
    public static class Data
    {
        public static DateTime TimeStamp => DateTime.Now;

        #region [ Languages ]
        public static List<LanguageEntity> Languages => new List<LanguageEntity>()
        {
            new LanguageEntity()
            {
                LanguageName = "Afrikaans",
                LanguageCode = "af",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Albanian",
                LanguageCode = "sq",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Amharic",
                LanguageCode = "am",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Arabic",
                LanguageCode = "ar",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Armenian",
                LanguageCode = "hy",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Assamese",
                LanguageCode = "as",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Azeri",
                LanguageCode = "az",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Basque",
                LanguageCode = "eu",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Belarusian",
                LanguageCode = "be",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bengali",
                LanguageCode = "bn",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bosnian",
                LanguageCode = "bs",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Bulgarian",
                LanguageCode = "bg",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Burmese",
                LanguageCode = "my",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Catalan",
                LanguageCode = "ca",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Chinese",
                LanguageCode = "zh",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Croatian",
                LanguageCode = "hr",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Czech",
                LanguageCode = "cs",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Dutch",
                LanguageCode = "nl",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "English",
                LanguageCode = "en",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Estonian",
                LanguageCode = "et",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "FYRO Macedonia",
                LanguageCode = "mk",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Faroese",
                LanguageCode = "fo",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Farsi - Persian",
                LanguageCode = "fa",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Finnish",
                LanguageCode = "fi",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "French",
                LanguageCode = "fr",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Gaelic",
                LanguageCode = "gd",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Galician",
                LanguageCode = "gl",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Georgian",
                LanguageCode = "ka",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "German",
                LanguageCode = "de",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Greek",
                LanguageCode = "el",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Guarani - Paraguay",
                LanguageCode = "gn",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Gujarati",
                LanguageCode = "gu",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Hebrew",
                LanguageCode = "he",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Hindi",
                LanguageCode = "hi",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Hungarian",
                LanguageCode = "hu",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Icelandic",
                LanguageCode = "is",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Indonesian",
                LanguageCode = "id",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Italian",
                LanguageCode = "it",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Japanese",
                LanguageCode = "jp",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kannada",
                LanguageCode = "kn",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kashmiri",
                LanguageCode = "ks",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Kazakh",
                LanguageCode = "kk",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Khmer",
                LanguageCode = "km",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Konkani",
                LanguageCode = "kok",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Korean",
                LanguageCode = "ko",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Lao",
                LanguageCode = "lo",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Latin",
                LanguageCode = "la",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Latvian",
                LanguageCode = "lv",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Lithuanian",
                LanguageCode = "lv",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Malay",
                LanguageCode = "ms",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Malayalam",
                LanguageCode = "ml",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Maltese",
                LanguageCode = "mt",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Meitei",
                LanguageCode = "mni",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Maori",
                LanguageCode = "mi",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Marathi",
                LanguageCode = "mr",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Mongolian",
                LanguageCode = "mn",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Nepali",
                LanguageCode = "ne",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Norwegian",
                LanguageCode = "nb",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Oriya",
                LanguageCode = "or",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Polish",
                LanguageCode = "pl",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Portuguese",
                LanguageCode = "pt",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Punjabi",
                LanguageCode = "pa",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Raeto-Romance",
                LanguageCode = "rm",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Romanian",
                LanguageCode = "ro",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Russian",
                LanguageCode = "ru",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sanskrit",
                LanguageCode = "sa",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Serbian",
                LanguageCode = "sr",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Setsuana",
                LanguageCode = "tn",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sindhi",
                LanguageCode = "sd",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sinhala",
                LanguageCode = "si",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Slovak",
                LanguageCode = "sk",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Slovenian",
                LanguageCode = "sl",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Somali",
                LanguageCode = "so",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Sorbian",
                LanguageCode = "sb",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Spanish",
                LanguageCode = "es",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Swahili",
                LanguageCode = "sw",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Swedish",
                LanguageCode = "sv",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tajik",
                LanguageCode = "tg",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tamil",
                LanguageCode = "ta",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tatar",
                LanguageCode = "tt",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Telugu",
                LanguageCode = "te",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Thai",
                LanguageCode = "th",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tibetan",
                LanguageCode = "bo",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Tsonga",
                LanguageCode = "ts",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Turkish",
                LanguageCode = "tr",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Turkmen",
                LanguageCode = "tk",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Ukrainian",
                LanguageCode = "uk",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Urdu",
                LanguageCode = "ur",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Uzbek",
                LanguageCode = "uz",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Venda",
                LanguageCode = "ve",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Vietnamese",
                LanguageCode = "vi",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Welsh",
                LanguageCode = "cy",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Xhosa",
                LanguageCode = "xh",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Yiddish",
                LanguageCode = "yi",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new LanguageEntity()
            {
                LanguageName = "Zulu",
                LanguageCode = "zu",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
        };
        #endregion

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
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            }
        };

        public static List<RoleEntity> RoleEntities => new List<RoleEntity>()
        {
            new RoleEntity()
            {
                Name = "Anonymous",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new RoleEntity()
            {
                Name = "Administrator",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new RoleEntity()
            {
                Name = "Writer",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new RoleEntity()
            {
                Name = "Editor",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            },
            new RoleEntity()
            {
                Name = "Contributor",
                Active = true,
                CreatedBy = Guid.Empty,
                CreatedOn = TimeStamp
            }
        };
    }
}