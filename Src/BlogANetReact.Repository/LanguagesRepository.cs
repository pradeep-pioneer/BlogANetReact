using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogANetReact.Data.Entities;
using BlogANetReact.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogANetReact.Repository
{
    public interface ILanguagesRepository
    {
        Task<List<LanguageEntity>> GetAll();
    }
    public class LanguagesRepository : ILanguagesRepository
    {
        private readonly BlogDbContext _blogDbContext;
        public LanguagesRepository(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public Task<List<LanguageEntity>> GetAll()
        {
            return _blogDbContext.Languages.Include(x=>x.Locales).ToListAsync();
        }
    }
}
