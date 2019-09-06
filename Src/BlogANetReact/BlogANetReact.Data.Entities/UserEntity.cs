﻿using BlogANetReact.Data.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;

namespace BlogANetReact.Data.Entities
{
    public class UserEntity : IdentityUser<Guid>, IEntity
    {
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Guid? ModifiedBy { get; set; }
        public AuthorEntity AuthorProfile { get; set; }
    }
}
