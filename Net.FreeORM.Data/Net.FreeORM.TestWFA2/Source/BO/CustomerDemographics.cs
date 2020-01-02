using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class CustomerDemographics : BaseBO
    {
        public CustomerDemographics()
            : base()
        {
        }

        private char _CustomerTypeID;
        public char CustomerTypeID
        {
            set { _CustomerTypeID = value; OnPropertyChanged("CustomerTypeID"); }
            get { return _CustomerTypeID; }
        }

        private string _CustomerDesc;
        public string CustomerDesc
        {
            set { _CustomerDesc = value; OnPropertyChanged("CustomerDesc"); }
            get { return _CustomerDesc; }
        }

        public override string GetIdColumn()
        {
            return "";
        }

        public override string GetTableName()
        {
            return "CustomerDemographics";
        }

        internal int Insert()
        {
            try
            {
                using (CustomerDemographicsDL _customerdemographicsdlDL = new CustomerDemographicsDL())
                {
                    return _customerdemographicsdlDL.Insert(this);
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
                using (CustomerDemographicsDL _customerdemographicsdlDL = new CustomerDemographicsDL())
                {
                    return _customerdemographicsdlDL.InsertAndGetId(this);
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
                using (CustomerDemographicsDL _customerdemographicsdlDL = new CustomerDemographicsDL())
                {
                    return _customerdemographicsdlDL.Update(this);
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
                using (CustomerDemographicsDL _customerdemographicsdlDL = new CustomerDemographicsDL())
                {
                    return _customerdemographicsdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}