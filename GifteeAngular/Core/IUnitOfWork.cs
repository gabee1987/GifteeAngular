using System.Threading.Tasks;

namespace GifteeAngular.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
