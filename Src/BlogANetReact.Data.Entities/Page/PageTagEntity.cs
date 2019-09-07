using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Entities.Page
{
    public class PageTagEntity : Entity<int>
    {
        public Guid TagId { get; set; }
        public TagEntity Tag { get; set; }
        public Guid PageId { get; set; }
        public PageEntity Page { get; set; }
    }
}
