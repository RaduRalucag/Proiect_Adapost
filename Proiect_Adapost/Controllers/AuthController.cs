using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Proiect_Adapost.Models;
using Proiect_Adapost.Models.User;
using Proiect_Adapost.Models.User.DTO;
using Proiect_Adapost.Services.UserService;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Proiect_Adapost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public AuthController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }
        [HttpGet, Authorize]
        public ActionResult<string> GetNume()
        {
            return Ok(_userService.GetNume());
        }

        [HttpPost("Register")]
        public ActionResult<User> Register(UserRequestDto userrequest)
        {
            string parolaHash = BCrypt.Net.BCrypt.HashPassword(userrequest.Parola);
            user.Nume = userrequest.Nume;
            user.ParolaHash = parolaHash;
            return Ok(user);
        }

        [HttpPost("Login")]
        public ActionResult<User> Login(UserRequestDto userrequest)
        {
            if (user.Nume != userrequest.Nume)
            {
                return BadRequest("Numele de utilizator incorect");
            }

            if (!BCrypt.Net.BCrypt.Verify(userrequest.Parola, user.ParolaHash))
            {
                return BadRequest("Parola incorecta");
            }

            string token = CreateToken(user);

            var refreshToken = GenerateRefreshToken();
            SetRefreshToken(refreshToken);

            return Ok(token);
        }
        private RefreshToken GenerateRefreshToken()
        {
            var refreshToken = new RefreshToken
            {
                Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                Expires = DateTime.Now.AddDays(7)
            };
            return refreshToken;
        }

        [HttpPost("Refresh-token")]
        public async Task<ActionResult<string>> RefreshToken()
        {
            var refreshToken = Request.Cookies["refreshToken"];

            if (!user.RefreshToken.Equals(refreshToken))
            {

                return Unauthorized("Token invalid");
            }
            else if(user.TokenExpires < DateTime.Now)
            {
                return Unauthorized("Token expirat");
            }

            string token = CreateToken(user);
            var newRefreshToken = GenerateRefreshToken();
            SetRefreshToken(newRefreshToken);

            return Ok(token);
        }

        private void SetRefreshToken(RefreshToken newRefreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = newRefreshToken.Expires
            };
            Response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);

            user.RefreshToken = newRefreshToken.Token;
            user.TokenCreated = newRefreshToken.Created;
            user.TokenExpires = newRefreshToken.Expires;
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Nume),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(ClaimTypes.Role, "User"),
                new Claim(ClaimTypes.Role, "Doctor"),
                new Claim(ClaimTypes.Role, "Inspector")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                             claims: claims,
                             expires: DateTime.Now.AddHours(1),
                             signingCredentials: creds
                        );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
    }
}
