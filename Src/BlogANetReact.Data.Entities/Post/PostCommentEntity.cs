using System.Collections.Generic;
using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Post
{
    public class PostCommentEntity : Entity<long>
    {
        public long PostId { get; set; }
        public PostEntity Post { get; set; }
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public string Comment { get; set; }
        public List<PostCommentResponseEntity> CommentResponses { get; set; }
    }
}
