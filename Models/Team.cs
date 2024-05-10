using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_Final.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        [Required]
        public string TeamName { get; set; } = string.Empty;
        [Required]
        public string Region { get; set; } = string.Empty;
        [Required]
        public decimal WinLoss { get; set; }
        [Required]
        public int Ranking { get; set; }
        public List<Player> Players { get; set; } = null!;

        public override string ToString()
        {
            return $"{TeamName}";
        }

    }
}