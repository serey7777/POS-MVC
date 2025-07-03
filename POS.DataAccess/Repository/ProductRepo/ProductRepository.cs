using Microsoft.EntityFrameworkCore;
using POS.Models;
using WebApplication1.DataAccess.Datacon;

namespace POS.DataAccess.Repository.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _DbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _DbContext.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _DbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Product product)
        {
            await _DbContext.Products.AddAsync(product);
        }

        public async Task UpdateAsync(Product product)
        {
            _DbContext.Products.Update(product);
            await _DbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Product product)
        {
            _DbContext.Products.Remove(product);
            await _DbContext.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _DbContext.SaveChangesAsync();
        }
    }
}
