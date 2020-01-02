using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class CustomersDL : BaseDL
    {
        internal CustomersDL()
            : base()
        {
        }

        public List<Customers> Customers
        {
            get
            {
                List<Customers> lst = new List<Customers>();
                try
                {
                    lst = TableRecords<Customers>();
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