using System.ComponentModel.DataAnnotations;

namespace FootBallLeagueManagement.Models
{
    public class FootballLeague
    {
        [Key]
        public int MatchId { get; set; }
        [Required]
        public string? TeamName1 { get; set; }
        [Required]
        public string? TeamName2 { get; set; }
        [Required]
        public string? Status { get; set; }

        public string? WinningTeam { get; set; }
        public int Points { get; set; }


    }
}
