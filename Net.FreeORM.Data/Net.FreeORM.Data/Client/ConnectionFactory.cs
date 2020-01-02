using Net.FreeORM.Base;
using System;

namespace Net.FreeORM.Data.Client
{
    public sealed class ConnectionFactory
    {

        #region [ CreateConnection Method ]

        /// <summary>
        /// Creates IConnection object with given parameters.
        /// </summary>
        /// <param name="connectionString">Connection String</param>
        /// <returns>Returns IConnection object.</returns>
        public static IConnection CreateConnection(ConnectionTypes connType)
        {
            IConnection conn = null;
            try
            {
                switch (connType)
                {
                    case ConnectionTypes.DB2:
                        conn = new ConnectionDB2();
                        break;

                    case ConnectionTypes.FireBird:
                        conn = new ConnectionFireBird();
                        break;

                    case ConnectionTypes.Informix:
                        conn = new ConnectionInformix();
                        break;

                    case ConnectionTypes.MariaDb:
                        conn = new ConnectionMariaDb();
                        break;

                    case ConnectionTypes.MySQL:
                        conn = new ConnectionMySQL();
                        break;

                    case ConnectionTypes.OracleManaged:
                        conn = new ConnectionOracleManaged();
                        break;

                    case ConnectionTypes.OracleNet:
                        conn = new ConnectionOracleNet();
                        break;

                    case ConnectionTypes.Oledb:
                        conn = new ConnectionOledb();
                        break;

                    case ConnectionTypes.Odbc:
                        conn = new ConnectionOdbc();
                        break;

                    case ConnectionTypes.PostgreSQL:
                        conn = new ConnectionPostgreSQL();
                        break;

                    case ConnectionTypes.SqlBase:
                        conn = new ConnectionSqlBase();
                        break;

                    case ConnectionTypes.SQLite:
                        conn = new ConnectionSQLite();
                        break;

                    case ConnectionTypes.SqlServer:
                        conn = new ConnectionSqlServer();
                        break;

                    case ConnectionTypes.SqlServerCe:
                        conn = new ConnectionSqlServerCe();
                        break;

                    case ConnectionTypes.Sybase:
                        conn = new ConnectionSybase();
                        break;

                    case ConnectionTypes.VistaDB:
                        conn = new ConnectionVistaDB();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }

        #endregion


        #region [ CreateConnection Method ]
        /// <summary>
        /// Creates IConnection object with given parameters.
        /// </summary>
        /// <param name="connType">Connection Type</param>
        /// <param name="connectionString">Connection String</param>
        /// <returns>Returns IConnection object.</returns>
        public static IConnection CreateConnection(ConnectionTypes connType, string connectionString)
        {
            IConnection conn = null;
            try
            {
                switch (connType)
                {
                    case ConnectionTypes.DB2:
                        conn = new ConnectionDB2(connectionString);
                        break;

                    case ConnectionTypes.FireBird:
                        conn = new ConnectionFireBird(connectionString);
                        break;

                    case ConnectionTypes.Informix:
                        conn = new ConnectionInformix(connectionString);
                        break;

                    case ConnectionTypes.MariaDb:
                        conn = new ConnectionMariaDb(connectionString);
                        break;

                    case ConnectionTypes.MySQL:
                        conn = new ConnectionMySQL(connectionString);
                        break;

                    case ConnectionTypes.OracleManaged:
                        conn = new ConnectionOracleManaged(connectionString);
                        break;

                    case ConnectionTypes.OracleNet:
                        conn = new ConnectionOracleNet(connectionString);
                        break;

                    case ConnectionTypes.Oledb:
                        conn = new ConnectionOledb(connectionString);
                        break;

                    case ConnectionTypes.Odbc:
                        conn = new ConnectionOdbc(connectionString);
                        break;

                    case ConnectionTypes.PostgreSQL:
                        conn = new ConnectionPostgreSQL(connectionString);
                        break;

                    case ConnectionTypes.SqlBase:
                        conn = new ConnectionSqlBase(connectionString);
                        break;

                    case ConnectionTypes.SQLite:
                        conn = new ConnectionSQLite(connectionString);
                        break;

                    case ConnectionTypes.SqlServer:
                        conn = new ConnectionSqlServer(connectionString);
                        break;

                    case ConnectionTypes.SqlServerCe:
                        conn = new ConnectionSqlServerCe(connectionString);
                        break;

                    case ConnectionTypes.Sybase:
                        conn = new ConnectionSybase(connectionString);
                        break;

                    case ConnectionTypes.VistaDB:
                        conn = new ConnectionVistaDB(connectionString);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }

        #endregion

    }
}