using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Entities
{
    public class TagEntity : Entity<Guid>
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public Guid LocaleId { get; set; }
        public LocaleEntity Locale { get; set; }
        public List<TranslatedTagEntity> TranslatedTags { get; set; }
    }

    public class TranslatedTagEntity : TagEntity
    {
        public Guid OriginalTagId { get; set; }
        public TagEntity OriginalTag { get; set; }
    }
}
