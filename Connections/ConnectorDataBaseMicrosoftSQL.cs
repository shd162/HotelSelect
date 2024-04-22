using System.Data.SqlClient;

namespace HotelSelect.Dao.repository
{
    internal class ConnectorDataBaseMicrosoftSQL
    {
        private static ConnectorDataBaseMicrosoftSQL instance;
        public SqlConnection SqlConnection { get; private set; }

        private ConnectorDataBaseMicrosoftSQL()
        {
            SqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=HoteReservation;" +
                                           "Integrated Security=true; TrustServerCertificate=true;");
        }

        public static ConnectorDataBaseMicrosoftSQL StartConnection()
        {
            if (instance == null) {
                instance = new ConnectorDataBaseMicrosoftSQL();
            }

            return instance;
        }

        public static void EndConnection()
        {
            instance = null;
        }

        public static ConnectorDataBaseMicrosoftSQL GetConnection()
        {
            return instance;
        }
    }
}