using E_commerce_SOA.BussinessLayer.DBContext;
using E_commerce_SOA.BussinessLayer.Services;
using E_commerce_SOA.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_commerce_SOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegisterController : ControllerBase
    {
        private readonly UserRegisterContext _context;
        private readonly UserRegisterService _userRegisterService;
        private readonly GetUserRegisterService _getUserRegisterService;

        public UserRegisterController(UserRegisterContext context, UserRegisterService userRegisterService, GetUserRegisterService getUserRegisterService)
        {
            _context = context;
            _userRegisterService = userRegisterService;
            _getUserRegisterService = getUserRegisterService;
        }

        // POST: api/UserRegister/SetUserRegister
        [HttpPost("SetUserRegister")]
        public async Task<ActionResult<UserRegister>> CreateUserRegister(UserRegister userRegister)
        {
            return await _userRegisterService.CreateUserRegister(userRegister);
        }

        // GET: api/UserRegister/{username}/{password}
        [HttpGet("{username}/{password}")]
        public async Task<ActionResult<UserRegister>> GetUserRegister(string username, string password)
        {
            return await _getUserRegisterService.GetUserRegister(username, password);
        }
    }
}
