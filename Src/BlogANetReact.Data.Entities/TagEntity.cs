using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;
using BlogANetReact.Data.Entities.Page;
using BlogANetReact.Data.Entities.Post;
using System;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities
{
    public class TagEntity : Entity<Guid>
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public Guid LocaleId { get; set; }
        public LocaleEntity Locale { get; set; }
        public List<TranslatedTagEntity> TranslatedTags { get; set; }

        public List<AuthorTagEntity> AuthorTags { get; set; }
        public List<PageTagEntity> PageTags { get; set; }
        public List<PostTagEntity> PostTags { get; set; }
    }
}
