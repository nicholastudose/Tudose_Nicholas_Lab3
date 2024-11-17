using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tudose_Nicholas_Lab3.Data;
using Tudose_Nicholas_Lab3.Models;

namespace Tudose_Nicholas_Lab3.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Tudose_Nicholas_Lab3.Data.Tudose_Nicholas_Lab3Context _context;

        public CreateModel(Tudose_Nicholas_Lab3.Data.Tudose_Nicholas_Lab3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
