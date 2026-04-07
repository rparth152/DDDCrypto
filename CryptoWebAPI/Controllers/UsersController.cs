using CryptoWebAPI.Application.Interfaces;
using CryptoWebAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CryptoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers service;

        public UsersController(IUsers service)
        {
            this.service = service;
        }
        [HttpGet("Users")]
        public async Task<IActionResult> GetUsers()
        {
            var data = await service.GetUsersAsync();
            return Ok(data);
        }
    }
}
