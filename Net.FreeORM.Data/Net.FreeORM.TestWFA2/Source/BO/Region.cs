using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class Region : BaseBO
    {
        public Region()
        {
        }

        private int _RegionID;

        public int RegionID
        {
            set { _RegionID = value; OnPropertyChanged("RegionID"); }
            get { return _RegionID; }
        }

        private char _RegionDescription;

        public char RegionDescription
        {
            set { _RegionDescription = value; OnPropertyChanged("RegionDescription"); }
            get { return _RegionDescription; }
        }

        public override string GetIdColumn()
        {
            return "";
        }

        public override string GetTableName()
        {
            return "Region";
        }

        internal int Insert()
        {
            try
            {
                using (RegionDL _regiondlDL = new RegionDL())
                {
                    return _regiondlDL.Insert(this);
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
                using (RegionDL _regiondlDL = new RegionDL())
                {
                    return _regiondlDL.InsertAndGetId(this);
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
                using (RegionDL _regiondlDL = new RegionDL())
                {
                    return _regiondlDL.Update(this);
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
                using (RegionDL _regiondlDL = new RegionDL())
                {
                    return _regiondlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}