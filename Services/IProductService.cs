using ApiSampleCrud.Models;

namespace ApiSampleCrud.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();

        Task<Product?> GetByIdAsync(int id);
        Task<Product> AddAsync(Product product);

        Task<Product?> UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
    }
}
