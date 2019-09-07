using BlogANetReact.Data.Entities.Base;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities.Page
{
    public class PageEntity : ContentEntiity
    {
        public string CanonicalUrl { get; set; }
        public List<PageTagEntity> PageTags { get; set; }
        public List<PageCommentEntity> Comments { get; set; }
        public List<PageAuthorEntity> PageAuthors { get; set; }
        public List<TranslatedPageEntity> Translations { get; set; }
    }
}
