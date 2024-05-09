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
                                },
                                new Player {
                                    PlayerName = "Zekken",
                                    KDRatio = 3.0m,
                                    AvgCombatScore = 231,
                                    Role = "Duelist",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "Sacy",
                                    KDRatio = 1.8m,
                                    AvgCombatScore = 152,
                                    Role = "Initiator",
                                    Origin = "South America"
                                },
                                new Player {
                                    PlayerName = "Zellsis",
                                    KDRatio = 0.93m,
                                    AvgCombatScore = 135,
                                    Role = "Senteniel",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "JohnQT",
                                    KDRatio = 2.6m,
                                    AvgCombatScore = 182,
                                    Role = "IGL",
                                    Origin = "Morroco"
                                }


                            }
                        },
                        new Team 
                        {
                            TeamName = "NRG",
                            Region = "North America",
                            WinLoss = 1.5m,
                            Ranking = 3,
                            Players = new List<Player>{
                                new Player {

                                    PlayerName = "Crashies",
                                    KDRatio = 1.9m,
                                    AvgCombatScore = 179,
                                    Role = "Initiator",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "Victor",
                                    KDRatio = 2.7m,
                                    AvgCombatScore = 222,
                                    Role = "Duelist",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "Ethan",
                                    KDRatio = 0.8m,
                                    AvgCombatScore = 132,
                                    Role = "IGL",
                                    Origin = "South America"
                                },
                                new Player {
                                    PlayerName = "Marved",
                                    KDRatio = 1.7m,
                                    AvgCombatScore = 165,
                                    Role = "Flex",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "Demon1",
                                    KDRatio = 2.1m,
                                    AvgCombatScore = 182,
                                    Role = "Flex",
                                    Origin = "North America"
                                }


                            }
                        },
                        new Team 
                        {
                            TeamName = "Paper Rex",
                            Region = "Asia-Pacific",
                            WinLoss = 1.8m,
                            Ranking = 2,
                            Players = new List<Player>{
                                new Player {

                                    PlayerName = "mindfreak",
                                    KDRatio = 1.6m,
                                    AvgCombatScore = 144,
                                    Role = "Flex",
                                    Origin = "Indonesia"
                                },
                                new Player {
                                    PlayerName = "Jingg",
                                    KDRatio = 3.2m,
                                    AvgCombatScore = 256,
                                    Role = "Duelist",
                                    Origin = "Singapore"
                                },
                                new Player {
                                    PlayerName = "f0rsakeN",
                                    KDRatio = 3.0m,
                                    AvgCombatScore = 242,
                                    Role = "Smokes",
                                    Origin = "Indonesia"
                                },
                                new Player {
                                    PlayerName = "d4v41",
                                    KDRatio = 0.93m,
                                    AvgCombatScore = 170,
                                    Role = "Senteniel",
                                    Origin = "Malaysia"
                                },
                                new Player {
                                    PlayerName = "something",
                                    KDRatio = 3.1m,
                                    AvgCombatScore = 249,
                                    Role = "Flex",
                                    Origin = "Russia"
                                }


                            }
                        },
                        new Team 
                        {
                            TeamName = "100 Thieves",
                            Region = "North America",
                            WinLoss = 1.3m,
                            Ranking = 4,
                            Players = new List<Player>{
                                new Player {

                                    PlayerName = "Boostio",
                                    KDRatio = 1.7m,
                                    AvgCombatScore = 147,
                                    Role = "IGL",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "bang",
                                    KDRatio = 2.3m,
                                    AvgCombatScore = 211,
                                    Role = "Smokes",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "Cyro",
                                    KDRatio = 1.8m,
                                    AvgCombatScore = 122,
                                    Role = "Flex",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "eeiu",
                                    KDRatio = 0.93m,
                                    AvgCombatScore = 135,
                                    Role = "Senteniel",
                                    Origin = "North America"
                                },
                                new Player {
                                    PlayerName = "Asuna",
                                    KDRatio = 2.0m,
                                    AvgCombatScore = 132,
                                    Role = "Duelist",
                                    Origin = "North America"
                                }


                            }
                        },
                        new Team 
                        {
                            TeamName = "EDward Gaming",
                            Region = "China",
                            WinLoss = 1.0m,
                            Ranking = 5,
                            Players = new List<Player>{
                                new Player {

                                    PlayerName = "KangKang",
                                    KDRatio = 2.6m,
                                    AvgCombatScore = 177,
                                    Role = "Duelist",
                                    Origin = "China"
                                },
                                new Player {
                                    PlayerName = "Haodong",
                                    KDRatio = 2.4m,
                                    AvgCombatScore = 160,
                                    Role = "Flex",
                                    Origin = "China"
                                },
                                new Player {
                                    PlayerName = "nobody",
                                    KDRatio = 1.8m,
                                    AvgCombatScore = 142,
                                    Role = "Initiator",
                                    Origin = "China"
                                },
                                new Player {
                                    PlayerName = "Muggle",
                                    KDRatio = 0.98m,
                                    AvgCombatScore = 123,
                                    Role = "Senteniel",
                                    Origin = "China"
                                },
                                new Player {
                                    PlayerName = "Chichoo",
                                    KDRatio = 1.6m,
                                    AvgCombatScore = 152,
                                    Role = "IGL",
                                    Origin = "China"
                                }


                            }
                        }
                        

                    );

                    context.SaveChanges();
                    
                        
                    
                }
            
        }
    }
}