using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Entities.Base
{
    public enum ContentState
    {
        Draft = 1,
        Scheduled = 2,
        Published = 3,
        Archived = 4,
        SoftDeleted = 5
    }

    public class ContentStateEntity: Entity<ContentState>
    {

    }

    public class ContentEntiity : Entity<Guid>
    {
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string BodyText { get; set; }
        public string BodyHtml { get; set; }
        public Guid LocaleId { get; set; } 
        public LocaleEntity Locale { get; set; }
        public string Slug { get; set; }
        public ContentState State { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Excerpt { get; set; }
    }
}
