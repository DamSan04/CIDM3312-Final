using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_Final.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CIDM3312_Final.Pages;


public class TeamModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly PlayerContext _context;
    public List<Team> Teams {get; set;} = default!;

    public TeamModel(PlayerContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Teams = _context.Team.ToList();

    }
}
