using System;
using Net.FreeORM.Base;
using Net.FreeORM.Logic.BaseDal;

namespace Net.FreeORM.PostgreSQL_TestWFA.Source.DL
{
    internal class MainDL : BaseDL
    {
        public MainDL()
            : base("mainPgSql")
        {
        }
    }
}
