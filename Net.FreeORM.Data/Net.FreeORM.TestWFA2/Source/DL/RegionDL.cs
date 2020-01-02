using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class RegionDL : BaseDL
    {
        internal RegionDL()
            : base()
        {
        }

        public List<Region> Regions
        {
            get
            {
                List<Region> lst = new List<Region>();

                try
                {
                    lst = TableRecords<Region>();
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