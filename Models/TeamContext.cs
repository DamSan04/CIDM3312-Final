
using Microsoft.EntityFrameworkCore;

namespace CIDM3312_Final.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext (DbContextOptions<TeamContext> options)
            :base(options)
            {
            }
            public DbSet<Team> Team {get; set;} = default!;
    }
}