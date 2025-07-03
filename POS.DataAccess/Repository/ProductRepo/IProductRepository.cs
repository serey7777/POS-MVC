using POS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POS.DataAccess.Repository.ProductRepo
{
    public interface IProductRepository 
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product?> GetByIdAsync(int id);

        Task AddAsync(Product category);

        Task UpdateAsync(Product category);

        Task RemoveAsync(Product category);

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