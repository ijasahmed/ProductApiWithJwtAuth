using ApiSampleCrud.Models;
using ApiSampleCrud.Repositories;

namespace ApiSampleCrud.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public Task<IEnumerable<Product>> GetAllProductsAsync() => _repository.GetAllAsync();
        public Task<Product> AddAsync(Product product) => _repository.AddAsync(product);
        public Task<Product?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task<Product?> UpdateAsync(Product product) => _repository.UpdateAsync(product);
        public Task<bool> DeleteAsync(int id) => _repository.DeleteAsync(id);
    }


}
