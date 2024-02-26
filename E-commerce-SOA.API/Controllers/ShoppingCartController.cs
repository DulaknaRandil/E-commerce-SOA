using E_commerce_SOA.BussinessLayer.Services;
using E_commerce_SOA.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce_SOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ShoppingCartService _shoppingCartService;

        public ShoppingCartController(ShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        // GET: api/ShoppingCart
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShoppingCart>>> GetShoppingCarts()
        {
            var shoppingCarts = await _shoppingCartService.GetAllShoppingCarts();
            return Ok(shoppingCarts);
        }

        // GET: api/ShoppingCart/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShoppingCart>> GetShoppingCart(int id)
        {
            var shoppingCart = await _shoppingCartService.GetShoppingCartById(id);
            if (shoppingCart == null)
            {
                return NotFound();
            }
            return Ok(shoppingCart);
        }

        // POST: api/ShoppingCart
        [HttpPost]
        public async Task<ActionResult<ShoppingCart>> CreateShoppingCart(ShoppingCart shoppingCart)
        {
            var createdShoppingCart = await _shoppingCartService.CreateShoppingCart(shoppingCart);
            return CreatedAtAction(nameof(GetShoppingCart), new { id = createdShoppingCart.ShoppingCartId }, createdShoppingCart);
        }

        // PUT: api/ShoppingCart/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShoppingCart(int id, ShoppingCart shoppingCart)
        {
            var success = await _shoppingCartService.UpdateShoppingCart(id, shoppingCart);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }

        // DELETE: api/ShoppingCart/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoppingCart(int id)
        {
            var success = await _shoppingCartService.DeleteShoppingCart(id);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
