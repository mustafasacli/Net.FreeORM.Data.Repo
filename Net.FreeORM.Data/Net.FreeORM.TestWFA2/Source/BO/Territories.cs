using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class Territories : BaseBO
    {
        public Territories()
        {
        }

        private string _TerritoryID;

        public string TerritoryID
        {
            set { _TerritoryID = value; OnPropertyChanged("TerritoryID"); }
            get { return _TerritoryID; }
        }

        private char _TerritoryDescription;

        public char TerritoryDescription
        {
            set { _TerritoryDescription = value; OnPropertyChanged("TerritoryDescription"); }
            get { return _TerritoryDescription; }
        }

        private int _RegionID;

        public int RegionID
        {
            set { _RegionID = value; OnPropertyChanged("RegionID"); }
            get { return _RegionID; }
        }

        public override string GetIdColumn()
        {
            return "";
        }

        public override string GetTableName()
        {
            return "Territories";
        }

        internal int Insert()
        {
            try
            {
                using (TerritoriesDL _territoriesdlDL = new TerritoriesDL())
                {
                    return _territoriesdlDL.Insert(this);
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
                using (TerritoriesDL _territoriesdlDL = new TerritoriesDL())
                {
                    return _territoriesdlDL.InsertAndGetId(this);
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
                using (TerritoriesDL _territoriesdlDL = new TerritoriesDL())
                {
                    return _territoriesdlDL.Update(this);
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
                using (TerritoriesDL _territoriesdlDL = new TerritoriesDL())
                {
                    return _territoriesdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}