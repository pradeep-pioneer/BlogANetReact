using BlogANetReact.Data.Entities;
using BlogANetReact.Data.Entities.Base;
using BlogANetReact.Repository;
using GraphQL.Types;

namespace BlogANetReact.Web.Api.Types
{
    public class EntityInterface : InterfaceGraphType<Entity<int>>
    {
        public EntityInterface()
        {
            this.Name = "Entity";
            this.Description = "Base interface for all entities";
            this.Field(x => x.Id, type: typeof(NonNullGraphType<IntGraphType>))
                .Description("Id of the entity");
            this.Field(x => x.CreatedBy, type: typeof(NonNullGraphType<IntGraphType>))
                .Description("Id of the user who created this entity");
            this.Field(x => x.CreatedOn, type: typeof(NonNullGraphType<DateTimeGraphType>))
                .Description("Timestamp of creation of this entity");
            this.Field(x => x.ModifiedBy, type: typeof(IntGraphType), nullable: true)
                .Description("Id of the user who created this entity");
            this.Field(x => x.ModifiedOn, type: typeof(DateTimeGraphType), nullable: true)
                .Description("Timestamp of creation of this entity");
        }
    }
    public class TagObject : ObjectGraphType<TagEntity>
    {
        private readonly ITagsRepository _tagsRepository;
        public TagObject(ITagsRepository tagsRepository)
        {
            _tagsRepository = tagsRepository;
            this.Name = "Tag";
            this.Description = "A tag represents a top level object that can used to categorize posts, authors and pages.";
            this.Field(x => x.Name, type: typeof(NonNullGraphType<StringGraphType>), nullable: false)
                .Description("Name of the tag entity");
            this.Interface<EntityInterface>();
        }
    }
}