using System;
using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Post
{
    public class PostTagEntity : Entity<int>
    {
        public int TagId { get; set; }
        public TagEntity Tag { get; set; }
        public long PostId { get; set; }
        public PostEntity Post { get; set; }
    }
}
