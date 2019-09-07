using System;
namespace BlogANetReact.Data.Entities.Post
{
    public class TranslatedPostEntity : PostEntity
    {
        public Guid OriginalPostId { get; set; }
        public PostEntity OriginalPost { get; set; }
    }
}
