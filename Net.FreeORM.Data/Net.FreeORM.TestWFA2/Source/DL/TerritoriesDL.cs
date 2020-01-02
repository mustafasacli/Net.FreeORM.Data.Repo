using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class TerritoriesDL : BaseDL
    {
        internal TerritoriesDL()
            : base()
        {
        }

        public List<Territories> Territories
        {
            get
            {
                List<Territories> lst = new List<Territories>();
                try
                {
                    lst = TableRecords<Territories>();
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