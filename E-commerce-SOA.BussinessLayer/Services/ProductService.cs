using E_commerce_SOA.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Services
{
    public interface ProductService
    {
        Task<ActionResult<IEnumerable<Product>>> GetProducts();
        Task<ActionResult<Product>> GetProduct(int id);
        Task<ActionResult<Product>> CreateProduct(Product product);
        Task<IActionResult> UpdateProduct(int id, Product product);
        Task<IActionResult> DeleteProduct(int id);
    }
}
