using netcore_sample_repository_pattern.Model;

namespace netcore_sample_repository_pattern.Interface
{
    // Unit of Work Interface
    public interface IUnitOfWork
    {
        IRepository<Product> Products { get; }
        Task SaveChangesAsync();
    }
}
