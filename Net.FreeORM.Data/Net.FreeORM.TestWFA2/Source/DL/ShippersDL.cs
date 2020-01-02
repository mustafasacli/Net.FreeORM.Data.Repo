using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class ShippersDL : BaseDL
    {
        internal ShippersDL()
            : base()
        {
        }

        public List<Shippers> Shippers
        {
            get
            {
                List<Shippers> lst = new List<Shippers>();
                try
                {
                    lst = TableRecords<Shippers>();
                }
                catch (Exception)
                {
                    throw;
                }
                return lst;
            }
        }
    }
}