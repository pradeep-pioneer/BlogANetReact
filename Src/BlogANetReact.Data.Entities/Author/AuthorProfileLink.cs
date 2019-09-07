using BlogANetReact.Data.Entities.Base;

namespace BlogANetReact.Data.Entities.Author
{
    public class AuthorProfileLink : Entity
    {
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; }
        public int LinkId { get; set; }
        public LinkEntity Link { get; set; }
    }
}
