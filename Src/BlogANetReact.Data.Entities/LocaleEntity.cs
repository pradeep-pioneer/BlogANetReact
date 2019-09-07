using BlogANetReact.Data.Entities.Base;
using System;

namespace BlogANetReact.Data.Entities
{
    public class LocaleEntity : Entity
    {
        public Guid Id { get; set; }
        public string LCID { get; set; }
        public string LocaleName { get; set; }
        public string Slug { get; set; }
    }
}
