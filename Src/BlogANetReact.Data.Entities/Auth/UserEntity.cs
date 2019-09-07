using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;

namespace BlogANetReact.Data.Entities.Auth
{
    public class UserEntity : IdentityUser<Guid>, IEntity
    {
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Guid? ModifiedBy { get; set; }
        public AuthorEntity Author { get; set; }
    }
}
