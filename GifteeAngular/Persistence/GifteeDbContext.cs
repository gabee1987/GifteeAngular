using GifteeAngular.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GifteeAngular.Persistence
{
    public class GifteeDbContext : DbContext
    {
        #region DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Giftee> Giftees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Gift> Gifts { get; set; }

        #endregion

        public GifteeDbContext(DbContextOptions<GifteeDbContext> options)
            : base(options)
        {
        }
    }
}
