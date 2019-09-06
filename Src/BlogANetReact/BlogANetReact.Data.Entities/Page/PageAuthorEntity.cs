using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Entities.Page
{
    public class PageAuthorEntity : Entity<int>
    {
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public Guid PageId { get; set; }
        public PageEntity Page { get; set; }
    }
}
