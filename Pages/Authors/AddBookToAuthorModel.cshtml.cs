using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuthorsBookCatalogue.Models;
using AuthorsBookCatalogue.Data;

namespace AuthorsBookCatalogue.Pages.Authors
{
    public class AddBookToAuthorModel : PageModel
    {
        private readonly BookStoreContext _context;

        public AddBookToAuthorModel(BookStoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public int SelectedAuthorId { get; set; }
        public IList<Author> Authors { get; set; } = default!;

        [BindProperty]
        public int SelectedBookId { get; set; }
        public IList<Book> Books { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            Authors = await _context.Authors.ToListAsync();
            Books = await _context.Books.ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Authors = await _context.Authors.ToListAsync();
                Books = await _context.Books.ToListAsync();
                return Page();
            }

            var author = await _context.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.AuthorId == SelectedAuthorId);
            var book = await _context.Books.FirstOrDefaultAsync(b => b.BookId == SelectedBookId);

            if (author == null || book == null)
            {
                return NotFound();
            }

            // Add the book to the author's list of books
            author.Books.Add(book);

            // Save changes to the database
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
