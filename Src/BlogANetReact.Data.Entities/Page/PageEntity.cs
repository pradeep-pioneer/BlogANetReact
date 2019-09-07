using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities.Page
{
    public class PageCommentEntity : CommentEntity
    {
        public int PageId { get; set; }
        public PageEntity Page { get; set; }
    }
    public class PageEntity : ContentEntiity
    {
        public string CanonicalUrl { get; set; }
        public List<PageTagEntity> PageTags { get; set; }
        public List<PageCommentEntity> Comments { get; set; }
        public List<PageAuthorEntity> PageAuthors { get; set; }
    }

    public class TranslatedPageEntity : PageEntity
    {
        public Guid OriginalPageId { get; set; }
        public PageEntity OriginalPage { get; set; }
    }
}
