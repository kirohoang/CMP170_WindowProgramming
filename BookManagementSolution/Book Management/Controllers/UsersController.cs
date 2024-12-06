using Book_Management.Data;
using Book_Management.Models;
using Book_Management.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public UsersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getAllUsers()
        {
            return Ok(dbContext.users.ToList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getUserById(int id)
        {
            var user = dbContext.users.Find(id);

            if (user is null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult addUser(AddUsersDto addUsersDto)
        {
            var userEntity = new User()
            {
                Id = addUsersDto.Id,
                Name = addUsersDto.Name,
                Email = addUsersDto.Email
            };
            dbContext.users.Add(userEntity);
            dbContext.SaveChanges();
            return Ok(userEntity);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult updateUser(int id, UpdateUserDto updateUserDto)
        {
            var user = dbContext.users.Find(id);
            if (user is null)
            {
                return NotFound();
            }

            user.Name = updateUserDto.Name;
            user.Email = updateUserDto.Email;

            dbContext.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult deleteUser(int id)
        {
            var user = dbContext.users.Find(id);
            if (user is null)
            {
                return NotFound();
            }

            dbContext.users.Remove(user);
            dbContext.SaveChanges();

            return Ok();
        }
    }
}
