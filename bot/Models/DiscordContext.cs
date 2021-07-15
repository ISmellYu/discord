using Microsoft.EntityFrameworkCore;

namespace bot.Models
{
    public class DiscordContext : DbContext
    {
        public DbSet<DbUser> Users { get; set; }
        public DbSet<MuteUser> Mutes { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<IndividualBet> IndividualBets { get; set; }
        public DbSet<Option> Options { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("server=localhost;database=discord;user=root;password=bAy8CwdQ");
#if DEBUG
            optionsBuilder.UseMySQL("server=20.52.55.98;database=test_discord;user=bot;password=YsCSh2LC");
#else
            optionsBuilder.UseMySQL("server=localhost;database=test_discord;user=bot;password=YsCSh2LC");
            #endif
        }
    }
}