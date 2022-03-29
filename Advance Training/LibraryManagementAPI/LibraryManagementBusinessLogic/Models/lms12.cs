
using LibraryManagementBusinessLogic.Constants;
using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusinessLogic.Models
{
    class lms12
    {
        #region Public Properties

        /// <summary>
        /// Staff ID
        /// </summary>
        [Required(ErrorMessage = "Staff ID is Required"), Key]
        public int S12F01 { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [Required(ErrorMessage = "Username is Required")]
        public string S12F02 { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "Password is Required")]
        public string S12F03 { get; set; }

        /// <summary>
        /// Role ID
        /// </summary>
        [Required(ErrorMessage = "Role is Required")]
        public int S12F04 { get; set; }

        /// <summary>
        /// created_at
        /// </summary>
        public DateTime S12F05 { get; set; }

        /// <summary>
        /// modified_at
        /// </summary>
        public DateTime S12F06 { get; set; }


        #endregion Public Properties
    }
}
