using Npgsql;

namespace cat.itb.M6UF2Pr_RequenaEric
{
    public class CloudConnection
    {
        private String HOST = "salt.db.elephantsql.com:5432"; // Ubicació de la BD.
        private String DB = "phdzlzpl"; // Nom de la BD.
        private String USER = "phdzlzpl";
        private String PASSWORD = "7xi_qER1xx5nR7XoU6Bqi-lgAS2lLgU5";

        // Specify connection options and open an connection
        public NpgsqlConnection conn = null;

        /**
         * Mètode per connectar a la base de dades school
         */
        public NpgsqlConnection GetConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(
                "Host=" + HOST + ";" + "Username=" + USER + ";" +
                "Password=" + PASSWORD + ";" + "Database=" + DB + ";"
            );
            conn.Open();
            return conn;
        }
    }
}
