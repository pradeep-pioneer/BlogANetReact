using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities.Post
{
    public class PostEntity : ContentEntiity
    {
        public string CanonicalUrl { get; set; }
        public List<PostTagEntity> PostTags { get; set; }
        public List<PostCommentEntity> Comments { get; set; }
        public List<PostAuthorEntity> PostAuthors { get; set; }
        public List<TranslatedPostEntity> Translations { get; set; }
    }
}
