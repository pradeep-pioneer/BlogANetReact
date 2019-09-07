using System;
namespace BlogANetReact.Data.Entities.Author
{
    public class TranslatedAuthorProfileEntity : AuthorProfileEntity
    {
        public Guid OriginalAuthorProfileId { get; set; }
        public AuthorProfileEntity OriginalAuthorProfile { get; set; }
    }
}
