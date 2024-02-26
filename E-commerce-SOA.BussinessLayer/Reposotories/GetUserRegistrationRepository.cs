using E_commerce_SOA.BussinessLayer.DBContext;
using E_commerce_SOA.BussinessLayer.Services;
using E_commerce_SOA.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Repositories
{
    public class GetUserRegisterRepository : GetUserRegisterService
    {
        private readonly UserRegisterContext _context;

        public GetUserRegisterRepository(UserRegisterContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<ActionResult<UserRegister>> GetUserRegister(string username, string password)
        {
            try
            {
                var userRegister = await _context.UserRegisters.FirstOrDefaultAsync(u => u.UserName == username && u.UserPassword == password);
                return userRegister; // Return user or null if not found
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                throw new Exception("An error occurred while retrieving user information.", ex);
            }
        }

    }
}
