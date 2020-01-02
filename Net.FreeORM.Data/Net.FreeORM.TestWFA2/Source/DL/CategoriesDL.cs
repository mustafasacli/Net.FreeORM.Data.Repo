using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class CategoriesDL : BaseDL
    {
        internal CategoriesDL()
            : base()
        {
        }

        public List<Categories> Categories
        {
            get
            {
                List<Categories> lst = new List<Categories>();
                try
                {
                    lst = TableRecords<Categories>();
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