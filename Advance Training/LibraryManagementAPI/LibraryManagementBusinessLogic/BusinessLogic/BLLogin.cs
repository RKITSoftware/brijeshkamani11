using LibraryManagementBusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStack.OrmLite;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LibraryManagementBusinessLogic.BusinessLogic
{
    public class BLLogin
    {
        #region Private Fields
        private readonly OrmLiteConnectionFactory _objOrmLiteConnectionFactory;
        #endregion Private Fields

        #region Public Properties
        #endregion Public Properties

        #region constructors

        /// <summary>
        /// Will Create new 
        /// OrmLiteConnectionFactory Object.
        /// </summary>
        public BLLogin()
        {
            _objOrmLiteConnectionFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, MySqlDialect.Provider);
        }
        #endregion constructors

        #region public Methods

        /// <summary>
        /// Will Validate Username and Password From Database
        /// </summary>
        /// <param name="loginDto"> Contains Username and Password </param>
        /// <returns> Boolean which specified user is valid or not. </returns>
        public bool IsUsernamePasswordValid(LoginDto loginDto)
        {
            using (var db = _objOrmLiteConnectionFactory.Open())
            {
                return db.Select<lms12>(x => x.S12F02 == loginDto.Username && x.S12F03 == loginDto.Password).Count > 0;
            }
                
        }


        #endregion public Methods

        #region private Methods
        #endregion private Methods
    }
}
