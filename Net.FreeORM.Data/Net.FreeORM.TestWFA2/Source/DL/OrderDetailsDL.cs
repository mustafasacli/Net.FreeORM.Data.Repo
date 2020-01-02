using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class OrderDetailsDL : BaseDL
    {
        internal OrderDetailsDL()
            : base()
        {
        }

        public List<OrderDetails> OrderDetails
        {
            get
            {
                List<OrderDetails> lst = new List<OrderDetails>();
                try
                {
                    lst = TableRecords<OrderDetails>();
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