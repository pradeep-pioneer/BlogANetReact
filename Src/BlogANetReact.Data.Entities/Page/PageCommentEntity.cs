using System;
namespace BlogANetReact.Data.Entities.Page
{
    public class PageCommentEntity : CommentEntity
    {
        public int PageId { get; set; }
        public PageEntity Page { get; set; }
    }
}
