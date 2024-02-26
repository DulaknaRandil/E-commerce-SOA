using E_commerce_SOA.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_SOA.BussinessLayer.Services
{
    public interface GetUserRegisterService
    {
        Task<ActionResult<UserRegister>> GetUserRegister(string username, string password);
    }
}
