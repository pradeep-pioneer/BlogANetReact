using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities
{
    public class LocaleEntity : Entity<int>
    {
        public string LCID { get; set; }
        public string LocaleName { get; set; }
        public string Slug { get; set; }
        public List<LinkEntity> Links { get; set; }
        public List<TranslatedLinkEntity> TranslatedLinks { get; set; }

        public List<TagEntity> Tags { get; set; }
        public List<TranslatedTagEntity> TranslatedTags { get; set; }

        public List<AuthorProfileEntity> AuthorProfiles { get; set; }

        public long? LanguageId { get; set; }
        public LanguageEntity Language { get; set; }
    }
}
