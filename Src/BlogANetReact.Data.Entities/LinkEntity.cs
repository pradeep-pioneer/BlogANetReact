using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities
{
    public class LinkEntity : Entity<int>
    {
        public string LinkIcon { get; set; }
        public string LinkTitle { get; set; }
        public string LinkHelpText { get; set; }
        public bool ShowIcon { get; set; }
        public Guid LocaleId { get; set; }
        public LocaleEntity Locale { get; set; }
        public List<TranslatedLinkEntity> TranslatedLinks { get; set; }
        public List<AuthorProfileLink> AuthorProfileLinks { get; set; }
    }

    public class TranslatedLinkEntity : LinkEntity
    {
        public int OriginalLinkId { get; set; }
        public LinkEntity OriginalLink { get; set; }
    }
}
