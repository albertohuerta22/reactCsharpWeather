using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Server.Data;
using Server.Models; // Imported User class
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReactTestApp.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger; // Logger field

        private readonly UserDbContext _context; // Assuming this is your DbContext

        // Constructor with ILogger injection
        public UserController(ILogger<UserController> logger, UserDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            try
            {
                _logger.LogInformation("Get method called for registered users.");
                var data = _context.Users.ToList(); // Assuming _context is your UserDbContext
                _logger.LogInformation("Returning data: {@Data}", data);
                return data;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving user data: {ex.Message}");
                throw; // Rethrow the exception for debugging purposes
            }
        }
    }
}
