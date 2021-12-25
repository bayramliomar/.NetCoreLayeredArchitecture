using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IAuthService
    {
        DataResult<User> Register(UserForRegisterDto userForRegisterDto);
        DataResult<User> Login(UserForLoginDto userForLoginDto);
        Result UserExists(string email);
        DataResult<AccessToken> cerateAccessToken(User user);
    }
}
