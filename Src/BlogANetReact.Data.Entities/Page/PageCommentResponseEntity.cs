using System;
using System.Collections.Generic;
using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Page
{
    public class PageCommentResponseEntity : Entity<long>
    {
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public string Comment { get; set; }
        public long ParentCommentId { get; set; }
        public PageCommentEntity ParentComment { get; set; }
        public List<PageCommentResponseEntity> Responses { get; set; }
        public long ParentResponseId { get; set; }
        public PageCommentResponseEntity ParentResponse { get; set; }
    }
}
