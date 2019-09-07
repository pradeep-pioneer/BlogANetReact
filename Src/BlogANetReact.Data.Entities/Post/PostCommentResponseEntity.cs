using System.Collections.Generic;
using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Post
{
    public class PostCommentResponseEntity : Entity<int>
    {
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public string Comment { get; set; }
        public PostCommentEntity ParentComment { get; set; }
        public List<PostCommentResponseEntity> Responses { get; set; }
        public int ParentResponseId { get; set; }
        public PostCommentResponseEntity ParentResponse { get; set; }
    }
}
