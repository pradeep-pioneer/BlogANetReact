using BlogANetReact.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace BlogANetReact.Data.Entities
{
    public class AuthorProfileLink : Entity
    {
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public int LinkId { get; set; }
        public LinkEntity Link { get; set; }
    }
    public class AuthorProfileEntity : Entity<int>
    {
        public string ProfileImage { get; set; }
        public string CoverImage { get; set; }
        public string PenName { get; set; }
        public string Introduction { get; set; }
        public Guid LocaleId { get; set; }
        public LocaleEntity Locale { get; set; }
        public List<TranslatedAuthorProfile> TranslatedAuthorProfiles { get; set; }
    }
    public class TranslatedAuthorProfile : AuthorProfileEntity
    {
        public Guid OriginalAuthorProfileId { get; set; }
        public AuthorProfileEntity OriginalAuthorProfile { get; set; }
    }
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
