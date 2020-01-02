using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class CustomerCustomerDemo : BaseBO
    {
        public CustomerCustomerDemo()
        {
        }

        private char _CustomerID;

        public char CustomerID
        {
            set { _CustomerID = value; OnPropertyChanged("CustomerID"); }
            get { return _CustomerID; }
        }

        private char _CustomerTypeID;

        public char CustomerTypeID
        {
            set { _CustomerTypeID = value; OnPropertyChanged("CustomerTypeID"); }
            get { return _CustomerTypeID; }
        }

        public override string GetIdColumn()
        {
            return "";
        }

        public override string GetTableName()
        {
            return "CustomerCustomerDemo";
        }

        internal int Insert()
        {
            try
            {
                using (CustomerCustomerDemoDL _customercustomerdemodlDL = new CustomerCustomerDemoDL())
                {
                    return _customercustomerdemodlDL.Insert(this);
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
                using (CustomerCustomerDemoDL _customercustomerdemodlDL = new CustomerCustomerDemoDL())
                {
                    return _customercustomerdemodlDL.InsertAndGetId(this);
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
                using (CustomerCustomerDemoDL _customercustomerdemodlDL = new CustomerCustomerDemoDL())
                {
                    return _customercustomerdemodlDL.Update(this);
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
                using (CustomerCustomerDemoDL _customercustomerdemodlDL = new CustomerCustomerDemoDL())
                {
                    return _customercustomerdemodlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}