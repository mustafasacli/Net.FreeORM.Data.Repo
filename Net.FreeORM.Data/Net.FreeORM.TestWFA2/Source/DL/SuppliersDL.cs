using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class SuppliersDL : BaseDL
    {
        internal SuppliersDL()
            : base()
        {
        }

        public List<Suppliers> Suppliers
        {
            get
            {
                List<Suppliers> lst = new List<Suppliers>();
                try
                {
                    lst = TableRecords<Suppliers>();
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