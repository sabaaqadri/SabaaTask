using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SabaaTask.CORE.Data;
using SabaaTask.CORE.Repository;
using SabaaTask.CORE.Service;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SabaaTask.INFRA.Service
{
    public class JWTService : IJWTService
    {

        private readonly IJWTRepository _jWTRepository;
        private readonly IConfiguration _config;
        public JWTService(IJWTRepository jWTRepository )
        {
            _jWTRepository  = jWTRepository;
         }





        public string Auth(Userlogin userlogin)
        {
          var result=   _jWTRepository.Auth(userlogin);

            if (result == null)
            {
                return null;
            }
            else
            {

                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.Email, result.Email),
                     new Claim(ClaimTypes.Role, result.Roleid.ToString()),
                    
                };

                var tokeOptions = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return tokenString;

            }
        }
    }
}
