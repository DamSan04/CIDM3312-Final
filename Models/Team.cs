using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace CIDM3312_Final.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public decimal WinLoss { get; set; }
        public int Ranking { get; set; }
        public List<Player> Players { get; set; } = null!;

        public override string ToString()
        {
            return $"{TeamName}";
        }

    }
}