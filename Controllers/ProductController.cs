using ApiSampleCrud.Models;
using ApiSampleCrud.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApiReact.DTOS;

namespace ApiSampleCrud.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;


        public ProductController(IProductService service, ILogger<ProductController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var products = await _service.GetAllProductsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetAll");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var product = await _service.GetByIdAsync(id);
                if (product == null) return NotFound();
                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error retrieving product with ID {id}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateProductDto dto)
        {
            try
            {
                var product = _mapper.Map<Product>(dto);
                var created = await _service.AddAsync(product);
                var createdDto = _mapper.Map<ProductDto>(created);
                return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);

                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating product");
                return StatusCode(500, new { message = "Internal server error" });
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Product product)
        {
            try
            {
                if (id != product.Id) return BadRequest("ID mismatch");

                var updated = await _service.UpdateAsync(product);
                if (updated == null) return NotFound("Not found");

                return Ok(updated);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating product with ID {id}");
                return StatusCode(500, "Internal server error");
            }
        }
        [Authorize(Roles = "Admin,Manager")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deleted = await _service.DeleteAsync(id);
                if (!deleted) return NotFound();
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting product with ID {id}");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
