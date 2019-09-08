using System;
using BlogANetReact.Data.Entities;
using BlogANetReact.Data.Entities.Auth;
using BlogANetReact.Data.Entities.Author;
using BlogANetReact.Data.Entities.Page;
using BlogANetReact.Data.Entities.Post;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogANetReact.Data.Model
{
    public class BlogDbContext : IdentityDbContext<UserEntity, RoleEntity, int>, IBlogDbContext
    {
        public DbSet<LocaleEntity> Locales { get; set; }
        public DbSet<LanguageEntity> Languages { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<TranslatedTagEntity> TranslatedTags { get; set; }
        public DbSet<LinkEntity> Links { get; set; }
        public DbSet<TranslatedLinkEntity> TranslatedLinks { get; set; }

        #region [ Author ]
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<AuthorProfileEntity> AuthorProfiles { get; set; }
        public DbSet<TranslatedAuthorProfileEntity> TranslatedAuthorProfiles { get; set; }
        public DbSet<AuthorProfileLink> AuthorProfileLinks { get; set; }
        public DbSet<AuthorTagEntity> AuthorTags { get; set; }
        #endregion

        #region [ Page ]
        public DbSet<PageEntity> Pages { get; set; }
        public DbSet<PageAuthorEntity> PageAuthors { get; set; }
        public DbSet<PageCommentEntity> PageComments { get; set; }
        public DbSet<PageTagEntity> PageTags { get; set; }
        public DbSet<TranslatedPageEntity> TranslatedPages { get; set; }
        #endregion

        #region [ Post ]
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<PostAuthorEntity> PostAuthors { get; set; }
        public DbSet<PostCommentEntity> PostComments { get; set; }
        public DbSet<PostTagEntity> PostTags { get; set; }
        public DbSet<TranslatedPostEntity> TranslatedPosts { get; set; }
        #endregion

        public BlogDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            SetupLocaleMasters(builder);
            SetupLinkMasters(builder);
            SetupTagMasters(builder);
            SetupAuthorEntities(builder);
            SetupPageEntities(builder);
            SetupPostEntities(builder);
            SetupAuthEntities(builder);
        }

        private void SetupAuthEntities(ModelBuilder builder)
        {
            builder.Entity<UserEntity>()
                .HasKey(x => x.Id);
            builder.Entity<UserEntity>()
                .HasIndex(x => x.Active);
            builder.Entity<UserEntity>()
                .HasIndex(x => new { x.PhoneNumber, x.Email, x.NormalizedEmail });

            builder.Entity<RoleEntity>()
                .HasKey(x => x.Id);
            builder.Entity<RoleEntity>()
                .HasIndex(x => x.Active);
            builder.Entity<RoleEntity>()
                .HasIndex(x => new { x.Name, x.NormalizedName });
        }

        private void SetupPostEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostAuthorEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PostAuthorEntity>()
                .HasIndex(x => new { x.AuthorId, x.PostId })
                .IsUnique(true);
            modelBuilder.Entity<PostAuthorEntity>()
                .HasOne(x => x.Author).WithMany(x => x.Posts);
            modelBuilder.Entity<PostAuthorEntity>()
                .HasOne(x => x.Post).WithMany(x => x.PostAuthors);

            modelBuilder.Entity<PostCommentEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PostCommentEntity>()
                .HasOne(x => x.Post).WithMany(x => x.Comments);
            modelBuilder.Entity<PostCommentEntity>()
                .HasMany(x => x.CommentResponses)
                .WithOne(x => x.ParentComment);
            modelBuilder.Entity<PostCommentEntity>()
                .HasOne(x => x.Author).WithMany(x => x.PostComments);

            modelBuilder.Entity<PostCommentResponseEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PostCommentResponseEntity>()
                .HasOne(x => x.Author).WithMany(x => x.PostCommentResponses);
            modelBuilder.Entity<PostCommentResponseEntity>()
                .HasOne(x => x.ParentComment).WithMany(x => x.CommentResponses);
            modelBuilder.Entity<PostCommentResponseEntity>()
                .HasMany(x => x.Responses).WithOne(x => x.ParentResponse);

            modelBuilder.Entity<PostTagEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PostTagEntity>()
                .HasIndex(x => new { x.PostId, x.TagId }).IsUnique(true);
            modelBuilder.Entity<PostTagEntity>()
                .HasOne(x => x.Tag).WithMany(x => x.PostTags);
            modelBuilder.Entity<PostTagEntity>()
                .HasOne(x => x.Post).WithMany(x => x.PostTags);

            modelBuilder.Entity<PostEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PostEntity>()
                .HasIndex(x => new { x.Slug, x.LocaleId }).IsUnique();
            modelBuilder.Entity<PostEntity>()
                .HasDiscriminator<int>("PostType")
                .HasValue<PostEntity>(1)
                .HasValue<TranslatedPostEntity>(2);
            modelBuilder.Entity<PostEntity>()
                .HasMany(x => x.PostTags).WithOne(x => x.Post);
            modelBuilder.Entity<PostEntity>()
                .HasMany(x => x.Comments).WithOne(x => x.Post);
            modelBuilder.Entity<PostEntity>()
                .HasMany(x => x.PostAuthors).WithOne(x => x.Post);
            modelBuilder.Entity<PostEntity>()
                .HasMany(x => x.Translations).WithOne(x => x.OriginalPost);
            modelBuilder.Entity<TranslatedPostEntity>()
                .HasOne(x => x.OriginalPost).WithMany(x => x.Translations);
        }

        private void SetupPageEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PageAuthorEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PageAuthorEntity>()
                .HasIndex(x => new { x.AuthorId, x.PageId })
                .IsUnique(true);
            modelBuilder.Entity<PageAuthorEntity>()
                .HasOne(x => x.Author).WithMany(x => x.Pages);
            modelBuilder.Entity<PageAuthorEntity>()
                .HasOne(x => x.Page).WithMany(x => x.PageAuthors);

            modelBuilder.Entity<PageCommentEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PageCommentEntity>()
                .HasOne(x => x.Page).WithMany(x => x.Comments);
            modelBuilder.Entity<PageCommentEntity>()
                .HasMany(x => x.CommentResponses)
                .WithOne(x => x.ParentComment);
            modelBuilder.Entity<PageCommentEntity>()
                .HasOne(x => x.Author).WithMany(x => x.PageComments);

            modelBuilder.Entity<PageCommentResponseEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PageCommentResponseEntity>()
                .HasOne(x => x.Author).WithMany(x => x.PageCommentResponses);
            modelBuilder.Entity<PageCommentResponseEntity>()
                .HasOne(x => x.ParentComment).WithMany(x => x.CommentResponses);
            modelBuilder.Entity<PageCommentResponseEntity>()
                .HasMany(x => x.Responses).WithOne(x => x.ParentResponse);

            modelBuilder.Entity<PageTagEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PageTagEntity>()
                .HasIndex(x => new { x.PageId, x.TagId }).IsUnique(true);
            modelBuilder.Entity<PageTagEntity>()
                .HasOne(x => x.Tag).WithMany(x => x.PageTags);
            modelBuilder.Entity<PageTagEntity>()
                .HasOne(x => x.Page).WithMany(x => x.PageTags);

            modelBuilder.Entity<PageEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PageEntity>()
                .HasIndex(x => new { x.Slug, x.LocaleId }).IsUnique();
            modelBuilder.Entity<PageEntity>()
                .HasDiscriminator<int>("PageType")
                .HasValue<PageEntity>(1)
                .HasValue<TranslatedPageEntity>(2);
            modelBuilder.Entity<PageEntity>()
                .HasMany(x => x.PageTags).WithOne(x => x.Page);
            modelBuilder.Entity<PageEntity>()
                .HasMany(x => x.Comments).WithOne(x => x.Page);
            modelBuilder.Entity<PageEntity>()
                .HasMany(x => x.PageAuthors).WithOne(x => x.Page);
            modelBuilder.Entity<PageEntity>()
                .HasMany(x => x.Translations).WithOne(x => x.OriginalPage);
            modelBuilder.Entity<TranslatedPageEntity>()
                .HasOne(x => x.OriginalPage).WithMany(x => x.Translations);
        }

        private void SetupAuthorEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorProfileLink>()
                .HasKey(x => new { x.AuthorId, x.LinkId });
            modelBuilder.Entity<AuthorProfileLink>()
                .HasOne(x => x.Author).WithMany(x => x.AuthorProfileLinks);
            modelBuilder.Entity<AuthorProfileLink>()
                .HasOne(x => x.Link).WithMany(x => x.AuthorProfileLinks);

            modelBuilder.Entity<AuthorProfileEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<AuthorProfileEntity>()
                .HasIndex(x => new { x.LocaleId, x.PenName });
            modelBuilder.Entity<AuthorProfileEntity>()
                .HasOne(x => x.Locale).WithMany(x => x.AuthorProfiles);
            modelBuilder.Entity<AuthorProfileEntity>()
                .HasOne(x => x.Author).WithOne(x => x.AuthorProfile);
            modelBuilder.Entity<AuthorProfileEntity>()
                .HasMany(x => x.TranslatedAuthorProfiles).WithOne(x => x.OriginalAuthorProfile);
            modelBuilder.Entity<AuthorProfileEntity>()
                .HasDiscriminator<int>("ProfileType")
                .HasValue<AuthorProfileEntity>(1)
                .HasValue<TranslatedAuthorProfileEntity>(2);
            modelBuilder.Entity<TranslatedAuthorProfileEntity>()
                .HasOne(x => x.OriginalAuthorProfile).WithMany(x => x.TranslatedAuthorProfiles);

            modelBuilder.Entity<AuthorTagEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<AuthorTagEntity>()
                .HasIndex(x => new { x.TagId, x.AuthorId })
                .IsUnique();
            modelBuilder.Entity<AuthorTagEntity>()
                .HasOne(x => x.Author).WithMany(x => x.AuthorTags);
            modelBuilder.Entity<AuthorTagEntity>()
                .HasOne(x => x.Tag).WithMany(x => x.AuthorTags);

            modelBuilder.Entity<AuthorEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<AuthorEntity>()
                .HasOne(x => x.User).WithOne(x => x.Author);
            modelBuilder.Entity<AuthorEntity>()
                .HasOne(x => x.AuthorProfile).WithOne(x => x.Author);
            modelBuilder.Entity<AuthorEntity>()
                .HasMany(x => x.Posts).WithOne(x => x.Author);
            modelBuilder.Entity<AuthorEntity>()
                .HasMany(x => x.Pages).WithOne(x => x.Author);
            modelBuilder.Entity<AuthorEntity>()
                .HasMany(x => x.PageComments).WithOne(x => x.Author);
            modelBuilder.Entity<AuthorEntity>()
                .HasMany(x => x.PageCommentResponses).WithOne(x => x.Author);
            modelBuilder.Entity<AuthorEntity>()
                .HasMany(x => x.PostComments).WithOne(x => x.Author);
        }

        private void SetupLocaleMasters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocaleEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<LocaleEntity>()
                .HasIndex(x => new { x.LCID, x.LocaleName, x.Slug, x.Active })
                .IsUnique();
            modelBuilder.Entity<LocaleEntity>()
                .HasMany(x => x.Tags).WithOne(x => x.Locale);
            modelBuilder.Entity<LocaleEntity>()
                .HasMany(x => x.Links).WithOne(x => x.Locale);
            modelBuilder.Entity<LocaleEntity>()
                .HasOne(x => x.Language).WithMany(x => x.Locales);

            modelBuilder.Entity<LanguageEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<LanguageEntity>()
                .HasIndex(x => new { x.LanguageCode })
                .IsUnique();
            modelBuilder.Entity<LanguageEntity>()
                .HasIndex(x => new { x.Active, x.LanguageName });
            modelBuilder.Entity<LanguageEntity>()
                .HasMany(x => x.Locales).WithOne(x => x.Language);
        }

        private void SetupLinkMasters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LinkEntity>()
                .HasDiscriminator<int>("LinkType")
                .HasValue<LinkEntity>(1)
                .HasValue<TranslatedLinkEntity>(2);

            modelBuilder.Entity<LinkEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<LinkEntity>()
                .HasMany(x => x.TranslatedLinks).WithOne(x => x.OriginalLink);

            modelBuilder.Entity<LinkEntity>()
                .HasMany(x => x.AuthorProfileLinks).WithOne(x => x.Link);

            modelBuilder.Entity<TranslatedLinkEntity>()
                .HasBaseType<LinkEntity>();
            modelBuilder.Entity<TranslatedLinkEntity>()
                .HasOne(x => x.OriginalLink).WithMany(x => x.TranslatedLinks);
        }

        private void SetupTagMasters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagEntity>()
                .HasDiscriminator<int>("TagType")
                .HasValue<TagEntity>(1)
                .HasValue<TranslatedTagEntity>(2);
            modelBuilder.Entity<TagEntity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<TagEntity>()
                .HasOne(x => x.Locale).WithMany(x => x.Tags);
            modelBuilder.Entity<TagEntity>()
                .HasMany(x => x.TranslatedTags).WithOne(x => x.OriginalTag);

            modelBuilder.Entity<TranslatedTagEntity>()
                .HasBaseType<TagEntity>();
            modelBuilder.Entity<TranslatedTagEntity>()
                .HasOne(x => x.OriginalTag).WithMany(x => x.TranslatedTags);
        }
    }
}
