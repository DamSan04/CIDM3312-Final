using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace CIDM3312_Final.Models
{
    public class Player
    {
        
        public int PlayerId {get; set;}
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string PlayerName {get; set;} = string.Empty; 
        [Required]   
        public decimal KDRatio {get; set;}
        [Required]
        public int AvgCombatScore {get; set;}
        [Required]
        public string Role {get; set;} = string.Empty;
        [Required]
        public string Origin {get; set;} = string.Empty;
        [Required]
        public int TeamID {get; set;}
        [Required]
        public Team Team {get; set;} = null!;

        public override string ToString()
        {
            return $"{PlayerName} - {Role}";
        }
    }
}