using ServiceStack.OrmLite;
using System.Configuration;
using System.Data;

namespace LibraryManagementBusinessLogic
{
    /// <summary>
    /// Use for Managing DataBase connection.
    /// </summary>
    class DBManager
    {

        #region static Fields
        /// <summary>
        /// Contains Connection String
        /// </summary>
        public readonly static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #endregion

        #region public Methods
        /// <summary>
        /// Used to Get OrmLiteConnection
        /// </summary>
        /// <returns> New Object Of OrmLiteConnectionFactory</returns>
        public OrmLiteConnectionFactory GetDBFactory()
        {
            return new OrmLiteConnectionFactory(ConnectionString, MySqlDialect.Provider);
        }
        #endregion public Methods
    }
}
