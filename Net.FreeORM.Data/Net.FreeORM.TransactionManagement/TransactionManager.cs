using Net.FreeORM.ErrorHandling;
using System;
using System.Reflection;

namespace Net.FreeORM.TransactionManagement
{
    public class TransactionManager
    {
        private string connName = "main";
        private bool handleErrors = true;

        public TransactionManager()
            : this(string.Empty, true)
        {
        }



        /// <summary>
        ///
        /// </summary>
        /// <param name="connectionName">Connnection Name in conf.xml File. Default Value is "main".</param>
        /// <param name="willHandleErrors">if willHandleErrors is true, errors will be handled, else errors will be thrown.</param>
        public TransactionManager(string connectionName, bool willHandleErrors = true)
        {
            if (!string.IsNullOrWhiteSpace(connectionName))
            {
                this.connName = connectionName;
            }

            if (willHandleErrors != null)
                this.handleErrors = willHandleErrors;
        }

        public string ConnectionName { get { return this.connName; } }

        public virtual int LogInsert(int userId, string tableName, int logObjectId)
        {
            int result = 0;

            try
            {
                result = Log(userId, tableName, TransactionTypes.Insert, logObjectId);
            }
            catch (Exception ex)
            {
                result = -2;
                if (!this.handleErrors)
                {
                    throw;
                }
                else
                {
                    FreeLogger.LogException(ex, MethodBase.GetCurrentMethod(), userId);
                }
            }

            return result;
        }

        public virtual int LogUpdate(int userId, string tableName, int logObjectId)
        {
            int result = 0;

            try
            {
                result = Log(userId, tableName, TransactionTypes.Update, logObjectId);
            }
            catch (Exception ex)
            {
                result = -2;
                if (!this.handleErrors)
                {
                    throw;
                }
                else
                {
                    FreeLogger.LogException(ex, MethodBase.GetCurrentMethod(), userId);
                }
            }

            return result;
        }

        public virtual int LogDelete(int userId, string tableName, int logObjectId)
        {
            int result = 0;

            try
            {
                result = Log(userId, tableName, TransactionTypes.Delete, logObjectId);
            }
            catch (Exception ex)
            {
                result = -2;
                if (!this.handleErrors)
                {
                    throw;
                }
                else
                {
                    FreeLogger.LogException(ex, MethodBase.GetCurrentMethod(), userId);
                }
            }

            return result;
        }

        public virtual int LogLogin(int userId, string tableName)
        {
            int result = 0;

            try
            {
                result = Log(userId, tableName, TransactionTypes.Login, userId);
            }
            catch (Exception ex)
            {
                result = -2;
                if (!this.handleErrors)
                {
                    throw;
                }
                else
                {
                    FreeLogger.LogException(ex, MethodBase.GetCurrentMethod(), userId);
                }
            }

            return result;
        }

        public virtual int LogLogout(int userId, string tableName)
        {
            int result = 0;

            try
            {
                result = Log(userId, tableName, TransactionTypes.Logout, userId);
            }
            catch (Exception ex)
            {
                result = -2;
                if (!this.handleErrors)
                {
                    throw;
                }
                else
                {
                    FreeLogger.LogException(ex, MethodBase.GetCurrentMethod(), userId);
                }
            }

            return result;
        }

        protected virtual int Log(int userId, string tableName, string transctionType, int logObjectId)
        {
            int result = 0;

            try
            {
                FreeTransactionLog log = new FreeTransactionLog(userId)
                {
                    TableName = tableName,
                    TransactionType = transctionType
                };
                if (logObjectId > 0)
                {
                    log.LogObject = logObjectId;
                }

                using (TransactionLogDL transDL = new TransactionLogDL())
                {
                    result = transDL.Insert(log);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }
    }
}