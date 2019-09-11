using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogANetReact.Data.Entities;
using BlogANetReact.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogANetReact.Repository
{
    public interface ITagsRepository
    {
        Task<List<TagEntity>> GetAll();
    }
    public class TagsRepository : ITagsRepository
    {
        private readonly BlogDbContext _blogDbContext;
        public TagsRepository(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public Task<List<TagEntity>> GetAll()
        {
            return _blogDbContext.Tags.ToListAsync();
        }
    }
}
