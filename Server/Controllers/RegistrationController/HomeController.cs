using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReactTestApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisteredUserController : ControllerBase
    {
        private readonly ILogger<RegisteredUserController> _logger;

        public RegisteredUserController(ILogger<RegisteredUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<RegisteredUserData> Get()
        {
            _logger.LogInformation("Get method called for registered users.");

            // Replace the following logic with actual data retrieval from your database
            var data = GetSampleRegisteredUserData();

            _logger.LogInformation("Returning data: {@Data}", data);

            return data;
        }

        // Replace this with actual data retrieval logic from your database
        private IEnumerable<RegisteredUserData> GetSampleRegisteredUserData()
        {
            return Enumerable.Range(1, 5).Select(index => new RegisteredUserData
            {
                UserId = index,
                UserName = $"User{index}",
                Email = $"user{index}@example.com",
                RegistrationDate = DateTime.Now.AddDays(-index),
            });
        }

        public class RegisteredUserData
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }
    }
}
