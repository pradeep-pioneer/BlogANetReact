using BlogANetReact.Data.Entities.Base;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities
{
    public class CommentResponseEntity : CommentEntity
    {
        public int ParentId { get; set; }
        public CommentEntity Parent { get; set; }
    }
    public class CommentEntity : Entity<int>
    {
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public string Comment { get; set; }
        public List<CommentResponseEntity> CommentResponses { get; set; }
    }
}
