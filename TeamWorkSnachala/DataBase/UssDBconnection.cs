using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamWorkSnachala.Properties;

namespace TeamWorkSnachala.DataBase
{
    public static class UssDBconnection
    {
        private static SqlConnection _connection;

        private static string _connectionString = Settings.Default.StringConnection;

        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
            }
            return _connection;
        }

        public static void onOpen()
        {
            if (GetConnection().State == System.Data.ConnectionState.Closed)
            {
                GetConnection().Open();
            }
        }
        public static void onClose()
        {
            if (GetConnection().State == System.Data.ConnectionState.Open)
            {
                GetConnection().Close();
            }
        }
    }
}
