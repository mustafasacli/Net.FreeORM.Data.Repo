using System;
namespace Net.FreeORM.Base
{
    public enum ConnectionTypes : byte
    {
        DB2,
        FireBird,
        Informix,
        MariaDb,
        MySQL,
        OracleManaged,
        OracleNet,
        Oledb,
        Odbc,
        PostgreSQL,
        SqlBase,
        SQLite,
        SqlServer,
        SqlServerCe,
        Sybase,
        VistaDB
    };


    #region [ ConnectionTypeBuilder class ]

    public static class ConnectionTypeBuilder
    {
        public static ConnectionTypes GetConnectionType(String driverTypeName)
        {
            try
            {
                driverTypeName = driverTypeName.TrimEnd().TrimStart().ToLower();
                switch (driverTypeName)
                {
                    case "sqlexpress":
                    case "sqlserver":
                    case "mssql":
                    case "ms-sql":
                    default:
                        return ConnectionTypes.SqlServer;

                    case "postgresql":
                        return ConnectionTypes.PostgreSQL;

                    case "oracle":
                        return ConnectionTypes.OracleNet;

                    case "oracle-managed":
                    case "oraclemanaged":
                    case "oracle-mngd":
                        return ConnectionTypes.OracleManaged;

                    case "mysql":
                        return ConnectionTypes.MySQL;

                    case "mariadb":
                    case "marıadb":
                        return ConnectionTypes.MariaDb;

                    case "vistadb":
                    case "vıstadb":
                        return ConnectionTypes.VistaDB;

                    case "oledb":
                        return ConnectionTypes.Oledb;

                    case "sqlite":
                    case "sqlıte":
                        return ConnectionTypes.SQLite;

                    case "firebird":
                    case "firebırd":
                    case "fırebird":
                    case "fırebırd":
                        return ConnectionTypes.FireBird;

                    case "sqlserverce":
                        return ConnectionTypes.SqlServerCe;

                    case "sybase":
                        return ConnectionTypes.Sybase;
                    /*
                    case "db2":
                        return ConnectionTypes.DB2;

                                        case "informix":
                                        case "ınformıx":
                                        case "ınformix":
                                        case "informıx":
                                            return ConnectionTypes.Informix;
   
                                        case "u2":
                                            return ConnectionTypes.U2;

                                        case "synergy":
                                            return ConnectionTypes.Synergy;
                     
                                        case "ingres":
                                        case "ıngres":
                                            return ConnectionTypes.Ingres;
                                            */
                    case "sqlbase":
                        return ConnectionTypes.SqlBase;

                    case "odbc":
                        return ConnectionTypes.Odbc;
                }
            }
            catch (System.Exception)
            {
                return ConnectionTypes.SqlServer;
            }
        }
    }

    #endregion


}