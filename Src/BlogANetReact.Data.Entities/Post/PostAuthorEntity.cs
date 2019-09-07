using System;
using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Post
{
    public class PostAuthorEntity : Entity<int>
    {
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public Guid PostId { get; set; }
        public PostEntity Post { get; set; }
    }
}
