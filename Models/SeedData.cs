using Microsoft.EntityFrameworkCore;

namespace CIDM3312_Final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlayerContext(
                serviceProvider.GetRequiredService
                <DbContextOptions<PlayerContext>>()))
                {
                    if (context == null || context.Team == null)
                    {
                        throw new ArgumentException("Null RazorPagesPlayerContext");
                    }

                    if (context.Team.Any())
                    {
                        return;
                    }

                    context.Team.AddRange(
                        new Team 
                        {
                            TeamName = "Sentinels",
                            Region = "North America",
                            WinLoss = 2.0m,
                            Ranking = 1,
                            Players = new List<Player>{
                                new Player {

                                    PlayerName = "Tenz",
                                    KDRatio = 2.7m,
                                    AvgCombatScore = 187,
                                    Role = "Flex",
                                    Origin = "North America"



                                }
                            }
                        }
                        

                    );

                    context.SaveChanges();
                    
                        
                    
                }
            
        }
    }
}