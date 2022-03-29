using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace LibraryManagementAPI.Filters
{
    /// <summary>
    /// For Validating Model State Before Executing.    
    /// </summary>
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        #region public Methods


        public override void OnActionExecuting(HttpActionContext context)
        {
            if (context.ModelState.IsValid)
                return;

            var errorList = context.ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage);

            context.Response = context.Request.CreateErrorResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(errorList));
        }



        #endregion public Methods
    }
}