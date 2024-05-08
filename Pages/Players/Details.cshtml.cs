using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_Final.Models;

namespace CIDM3312_Final.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly CIDM3312_Final.Models.PlayerContext _context;

        public DetailsModel(CIDM3312_Final.Models.PlayerContext context)
        {
            _context = context;
        }

        public Player Player { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Player.FirstOrDefaultAsync(m => m.PlayerId == id);
            if (player == null)
            {
                return NotFound();
            }
            else
            {
                Player = player;
            }
            return Page();
        }
    }
}
