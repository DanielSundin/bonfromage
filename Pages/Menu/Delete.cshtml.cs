using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BonFromage.Models;

namespace BonFromage.Pages.Menu
{
    public class DeleteModel : PageModel
    {
        private readonly BonFromage.Data.BonFromageContext _context;

        public DeleteModel(BonFromage.Data.BonFromageContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MenuItem MenuItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MenuItem = await _context.MenuItem.FirstOrDefaultAsync(m => m.ID == id);

            if (MenuItem == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MenuItem = await _context.MenuItem.FindAsync(id);

            if (MenuItem != null)
            {
                _context.MenuItem.Remove(MenuItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
