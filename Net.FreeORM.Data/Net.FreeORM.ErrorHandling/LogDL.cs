using Net.FreeORM.Logic.BaseDal;
using System;

namespace Net.FreeORM.ErrorHandling
{
    internal class LogDL : BaseDL
    {
        public LogDL()
            : base()
        { }

        public LogDL(String logName)
            : base(logName)
        {
        }
    }
}