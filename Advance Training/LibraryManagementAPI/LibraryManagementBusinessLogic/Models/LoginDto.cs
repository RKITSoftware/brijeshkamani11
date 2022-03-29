using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusinessLogic.Models
{
    /// <summary>
    /// Login Class
    /// </summary>
    public class LoginDto
    {
        #region Public Properties

        /// <summary>
        /// Contains Username
        /// </summary>
        [Required(ErrorMessage = "Username Required!")]
        public string Username { get; set; }

        /// <summary>
        /// Contains Password
        /// </summary>
        [Required(ErrorMessage = "Password Required!")]
        public string Password { get; set; }

        #endregion Public Properties
    }
}
