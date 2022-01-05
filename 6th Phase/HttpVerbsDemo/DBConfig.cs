
namespace HttpVerbsDemo
{
    public class DBConfig
    {
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}