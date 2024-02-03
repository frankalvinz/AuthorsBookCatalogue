using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AuthorsBookCatalogue.Models;
using AuthorsBookCatalogue.Data;

namespace AuthorsBookCatalogue.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly BookStoreContext _context;

        public DetailsModel(BookStoreContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books.Include(b => b.Authors).FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }

            return Page();
        }
    }
}
