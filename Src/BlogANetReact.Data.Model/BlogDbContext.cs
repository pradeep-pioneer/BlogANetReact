using BlogANetReact.Data.Entities;
using Microsoft.EntityFrameworkCore;
using BlogANetReact.Data.Entities.Page;
using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Post;

namespace BlogANetReact.Data.Model
{
    public class BlogDbContext : DbContext, IBlogDbContext
    {
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<AuthorTagEntity> AuthorTags { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<LocaleEntity> Locales { get; set; }
        public DbSet<PageEntity> Pages { get; set; }
        public DbSet<PageTagEntity> PageTags { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<PostTagEntity> PostTags { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
    }
}
