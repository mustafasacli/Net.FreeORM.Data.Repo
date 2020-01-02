using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class EmployeeTerritories : BaseBO
    {
        public EmployeeTerritories()
        {
        }

        private int _EmployeeID;

        public int EmployeeID
        {
            set { _EmployeeID = value; OnPropertyChanged("EmployeeID"); }
            get { return _EmployeeID; }
        }

        private string _TerritoryID;

        public string TerritoryID
        {
            set { _TerritoryID = value; OnPropertyChanged("TerritoryID"); }
            get { return _TerritoryID; }
        }

        public override string GetIdColumn()
        {
            return "";
        }

        public override string GetTableName()
        {
            return "EmployeeTerritories";
        }

        internal int Insert()
        {
            try
            {
                using (EmployeeTerritoriesDL _employeeterritoriesdlDL = new EmployeeTerritoriesDL())
                {
                    return _employeeterritoriesdlDL.Insert(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int InsertAndGetId()
        {
            try
            {
                using (EmployeeTerritoriesDL _employeeterritoriesdlDL = new EmployeeTerritoriesDL())
                {
                    return _employeeterritoriesdlDL.InsertAndGetId(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int Update()
        {
            try
            {
                using (EmployeeTerritoriesDL _employeeterritoriesdlDL = new EmployeeTerritoriesDL())
                {
                    return _employeeterritoriesdlDL.Update(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int Delete()
        {
            try
            {
                using (EmployeeTerritoriesDL _employeeterritoriesdlDL = new EmployeeTerritoriesDL())
                {
                    return _employeeterritoriesdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}