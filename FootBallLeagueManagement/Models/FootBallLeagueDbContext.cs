using Microsoft.EntityFrameworkCore;

namespace FootBallLeagueManagement.Models
{
    public class FootBallLeagueDbContext :DbContext
    {
        public FootBallLeagueDbContext(DbContextOptions<FootBallLeagueDbContext> options) : base(options)
        {
        }

        public DbSet<FootballLeague> FootballLeagues { get; set; }
    }
}
