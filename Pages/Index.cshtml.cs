using AuthorsBookCatalogue.Data;
using AuthorsBookCatalogue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AuthorsBookCatalogue.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BookStoreContext _context;

        public IndexModel(ILogger<IndexModel> logger, BookStoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;
        public IList<Author> Author { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Book = await _context.Books.ToListAsync();
            }
            if (_context.Authors != null)
            {
                Author = await _context.Authors.ToListAsync();
            }
        }
    }
}