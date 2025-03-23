using netcore_sample_repository_pattern.DBContext;
using netcore_sample_repository_pattern.Interface;
using netcore_sample_repository_pattern.Model;

namespace netcore_sample_repository_pattern.Impl
{
    // Unit of Work Implementation
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRepository<Product> Products { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Products = new Repository<Product>(context);
        }

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();


    }
}
