using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http.Filters;

namespace LibraryManagementAPI.Filters
{
    public class CacheControlAttribute : ActionFilterAttribute
    {
        public int MaxAge { get; set; }

        public CacheControlAttribute()
        {
            MaxAge = 3600;
        }

        public override void OnActionExecuted(HttpActionExecutedContext context)
        {
            if (context.Response != null)
                context.Response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    Public = true,
                    MaxAge = TimeSpan.FromSeconds(MaxAge)
                };

            base.OnActionExecuted(context);
        }
    }
}