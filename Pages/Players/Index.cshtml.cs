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
        public string CsSort { get; set; } = null!;
        public string CurrentFilter { get; set; } = null!;
        public string CurrentSort { get; set; } = null!;

        public IList<Player> Player { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex)
        {
            CsSort = String.IsNullOrEmpty(sortOrder) ? "cs_desc" : "";
            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            IQueryable<Player> playerKD = from p in _context.Player select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                playerKD = playerKD.Where(p => p.PlayerName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "cs_desc":
                playerKD = playerKD.OrderByDescending(p => p.AvgCombatScore);
                break;

                default:
                playerKD = playerKD.OrderBy(p => p.AvgCombatScore);
                break;

            }
            int pageSize = 3;
            Player = await PaginatedList<Player>.CreateAsync(playerKD.AsNoTracking(), pageIndex ?? 1, pageSize);

            Player = await playerKD.AsNoTracking().ToListAsync();

            Player = await _context.Player.Include(p => p.Team).ToListAsync();
        }
    }
}
