using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaAPI.custom;
using PruebaAPI.db;
using PruebaAPI.Dtos;
using PruebaAPI.models;

namespace PruebaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly Utilities _utilities;

        public AuthController(ApplicationDbContext db, Utilities utilities)
        {
            _db = db;
            _utilities = utilities;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Password = _utilities.EncrypteSHA256(userDto.Password)
            };

            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();

            if (user.Id != 0)
                return Ok(user);
            else
                return BadRequest();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginDto userDto)
        {
            var findUser = _db.Users.Where(x => x.Email == userDto.Email && x.Password == _utilities.EncrypteSHA256(userDto.Password)).FirstOrDefault();

            if (findUser == null)
                return BadRequest("Usuario o contraseña incorrectos");
            else
            {
                var token = _utilities.GenerateJWT(findUser);
                return Ok(new { token });
            }

        }
    }
}