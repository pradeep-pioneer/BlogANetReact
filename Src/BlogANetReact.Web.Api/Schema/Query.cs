using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogANetReact.Data.Entities;
using BlogANetReact.Repository;

namespace BlogANetReact.Web.Api.Schema
{
    public class Query
    {

        //ToDo: fix the DbContext being shared across calls from query;
        //ToDo: create a working structure and then refactor.
        ITagsRepository _tagsRepository;
        ILanguagesRepository _languagesRepository;
        public Query(ITagsRepository tagsRepository, ILanguagesRepository languagesRepository)
        {
            _tagsRepository = tagsRepository;
            _languagesRepository = languagesRepository;
        }

        public async Task<List<TagEntity>> Tags() => await _tagsRepository.GetAll();
        public async Task<List<LanguageEntity>> Languages() => await _languagesRepository.GetAll();
        public async Task<LanguageEntity> Language(int id) => (await _languagesRepository.GetAll()).FirstOrDefault(x => x.Id == id);
    }
}