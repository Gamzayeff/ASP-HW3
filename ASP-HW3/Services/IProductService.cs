using ASP_HW3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_HW3.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<Product> GetByIdAsync(int id);

    }
}
