using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class OrdersDL : BaseDL
    {
        internal OrdersDL()
            : base()
        {
        }

        public List<Orders> Orders
        {
            get
            {
                List<Orders> lst = new List<Orders>();
                try
                {
                    lst = TableRecords<Orders>();
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