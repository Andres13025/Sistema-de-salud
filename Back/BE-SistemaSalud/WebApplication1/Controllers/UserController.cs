using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DTO;
using WebApplication1.Interfaces;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsuario _IUsuario;

        public UserController(IUsuario usuario)
        {
            _IUsuario = usuario;
        }
 
        [HttpPost("userinfo")]
        public async Task<IActionResult> Userinfo(UserInfo value)
        {
            var result = await _IUsuario.PostInfoUser(value);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _IUsuario.GetAll();
            return Ok(result);
        }
    }
}
