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
            _DbContext.Products.Include(u => u.Category);
        }

        //public async Task<IEnumerable<Product>> GetAllAsync(string? includeProp = null)
        //{
        //    IQueryable<Product> query = _DbContext.Products;

        //    if (!string.IsNullOrEmpty(includeProp))
        //    {
        //        var includes = includeProp.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        //        foreach (var include in includes)
        //        {
        //            query = query.Include(include.Trim());
        //        }
        //    }

        //    return await query.ToListAsync();
        //}
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _DbContext.Products
                .Include(p => p.Category)
                .ToListAsync();
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
