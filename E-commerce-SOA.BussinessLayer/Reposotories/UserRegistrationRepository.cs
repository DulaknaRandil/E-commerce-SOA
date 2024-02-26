using E_commerce_SOA.BussinessLayer.DBContext;
using E_commerce_SOA.BussinessLayer.Services;
using E_commerce_SOA.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Reposotories
{
    public class UserRegistrationRepository : UserRegisterService
    {
        private readonly UserRegisterContext _context;

        // Constructor to inject UserRegisterContext
        public UserRegistrationRepository(UserRegisterContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Method to create a user registration
        public async Task<ActionResult<UserRegister>> CreateUserRegister(UserRegister userRegister)
        {
            try
            {
                _context.UserRegisters.Add(userRegister);
                await _context.SaveChangesAsync();

                return new ActionResult<UserRegister>(userRegister); // Return the created user
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                throw; // Rethrow the exception to let the caller handle it
            }
        }


    }
}
