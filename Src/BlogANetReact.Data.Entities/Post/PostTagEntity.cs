using System;
using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Post
{
    public class PostTagEntity : Entity<int>
    {
        public Guid TagId { get; set; }
        public TagEntity Tag { get; set; }
        public Guid PostId { get; set; }
        public PostEntity Post { get; set; }
    }
}
