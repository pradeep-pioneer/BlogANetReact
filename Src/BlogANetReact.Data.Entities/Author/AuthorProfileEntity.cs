using System;
using System.Collections.Generic;
using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Author
{
    public class AuthorProfileEntity : Entity<int>
    {
        public string ProfileImage { get; set; }
        public string CoverImage { get; set; }
        public string PenName { get; set; }
        public string Introduction { get; set; }
        public Guid LocaleId { get; set; }
        public LocaleEntity Locale { get; set; }
        public List<TranslatedAuthorProfile> TranslatedAuthorProfiles { get; set; }
    }
}
