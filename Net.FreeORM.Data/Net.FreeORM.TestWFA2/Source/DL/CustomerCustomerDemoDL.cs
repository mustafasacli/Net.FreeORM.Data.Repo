using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class CustomerCustomerDemoDL : BaseDL
    {
        internal CustomerCustomerDemoDL()
            : base()
        {
        }

        public List<CustomerCustomerDemo> CustomerCustomerDemos
        {
            get
            {
                List<CustomerCustomerDemo> lst = new List<CustomerCustomerDemo>();
                try
                {
                    lst = TableRecords<CustomerCustomerDemo>();
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