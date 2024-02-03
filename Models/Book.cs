namespace AuthorsBookCatalogue.Models
{
    public class Book
    {
        public Book()
        {
            // Initialize the Authors property in the constructor
            Authors = new List<Author>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Publisher { get; set; }
        public string BookType { get; set; }
        public string Language { get; set; }
        public string ImageUrl { get; set; }
        public string Dimensions { get; set; }
        public int? Rating { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
