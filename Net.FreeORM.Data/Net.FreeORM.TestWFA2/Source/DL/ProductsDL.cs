using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class ProductsDL : BaseDL
    {
        internal ProductsDL()
            : base()
        {
        }

        public List<Products> Products
        {
            get
            {
                List<Products> lst = new List<Products>();
                try
                {
                    lst = TableRecords<Products>();
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