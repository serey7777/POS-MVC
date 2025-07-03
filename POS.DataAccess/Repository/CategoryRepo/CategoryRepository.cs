using Microsoft.EntityFrameworkCore;
using POS.Models;
using WebApplication1.DataAccess.Datacon;

namespace POS.DataAccess.Repository.CategoryRepo
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _DbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _DbContext.Categories.ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _DbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Category category)
        {
            await _DbContext.Categories.AddAsync(category);
        }

        public async Task UpdateAsync(Category category)
        {
            _DbContext.Categories.Update(category);
            await _DbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Category category)
        {
            _DbContext.Categories.Remove(category);
            await _DbContext.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _DbContext.SaveChangesAsync();
        }
    }
}
