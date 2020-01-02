using Net.FreeORM.Base;
using Net.FreeORM.Entity.Base;
using System;
using Net.FreeORM.PostgreSQL_TestWFA.Source.DL;

namespace Net.FreeORM.PostgreSQL_TestWFA.Source.BO
{
    public class FreeLogEntry : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _Title;
        public string Title
        {
            set { _Title = value; OnPropertyChanged("Title"); }
            get { return _Title; }
        }

        private string _Message;
        public string Message
        {
            set { _Message = value; OnPropertyChanged("Message"); }
            get { return _Message; }
        }

        private string _StackTrace;
        public string StackTrace
        {
            set { _StackTrace = value; OnPropertyChanged("StackTrace"); }
            get { return _StackTrace; }
        }

        private DateTime _LogTime;
        public DateTime LogTime
        {
            set { _LogTime = value; OnPropertyChanged("LogTime"); }
            get { return _LogTime; }
        }

        private string _LogCode;
        public string LogCode
        {
            set { _LogCode = value; OnPropertyChanged("LogCode"); }
            get { return _LogCode; }
        }

        private int _UserId;
        public int UserId
        {
            set { _UserId = value; OnPropertyChanged("UserId"); }
            get { return _UserId; }
        }

        private int _LogType;
        public int LogType
        {
            set { _LogType = value; OnPropertyChanged("LogType"); }
            get { return _LogType; }
        }

        private string _MachineName;
        public string MachineName
        {
            set { _MachineName = value; OnPropertyChanged("MachineName"); }
            get { return _MachineName; }
        }

        public override string GetTableName()
        {
            return "FreeLogEntry";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (FreeLogEntryDL _freelogentrydlDL = new FreeLogEntryDL())
                {
                    return _freelogentrydlDL.Insert(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int InsertAndGetId()
        {
            try
            {
                using (FreeLogEntryDL _freelogentrydlDL = new FreeLogEntryDL())
                {
                    return _freelogentrydlDL.InsertAndGetId(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int Update()
        {
            try
            {
                using (FreeLogEntryDL _freelogentrydlDL = new FreeLogEntryDL())
                {
                    return _freelogentrydlDL.Update(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int Delete()
        {
            try
            {
                using (FreeLogEntryDL _freelogentrydlDL = new FreeLogEntryDL())
                {
                    return _freelogentrydlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
