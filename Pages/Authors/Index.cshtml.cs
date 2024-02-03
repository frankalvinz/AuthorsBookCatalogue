using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AuthorsBookCatalogue.Models;
using AuthorsBookCatalogue.Data;

namespace AuthorsBookCatalogue.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly BookStoreContext _context;

        public IndexModel(BookStoreContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Author = await _context.Authors.ToListAsync();
            }
        }
    }
}
