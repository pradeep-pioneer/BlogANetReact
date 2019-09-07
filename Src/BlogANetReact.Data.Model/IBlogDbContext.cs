using System;
using System.Collections.Generic;
using System.Text;
using BlogANetReact.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogANetReact.Data.Model
{
    public interface IBlogDbContext
    {
        DbSet<AuthorEntity> Authors { get; set; }
        DbSet<AuthorTagEntity> AuthorTags { get; set; }
        DbSet<CommentEntity> Comments { get; set; }
        DbSet<LocaleEntity> Locales { get; set; }
        DbSet<PageEntity> Pages { get; set; }
        DbSet<PageTagEntity> PageTags { get; set; }
        DbSet<PostEntity> Posts { get; set; }
        DbSet<PostTagEntity> PostTags { get; set; }
        DbSet<TagEntity> Tags { get; set; }
    }
}
