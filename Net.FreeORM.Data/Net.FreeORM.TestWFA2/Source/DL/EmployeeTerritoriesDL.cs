using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class EmployeeTerritoriesDL : BaseDL
    {
        internal EmployeeTerritoriesDL()
            : base()
        {
        }

        public List<EmployeeTerritories> EmployeeTerritories
        {
            get
            {
                List<EmployeeTerritories> lst = new List<EmployeeTerritories>();
                try
                {
                    lst = TableRecords<EmployeeTerritories>();
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