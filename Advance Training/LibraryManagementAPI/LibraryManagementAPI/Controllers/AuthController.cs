using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagementBusinessLogic.Models;
using System.Web.Http;
using LibraryManagementAPI.Filters;
using LibraryManagementBusinessLogic.BusinessLogic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace LibraryManagementAPI.Controllers
{
    /// <summary>
    /// Use To Control /Auth Controller
    /// </summary>
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        #region Private Members
        private readonly BLLogin _objBLLogin;
        #endregion Private Members

        #region public Constructor
        public AuthController()
        {
            _objBLLogin = new BLLogin();
        }
        #endregion public Constructor

        // api/auth/Authenticate
        [HttpPost]
        [Route("authenticate")]
        
        public IHttpActionResult Authenticate(LoginDto loginDto)
        {
            //if(!_objBLLogin.isUsernamePasswordValid(loginDto))
            //{
            //    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unauthorized)
            //    {
            //        RequestMessage = Request,
            //        ReasonPhrase = ReasonPhrase
            //    };

            //    return ResponseMessage(new HttpResponseMessage(HttpStatusCode.Unauthorized).Content);
            //}

            return Ok(_objBLLogin.IsUsernamePasswordValid(loginDto));
        }
    }
}