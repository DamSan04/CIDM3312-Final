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
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set; } = 1;
        public int PageSize { get; set;} = 10;

        public IList<Player> Player { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            CsSort = String.IsNullOrEmpty(sortOrder) ? "cs_desc" : "";
            CurrentFilter = searchString;
            

            IQueryable<Player> playerKD = from p in _context.Player.Include(p => p.Team) select p;
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
            
            Player = await _context.Player.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            Player = await playerKD.AsNoTracking().ToListAsync();

            
        }
    }
}
