namespace AuthorsBookCatalogue.Models
{
    public class Author
    {
        public Author()
        {
            // Initialize the Books property in the constructor
            Books = new List<Book>();
        }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
