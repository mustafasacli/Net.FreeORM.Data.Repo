using IBM.Data.Informix;
using Net.FreeORM.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.FreeORM.Data.Client
{
    internal class ConnectionInformix : IConnection
    {
        IfxConnection Conn;
        IfxTransaction Trans;

        internal ConnectionInformix()
        {
            Conn = new IfxConnection();
        }

        internal ConnectionInformix(string connectionString)
        {
            Conn = new IfxConnection(connectionString);
        }


        public String ConnectionString
        {
            get { return Conn.ConnectionString; }
            set { Conn.ConnectionString = value; }
        }

        public DbConnectionStringBuilder ConnectionStringBuilder
        {
            get { return new IfxConnectionStringBuilder(); }
        }

        public ConnectionTypes ConnectionType
        {
            get { return ConnectionTypes.Informix; }
        }

        public void Open()
        {
            try
            {
                Conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Close()
        {
            try
            {
                Conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ConnectionState ConnectionState
        {
            get { return Conn.State; }
        }

        public DbTransaction Transaction
        {
            get { return Trans; }
        }

        public void CreateTransaction()
        {
            try
            {
                Trans = Conn.BeginTransaction();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateTransaction(IsolationLevel isolationLevel)
        {
            try
            {
                Trans = Conn.BeginTransaction(isolationLevel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CommitTransaction()
        {
            try
            {
                Trans.Commit();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                Trans.Rollback();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DbDataAdapter CreateAdapter()
        {
            try
            {
                DbDataAdapter dtAdapter = null;
                dtAdapter = new IfxDataAdapter();
                return dtAdapter;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DbCommand CreateCommand()
        {
            try
            {
                DbCommand cmd = null;
                cmd = Conn.CreateCommand();
                return cmd;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            try
            {
                if (Trans != null)
                {
                    Trans.Dispose();
                }
                if (Conn != null)
                {
                    if (Conn.State == System.Data.ConnectionState.Open)
                    {
                        Conn.Close();
                    }

                    Conn.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public String Database
        {
            get
            {
                try
                {
                    return Conn.Database;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}