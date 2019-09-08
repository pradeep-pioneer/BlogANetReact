using System;
using System.Collections.Generic;
using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Page
{
    public class PageCommentEntity : Entity<long>
    {
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public string Comment { get; set; }
        public List<PageCommentResponseEntity> CommentResponses { get; set; }
        public long PageId { get; set; }
        public PageEntity Page { get; set; }
    }
}
