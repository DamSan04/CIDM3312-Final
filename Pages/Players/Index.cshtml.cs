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
    public class IndexModel : PageModel
    {
        private readonly CIDM3312_Final.Models.PlayerContext _context;

        public IndexModel(CIDM3312_Final.Models.PlayerContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Player = await _context.Player
                .Include(p => p.Team).ToListAsync();
        }
    }
}
