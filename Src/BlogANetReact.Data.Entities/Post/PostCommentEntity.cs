using System;
namespace BlogANetReact.Data.Entities.Post
{
    public class PostCommentEntity : CommentEntity
    {
        public int PageId { get; set; }
        public PostEntity Page { get; set; }
    }
}
