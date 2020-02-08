using System.Threading.Tasks;

namespace urlshortener.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
        
    }
}