using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace LibraryManagementAPI.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        #region Private Members
        string _defultexceptionDirectoryPath;
        string _currentTime;
        
        #endregion

        #region Public Methods
        public ExceptionFilter() : base()
        {
            
            _currentTime = DateTime.UtcNow.ToShortDateString();
            _defultexceptionDirectoryPath = Path.Combine(HttpContext.Current.Server.MapPath("~/Log/"), _currentTime + "/");

            if(!Directory.Exists(_defultexceptionDirectoryPath))
            {
                Directory.CreateDirectory(_defultexceptionDirectoryPath);
            }


        }

        public override void OnException(HttpActionExecutedContext ex)
        {
            
            if(!File.Exists(_defultexceptionDirectoryPath + HttpContext.Current.User.Identity.Name))
            {
                File.Create(_defultexceptionDirectoryPath + HttpContext.Current.User.Identity.Name + ".log");
            }


            base.OnException(ex);
        }
        #endregion
    }
}