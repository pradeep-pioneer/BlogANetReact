using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Entities
{
    public class LocaleEntity : Entity
    {
        public Guid Id { get; set; }
        public string LCID { get; set; }
        public string LocaleName { get; set; }

    }
}
