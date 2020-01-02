using Net.FreeORM.Base;
using Net.FreeORM.Data.Client;
using System;

namespace Net.FreeORM.ConnectionStringBuilding.Test
{
    internal class ConnectionTester
    {
        public static bool TestConnection(ConnectionTypes connType, string connectionString)
        {
            bool retBool = false;
            try
            {
                using (IConnection conn = ConnectionFactory.CreateConnection(connType, connectionString))
                {
                    conn.Open();
                    retBool = true;
                    conn.Close();
                }
                FrmSecureHash.Error = retBool == true ? "Valid Connection" : "Unknown Error.";
            }
            catch (Exception exc)
            {
                FrmSecureHash.Error = exc.Message;
                retBool = false;
            }
            return retBool;
        }
    }
}