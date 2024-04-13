using System.Data.SqlClient;

namespace HotelSelect.Dao.repository
{
    public class DbConnector
    {
        private static DbConnector _instance;

        private readonly SqlConnection connection;
        private DbConnector()
        {
            connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=hotel;" +
                                           "Integrated Security=true; TrustServerCertificate=True;");
        }

        public static DbConnector GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DbConnector();
            }
            return _instance;
            
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}