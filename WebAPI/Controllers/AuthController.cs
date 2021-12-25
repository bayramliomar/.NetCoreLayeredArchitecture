using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var result = _authService.Login(userForLoginDto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            var accessTokenResult = _authService.cerateAccessToken(result.Data);
            if (accessTokenResult.Success)
            {
                return Ok(accessTokenResult.Data);
            }
            return BadRequest(accessTokenResult.Message);
        }

        [HttpPost("register")]
        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var result = _authService.Register(userForRegisterDto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            var accessTokenResult = _authService.cerateAccessToken(result.Data);
            if (accessTokenResult.Success)
            {
                return Ok(accessTokenResult.Data);
            }
            return BadRequest(accessTokenResult.Message);
        }
    }
}
