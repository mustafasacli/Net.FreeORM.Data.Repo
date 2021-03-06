﻿using FirebirdSql.Data.FirebirdClient;
using Net.FreeORM.Base;
using System;
using System.Data;
using System.Data.Common;

namespace Net.FreeORM.Data.Client
{
    class ConnectionFireBird : IConnection
    {
        FbConnection Conn = null;
        FbTransaction Trans = null;

        internal ConnectionFireBird()
        {
            Conn = new FbConnection();
        }

        internal ConnectionFireBird(string connectionString)
        {
            Conn = new FbConnection(connectionString);
        }

        public DbConnectionStringBuilder ConnectionStringBuilder
        {
            get { return new FbConnectionStringBuilder(); }
        }

        public ConnectionTypes ConnectionType
        {
            get { return ConnectionTypes.FireBird; }
        }

        public string ConnectionString
        {
            get { return Conn.ConnectionString; }
            set { Conn.ConnectionString = value; }
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
                dtAdapter = new FbDataAdapter();
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
