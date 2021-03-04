using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FamilyBudget.Entities;

namespace FamilyBudget.Api.Controllers
{
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public async Task<ActionResult<IEnumerable<User>>>  GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public async Task<ActionResult<User>> GetById(int id)
        {
            var users = await _userService.GetById(id);
            return Ok(users);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public async Task<ActionResult<User>> Add([FromBody] User user)
        {
            await _userService.Add(user);
            return user;
        }

    }
}