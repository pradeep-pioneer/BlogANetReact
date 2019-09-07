using System;
namespace BlogANetReact.Data.Entities
{
    public class TranslatedTagEntity : TagEntity
    {
        public Guid OriginalTagId { get; set; }
        public TagEntity OriginalTag { get; set; }
    }
}
