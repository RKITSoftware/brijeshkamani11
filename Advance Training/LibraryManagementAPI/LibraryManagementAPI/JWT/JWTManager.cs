using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace LibraryManagementAPI.JWT
{
    /// <summary>
    /// Class That Manage JWT Services
    /// </summary>
    public class JWTManager
    {
        #region Static Fields
        /// <summary>
        /// Secret Key to Hash JWT SigningCredentials
        /// </summary>
        private readonly static string Secret = ConfigurationManager.AppSettings["JWTSecret"].ToString();
        #endregion Static Fields

        #region Static Methods

        /// <summary>
        /// Will Generate JWT Token
        /// </summary>
        /// <param name="username"> Contains current Username </param>
        /// <param name="expireMinutes"> Expire time of Token in Minutes </param>
        /// <returns></returns>
        public static string GenerateToken(string username, string role, int expireMinutes = 20)
        {
            var symmetricKey = Convert.FromBase64String(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;

            // Will Creates Parameters for Token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name, username),
                            new Claim(ClaimTypes.Role, role)
                        }),

                // Add given Minutes to Current Time
                Expires = now.AddMinutes(Convert.ToInt32(expireMinutes)),

                // Will Create Signature Based on symmetricKey Key
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256Signature)
            };

            SecurityToken securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }

        /// <summary>
        /// Will Get Principle From Given JWT Token
        /// </summary>
        /// <param name="token"> String That Must Be Validate JWT Token </param>
        /// <returns> ClainsPrinciple Generated From Token </returns>
        public static ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadToken(token) as JwtSecurityToken;

                // if Token Format in Valid
                if (jwtToken == null)
                    return null;

                var symmetricKey = Convert.FromBase64String(Secret);

                var validationParameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(symmetricKey)
                };

                
                var principal = tokenHandler.ValidateToken(token, validationParameters, out _);

                return principal;
            }

            catch (Exception)
            {
                return null;
            }
        }
        #endregion Static Methods
    }
}