using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Entities
{
    public class AuthorTagEntity : Entity<int>
    {
        public int TagId { get; set; }
        public TagEntity Tag { get; set; }
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
    }
}
