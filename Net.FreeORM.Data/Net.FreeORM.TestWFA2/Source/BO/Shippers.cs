using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class Shippers : BaseBO
    {
        public Shippers()
        {
        }

        private int _ShipperID;

        public int ShipperID
        {
            set { _ShipperID = value; OnPropertyChanged("ShipperID"); }
            get { return _ShipperID; }
        }

        private string _CompanyName;

        public string CompanyName
        {
            set { _CompanyName = value; OnPropertyChanged("CompanyName"); }
            get { return _CompanyName; }
        }

        private string _Phone;

        public string Phone
        {
            set { _Phone = value; OnPropertyChanged("Phone"); }
            get { return _Phone; }
        }

        public override string GetIdColumn()
        {
            return "ShipperID";
        }

        public override string GetTableName()
        {
            return "Shippers";
        }

        internal int Insert()
        {
            try
            {
                using (ShippersDL _shippersdlDL = new ShippersDL())
                {
                    return _shippersdlDL.Insert(this);
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
                using (ShippersDL _shippersdlDL = new ShippersDL())
                {
                    return _shippersdlDL.InsertAndGetId(this);
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
                using (ShippersDL _shippersdlDL = new ShippersDL())
                {
                    return _shippersdlDL.Update(this);
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
                using (ShippersDL _shippersdlDL = new ShippersDL())
                {
                    return _shippersdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}