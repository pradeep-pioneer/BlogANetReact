using System;
namespace BlogANetReact.Data.Entities
{
    public class TranslatedTagEntity : TagEntity
    {
        public int OriginalTagId { get; set; }
        public TagEntity OriginalTag { get; set; }
    }
}
