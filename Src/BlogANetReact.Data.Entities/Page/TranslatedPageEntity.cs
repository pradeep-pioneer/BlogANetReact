using System;
namespace BlogANetReact.Data.Entities.Page
{
    public class TranslatedPageEntity : PageEntity
    {
        public Guid OriginalPageId { get; set; }
        public PageEntity OriginalPage { get; set; }
    }
}
