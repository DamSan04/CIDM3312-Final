using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace CIDM3312_Final.Models
{
    public class Player
    {
        public int PlayerId {get; set;}
        public string PlayerName {get; set;} = string.Empty;    
        public decimal KDRatio {get; set;}
        public int AvgCombatScore {get; set;}
        public string Role {get; set;} = string.Empty;
        public string Origin {get; set;} = string.Empty;
        public int TeamID {get; set;}
        public Team Team {get; set;} = null!;

        public override string ToString()
        {
            return $"{PlayerName} - {Role}";
        }
    }
}