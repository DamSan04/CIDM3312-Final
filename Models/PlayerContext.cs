using Microsoft.EntityFrameworkCore;

namespace CIDM3312_Final.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext (DbContextOptions<PlayerContext> options)
            :base(options)
            {
            }
            public DbSet<Player> Player {get; set;} = default!;
    }
}