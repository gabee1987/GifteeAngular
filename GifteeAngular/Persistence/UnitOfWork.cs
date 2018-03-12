using GifteeAngular.Core;
using System.Threading.Tasks;

namespace GifteeAngular.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GifteeDbContext context;

        public UnitOfWork(GifteeDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
