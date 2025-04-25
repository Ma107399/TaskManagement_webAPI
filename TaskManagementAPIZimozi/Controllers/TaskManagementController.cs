using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskManagementAPIZimozi.Data;
using TaskManagementAPIZimozi.Model;

namespace TaskManagementAPIZimozi.Controllers
{
    
    [Route("tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration _config;

        public TasksController(ApplicationDbContext dbContext, IConfiguration config)
        {
            this.dbContext = dbContext;
            _config = config;
        }

        // Simple Login: Return JWT if credentials match (just a simple example)
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Simple hardcoded check for testing
            if (request.Username == "admin" && request.Password == "admin123")
                /*for now if you try to input anything this hardcoded username and password 
                 you will see 401 unauthorized error*/
            {
                var token = GenerateJwtToken(request.Username); // Use helper method to generate token
                return Ok(new { token });
            }

            return Unauthorized();
        }

        // Helper method to generate JWT
        private string GenerateJwtToken(string username)
        {
            var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]?? "DefaultHardcodedKeyForTesting123!");
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin") // Hardcoded for now
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public class LoginRequest
        {
            public required string Username { get; set; }
            public required string Password { get; set; }
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateTask([FromBody] TaskItemModel task)
        {
            dbContext.TaskItems.Add(task);
            dbContext.SaveChanges();
            return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetTaskById(int id)
        {
            var task = dbContext.TaskItems.FirstOrDefault(t => t.Id == id);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpGet("user/{userId}")]
        [Authorize]
        public IActionResult GetTasksByUser(int userId)
        {
            var tasks = dbContext.TaskItems.Where(t => t.AssignedToUserId == userId).ToList();
            return Ok(tasks);
        }
    }
}
