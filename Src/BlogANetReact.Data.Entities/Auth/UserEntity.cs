using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;

namespace BlogANetReact.Data.Entities.Auth
{
    public class UserEntity : IdentityUser<int>, IEntity
    {
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public AuthorEntity Author { get; set; }
    }
}
