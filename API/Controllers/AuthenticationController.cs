using API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public readonly UserManager<IdentityUser> _userManager;
        public readonly SignInManager<IdentityUser> _signInManager;

        public AuthenticationController(UserManager<IdentityUser> usermanager, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = usermanager;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Authentication - Sistema de Atendimento Medico\n {DateTime.Now}";
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UsuarioDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userIdentity = new IdentityUser
            {
                UserName = user.Email,
                Email = user.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(userIdentity, user.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            await _signInManager.SignInAsync(userIdentity, false);

            return Ok();
        }
        [HttpPost("login")]
        public async  Task<ActionResult> Login(UsuarioDto usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var result = _signInManager.PasswordSignInAsync(usuario.Email, usuario.Password, false, false);

            if (result.IsCompletedSuccessfully)
            {
                return Ok();
            }else
            {
                return BadRequest("Login Invalido!");
            }
        }

  
    }
}

