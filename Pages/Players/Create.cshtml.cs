using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM3312_Final.Models;

namespace CIDM3312_Final.Pages.Players
{
    public class CreateModel : PageModel
    {
        private readonly CIDM3312_Final.Models.PlayerContext _context;

        public CreateModel(CIDM3312_Final.Models.PlayerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TeamID"] = new SelectList(_context.Team, "TeamID", "TeamID");
            return Page();
        }

        [BindProperty]
        public Player Player { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Player.Add(Player);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
