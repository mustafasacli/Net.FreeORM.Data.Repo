using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Net.FreeORM.ErrorHandling
{
    public sealed class FreeLogger
    {
        #region [ LogMethod method ]

        /// <summary>
        /// Logs Exception which handled at given method name and given class name.
        /// </summary>
        /// <param name="ex">handled exception</param>
        /// <param name="className">class name</param>
        /// <param name="methodName">method name</param>
        public static void LogMethod(Exception ex, string className, string methodName)
        {
            try
            {
                FreeLogger _log = new FreeLogger()
                {
                    LogCode = string.Format("{0}_{1}_ERR", className, methodName).Replace(' ', '_'),
                    LogType = LogTypes.Error,
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    Title = string.Format("An Exception handled at {0} method in {1} class.", methodName, className)
                };
                _log.Write();

                if (ex.InnerException != null)
                {
                    LogMethod(ex.InnerException, className, methodName);
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion [ LogMethod method ]

        #region [ LogException method ]

        /// <summary>
        /// Logs exception with given parameters.
        /// </summary>
        /// <param name="ex">Exception object</param>
        /// <param name="method">MethodBase which exception handled in.</param>
        /// <param name="userId">User Id</param>
        public static void LogException(Exception ex, MethodBase method, int userId)
        {
            try
            {
                FreeLogger.LogException(ex, string.Format("An Exception handled at {0} method.", method.Name), "MTHD_ERR", userId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion [ LogException method ]

        #region [ LogException method ]

        /// <summary>
        /// Logs exception with given parameters.
        /// </summary>
        /// <param name="ex">Exception object</param>
        /// <param name="method">MethodBase which exception handled in.</param>
        public static void LogException(Exception ex, MethodBase method)
        {
            try
            {
                FreeLogger.LogException(ex, string.Format("An Exception handled at {0} method.", method.Name), "MTHD_ERR");
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion [ LogException method ]

        #region [ LogException method ]

        /// <summary>
        /// Logs exception with given parameters.
        /// </summary>
        /// <param name="ex">Exception object</param>
        /// <param name="title">Exception Title.</param>
        /// <param name="errorcode">Error Code for Exception.</param>
        /// <param name="userId">User Id</param>
        public static void LogException(Exception ex, string title, string errorcode, int userId)
        {
            try
            {
                FreeLogger freeLogger = new FreeLogger()
                {
                    Title = title,
                    LogCode = errorcode,
                    StackTrace = ex.StackTrace,
                    Message = ex.Message,
                    LogType = LogTypes.Error,
                    UserId = userId
                };
                freeLogger.Write();
                if (ex.InnerException != null)
                {
                    LogException(ex.InnerException, title, errorcode, userId);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion [ LogException method ]

        #region [ LogException method ]

        /// <summary>
        /// Logs exception with given parameters.
        /// </summary>
        /// <param name="ex">Exception object</param>
        /// <param name="title">Exception Title.</param>
        /// <param name="errorcode">Error Code for Exception.</param>
        public static void LogException(Exception ex, string title, string errorcode)
        {
            FreeLogger freeLogger = new FreeLogger()
            {
                Title = title,
                LogCode = errorcode,
                StackTrace = ex.StackTrace,
                Message = ex.Message,
                LogType = LogTypes.Error
            };
            freeLogger.Write();
            if (ex.InnerException != null)
            {
                LogException(ex.InnerException, title, errorcode);
            }
        }

        #endregion [ LogException method ]

        #region [ Private readonly fields ]

        private readonly String filePath = "C:/FreeORM/log/log.txt";

        #endregion [ Private readonly fields ]

        #region [ FreeLogger Ctors ]

        public FreeLogger()
        {
            LogTime = DateTime.Now;
            LogType = LogTypes.None;
        }

        public FreeLogger(Int32 userId)
        {
            UserId = userId;
            LogTime = DateTime.Now;
            LogType = LogTypes.None;
        }

        #endregion [ FreeLogger Ctors ]

        #region [ SaveType Property ]

        private SaveTypes SaveType
        {
            get
            {
                String saveType = ConfigurationUtil.LogType;
                saveType = saveType.TrimStart().TrimEnd().ToLower();

                switch (saveType)
                {
                    case "db":
                    case "dbase":
                    case "database":
                        return SaveTypes.Database;

                    case "fl":
                    case "file":
                    default:
                        return SaveTypes.File;
                }
            }
        }

        #endregion [ SaveType Property ]

        #region [ FilePath Property ]

        private String FilePath
        {
            get
            {
                return string.IsNullOrWhiteSpace(ConfigurationUtil.SaveFilePath) ? filePath : ConfigurationUtil.SaveFilePath;
            }
        }

        #endregion [ FilePath Property ]

        #region [ Private Fields ]

        private string _LogCode;
        private DateTime _LogTime;
        private LogTypes _LogType = LogTypes.None;
        private string _Message;
        private string _StackTrace;
        private string _Title;
        private int _UserId;

        #endregion [ Private Fields ]

        #region [ Properties ]

        public string LogCode
        {
            get { return _LogCode; }
            set { _LogCode = value; }
        }

        public DateTime LogTime
        {
            get { return _LogTime; }
            internal set { _LogTime = value; }
        }

        public LogTypes LogType
        {
            get { return _LogType; }
            set { _LogType = value; }
        }

        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        public string StackTrace
        {
            get { return _StackTrace; }
            set { _StackTrace = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        #endregion [ Properties ]

        #region [ Write method ]

        public void Write()
        {
            try
            {
                switch (SaveType)
                {
                    case SaveTypes.File:
                        Write2File();
                        break;

                    default:
                    case SaveTypes.Database:
                        Write2Db();
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion [ Write method ]

        #region [ Write2File method ]

        private void Write2File()
        {
            try
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.AppendFormat("Title : {0}", _Title).AppendLine();
                strBuilder.AppendFormat("Log Code : {0}", _LogCode).AppendLine();
                strBuilder.AppendFormat("Log Type : {0}", _LogType).AppendLine();
                strBuilder.AppendFormat("Message : {0}", _Message).AppendLine();
                strBuilder.AppendFormat("Stack Trace : {0}", _StackTrace).AppendLine();
                strBuilder.AppendFormat("Log Time : {0}", _LogTime.ToString("yyyy-MM-dd HH:mm:ss fff")).AppendLine();
                strBuilder.AppendLine("/* ------------------------------------------------*/");

                string path = string.Empty;
                FileInfo fInfo = new FileInfo(FilePath);
                int index = fInfo.Name.LastIndexOf(fInfo.Extension);
                if (index == -1)
                {
                    path = string.Format("{0}\\{1}{2:_dd_MM_yyyy}", fInfo.DirectoryName, fInfo.Name, DateTime.Now);
                }
                else
                {
                    path = string.Format("{0}\\{1}{2:_dd_MM_yyyy}{3}", fInfo.DirectoryName, fInfo.Name.Substring(0, index), DateTime.Now, fInfo.Extension);
                }

                //FileMode fMode = File.Exists(FilePath) == true ? FileMode.Append : FileMode.OpenOrCreate;
                FileMode fMode = File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate;

                //FileMode fMode = File.Exists(FilePath) ? FileMode.Append : FileMode.OpenOrCreate;
                using (StreamWriter outfile = new StreamWriter(new FileStream(path, fMode)))
                {
                    outfile.Write(strBuilder.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion [ Write2File method ]

        #region [ Write2Db method ]

        private void Write2Db()
        {
            try
            {
                using (LogDL lgDL = new LogDL())
                {
                    Log log = new Log()
                    {
                        Title = _Title,
                        LogCode = _LogCode,
                        LogTime = _LogTime,
                        Message = _Message,
                        StackTrace = _StackTrace,
                        LogType = (int)_LogType
                    };

                    if (_UserId != 0)
                        log.UserId = _UserId;

                    lgDL.Insert(log);
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion [ Write2Db method ]
    }
}