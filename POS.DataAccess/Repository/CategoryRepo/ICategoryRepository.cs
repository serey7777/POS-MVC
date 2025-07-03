using POS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POS.DataAccess.Repository.CategoryRepo
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();

        Task<Category?> GetByIdAsync(int id);

        Task AddAsync(Category category);

        Task UpdateAsync(Category category);

        Task RemoveAsync(Category category);

        Task SaveAsync();
    }
}

//| Method           | Purpose                  | Return Type                  |
//| ---------------- | ------------------------ | ---------------------------- |
//| `GetAllAsync()`  | Get all products         | `Task<IEnumerable<Product>>` |
//| `GetByIdAsync()` | Get one product by ID    | `Task<Product>`              |
//| `AddAsync()`     | Add a new product        | `Task`                       |
//| `Update()`       | Update a product         | `void`                       |
//| `Delete()`       | Delete a product         | `void`                       |
//| `SaveAsync()`    | Save changes to database | `Task`                       |