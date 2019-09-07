using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities
{
    public class LanguageEntity : Entity<Guid>
    {
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public string LocalName { get; set; }
        public List<LocaleEntity> Locales { get; set; }
    }
}
