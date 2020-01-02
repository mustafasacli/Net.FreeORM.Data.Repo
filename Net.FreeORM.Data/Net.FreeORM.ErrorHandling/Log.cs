﻿using Net.FreeORM.Entity.Base;
using System;

namespace Net.FreeORM.ErrorHandling
{
    internal class Log : BaseBO
    {
        private Int32 _OBJID;
        private String _Message;
        private String _StackTrace;
        private String _Title;
        private String _LogCode;
        private Int32 _UserId;
        private Int32 _LogType;
        private DateTime _LogTime;

        public Log(Int32 userId)
        {
            UserId = userId;
            LogTime = DateTime.Now;
            OnPropertyChanged("MachineName");
        }

        public Log()
        {
            LogTime = DateTime.Now;
            OnPropertyChanged("MachineName");
        }

        public Int32 OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        public String Message
        {
            set { _Message = value; OnPropertyChanged("Message"); }
            get { return _Message; }
        }

        public String StackTrace
        {
            set { _StackTrace = value; OnPropertyChanged("StackTrace"); }
            get { return _StackTrace; }
        }

        public String Title
        {
            set { _Title = value; OnPropertyChanged("Title"); }
            get { return _Title; }
        }

        public String LogCode
        {
            set { _LogCode = value; OnPropertyChanged("LogCode"); }
            get { return _LogCode; }
        }

        public Int32 UserId
        {
            set { _UserId = value; OnPropertyChanged("UserId"); }
            get { return _UserId; }
        }

        public DateTime LogTime
        {
            set { _LogTime = value; OnPropertyChanged("LogTime"); }
            get { return _LogTime; }
        }

        public Int32 LogType
        {
            set { _LogType = value; OnPropertyChanged("LogType"); }
            get { return _LogType; }
        }

        public String MachineName
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
                    _machineName = String.Empty;
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
            return "FreeLogEntry";
        }
    }
}