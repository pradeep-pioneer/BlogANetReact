using System;
using System.Collections.Generic;
using System.Text;
using BlogANetReact.Data.Entities;
using Microsoft.EntityFrameworkCore;
using BlogANetReact.Data.Entities.Page;
using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Post;
using BlogANetReact.Data.Entities.Auth;

namespace BlogANetReact.Data.Model
{
    public interface IBlogDbContext
    {
        DbSet<LocaleEntity> Locales { get; set; }
        DbSet<TagEntity> Tags { get; set; }
        DbSet<TranslatedTagEntity> TranslatedTags { get; set; }
        DbSet<LinkEntity> Links { get; set; }
        DbSet<TranslatedLinkEntity> TranslatedLinks { get; set; }

        #region [ Author ]
        DbSet<AuthorEntity> Authors { get; set; }
        DbSet<AuthorProfileEntity> AuthorProfiles { get; set; }
        DbSet<AuthorProfileLink> AuthorProfileLinks { get; set; }
        DbSet<AuthorTagEntity> AuthorTags { get; set; }
        #endregion

        #region [ Page ]
        DbSet<PageEntity> Pages { get; set; }
        DbSet<PageAuthorEntity> PageAuthors { get; set; }
        DbSet<PageCommentEntity> PageComments { get; set; }
        DbSet<PageTagEntity> PageTags { get; set; }
        DbSet<TranslatedPageEntity> TranslatedPages { get; set; }
        #endregion

        #region [ Post ]
        DbSet<PostEntity> Posts { get; set; }
        DbSet<PostAuthorEntity> PostAuthors { get; set; }
        DbSet<PostCommentEntity> PostComments { get; set; }
        DbSet<PostTagEntity> PostTags { get; set; }
        DbSet<TranslatedPostEntity> TranslatedPosts { get; set; }
        #endregion

        #region [ Auth ]
        DbSet<UserEntity> Users { get; set; }
        DbSet<RoleEntity> Roles { get; set; }
        #endregion
    }
}
