﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tudose_Nicholas_Lab3.Data;
using Tudose_Nicholas_Lab3.Models;

namespace Tudose_Nicholas_Lab3.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Tudose_Nicholas_Lab3.Data.Tudose_Nicholas_Lab3Context _context;

        public DetailsModel(Tudose_Nicholas_Lab3.Data.Tudose_Nicholas_Lab3Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
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
