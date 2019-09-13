using BlogANetReact.Data.Entities;
using BlogANetReact.Repository;
using BlogANetReact.Web.Api.Types;
using GraphQL.Types;

namespace BlogANetReact.Web.Api.Schemas
{
    
    public class QueryObject : ObjectGraphType<object>
    {
        private readonly ITagsRepository _tagsRepository;
        public QueryObject(ITagsRepository tagsRepository)
        {
            _tagsRepository = tagsRepository;
            this.Name = "BlogANetReact Query Object";
            this.Description = "The query type, represents all of the entry points into our object graph.";

            this.FieldAsync<TagObject, TagEntity>("Tags");
        }
    }
}