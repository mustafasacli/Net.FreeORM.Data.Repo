﻿using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class Customers : BaseBO
    {
        public Customers()
        {
        }

        private char _CustomerID;

        public char CustomerID
        {
            set { _CustomerID = value; OnPropertyChanged("CustomerID"); }
            get { return _CustomerID; }
        }

        private string _CompanyName;

        public string CompanyName
        {
            set { _CompanyName = value; OnPropertyChanged("CompanyName"); }
            get { return _CompanyName; }
        }

        private string _ContactName;

        public string ContactName
        {
            set { _ContactName = value; OnPropertyChanged("ContactName"); }
            get { return _ContactName; }
        }

        private string _ContactTitle;

        public string ContactTitle
        {
            set { _ContactTitle = value; OnPropertyChanged("ContactTitle"); }
            get { return _ContactTitle; }
        }

        private string _Address;

        public string Address
        {
            set { _Address = value; OnPropertyChanged("Address"); }
            get { return _Address; }
        }

        private string _City;

        public string City
        {
            set { _City = value; OnPropertyChanged("City"); }
            get { return _City; }
        }

        private string _Region;

        public string Region
        {
            set { _Region = value; OnPropertyChanged("Region"); }
            get { return _Region; }
        }

        private string _PostalCode;

        public string PostalCode
        {
            set { _PostalCode = value; OnPropertyChanged("PostalCode"); }
            get { return _PostalCode; }
        }

        private string _Country;

        public string Country
        {
            set { _Country = value; OnPropertyChanged("Country"); }
            get { return _Country; }
        }

        private string _Phone;

        public string Phone
        {
            set { _Phone = value; OnPropertyChanged("Phone"); }
            get { return _Phone; }
        }

        private string _Fax;

        public string Fax
        {
            set { _Fax = value; OnPropertyChanged("Fax"); }
            get { return _Fax; }
        }

        public override string GetTableName()
        {
            return "Customers";
        }

        public override string GetIdColumn()
        {
            return "";
        }

        internal int Insert()
        {
            try
            {
                using (CustomersDL _customersdlDL = new CustomersDL())
                {
                    return _customersdlDL.Insert(this);
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
                using (CustomersDL _customersdlDL = new CustomersDL())
                {
                    return _customersdlDL.InsertAndGetId(this);
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
                using (CustomersDL _customersdlDL = new CustomersDL())
                {
                    return _customersdlDL.Update(this);
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
                using (CustomersDL _customersdlDL = new CustomersDL())
                {
                    return _customersdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}