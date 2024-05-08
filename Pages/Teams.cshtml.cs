using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_Final.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CIDM3312_Final.Pages;


public class TeamsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public TeamsModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
