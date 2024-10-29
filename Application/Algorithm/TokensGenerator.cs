using Application.Dtos.Tokens;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Algorithm
{
    public class TokensGenerator(IConfiguration configuration)
    {
        public Token GenerateAccessToken(User user, IEnumerable<string> userRoles)
        {
            var claims = new List<Claim> 
            { 
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) 
            };

            foreach (var role in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var tokenExpires = DateTime.UtcNow.AddMinutes(GetJwtSetting<double>("AccessTokenExpiresInMinutes"));

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(GetJwtSetting<string>("Key")));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: tokenExpires,
                issuer: GetJwtSetting<string>("Issuer"),
                signingCredentials: signingCredentials);

            return new Token
            {
                Value = new JwtSecurityTokenHandler().WriteToken(securityToken),
                Expires = tokenExpires
            };
        }

        public Token GenerateRefreshToken()
        {
            return new Token
            {
                Value = Guid.NewGuid().ToString(),
                Expires = DateTime.UtcNow.AddMinutes(GetJwtSetting<double>("RefreshTokenExpiresInMinutes"))
            };
        }

        private T GetJwtSetting<T>(string key) => configuration.GetV<T>($"JwtSettings:{key}");
    }
}
