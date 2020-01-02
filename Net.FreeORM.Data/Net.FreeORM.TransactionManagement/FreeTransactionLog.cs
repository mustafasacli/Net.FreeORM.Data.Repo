using Net.FreeORM.Entity.Base;
using System;

namespace Net.FreeORM.TransactionManagement
{
    internal sealed class FreeTransactionLog : BaseBO, IDisposable
    {
        private int _UserId;
        private string _TransactionType;
        private int _LogObject;
        private DateTime _LogTime;
        private string _TableName;
        private int _OBJID;

        public FreeTransactionLog()
            : this(-1)
        {
        }

        public FreeTransactionLog(int userId)
        {
            if (userId > 0)
                this.UserId = userId;

            LogTime = DateTime.Now;
            OnPropertyChanged("MachineName");
        }

        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        public string TableName
        {
            set { _TableName = value; OnPropertyChanged("TableName"); }
            get { return _TableName; }
        }
        
        public DateTime LogTime
        {
            private set { _LogTime = value; OnPropertyChanged("LogTime"); }
            get { return _LogTime; }
        }

        public int LogObject
        {
            set { _LogObject = value; OnPropertyChanged("LogObject"); }
            get { return _LogObject; }
        }

        public string TransactionType
        {
            set { _TransactionType = value; OnPropertyChanged("TransactionType"); }
            get { return _TransactionType; }
        }

        public int UserId
        {
            set { _UserId = value; OnPropertyChanged("UserId"); }
            get { return _UserId; }
        }

        public string MachineName
        {
            get
            {
                string _machineName = string.Empty;

                try
                {
                    _machineName = Environment.MachineName;
                }
                catch (Exception)
                {
                    _machineName = string.Empty;
                }

                return _machineName;
            }
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        public override string GetTableName()
        {
            return "TransactionLog";
        }

        public int Insert()
        {
            int result = 0;

            try
            {
                using (TransactionLogDL transDL = new TransactionLogDL())
                {
                    result = transDL.Insert(this);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}