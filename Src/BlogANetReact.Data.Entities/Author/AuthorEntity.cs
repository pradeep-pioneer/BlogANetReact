using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;
using BlogANetReact.Data.Entities.Page;
using BlogANetReact.Data.Entities.Post;
using BlogANetReact.Data.Entities.Auth;

namespace BlogANetReact.Data.Entities.Author
{
    public class AuthorEntity : Entity<int>
    {
        public AuthorProfileEntity AuthorProfile { get; set; }
        public List<AuthorProfileLink> AuthorProfileLinks { get; set; }
        public List<AuthorTagEntity> AuthorTags { get; set; }
        public List<PageAuthorEntity> Pages { get; set; }
        public List<PostAuthorEntity> Posts { get; set; }
        public Guid UserId { get; set; }
        public UserEntity User { get; set; }
        public List<CommentEntity> Comments { get; set; }
    }
}
