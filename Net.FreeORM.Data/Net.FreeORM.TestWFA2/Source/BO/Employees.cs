using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class Employees : BaseBO
    {
        public Employees()
        {
        }

        private int _EmployeeID;

        public int EmployeeID
        {
            set { _EmployeeID = value; OnPropertyChanged("EmployeeID"); }
            get { return _EmployeeID; }
        }

        private string _LastName;

        public string LastName
        {
            set { _LastName = value; OnPropertyChanged("LastName"); }
            get { return _LastName; }
        }

        private string _FirstName;

        public string FirstName
        {
            set { _FirstName = value; OnPropertyChanged("FirstName"); }
            get { return _FirstName; }
        }

        private string _Title;

        public string Title
        {
            set { _Title = value; OnPropertyChanged("Title"); }
            get { return _Title; }
        }

        private string _TitleOfCourtesy;

        public string TitleOfCourtesy
        {
            set { _TitleOfCourtesy = value; OnPropertyChanged("TitleOfCourtesy"); }
            get { return _TitleOfCourtesy; }
        }

        private DateTime _BirthDate;

        public DateTime BirthDate
        {
            set { _BirthDate = value; OnPropertyChanged("BirthDate"); }
            get { return _BirthDate; }
        }

        private DateTime _HireDate;

        public DateTime HireDate
        {
            set { _HireDate = value; OnPropertyChanged("HireDate"); }
            get { return _HireDate; }
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

        private string _HomePhone;

        public string HomePhone
        {
            set { _HomePhone = value; OnPropertyChanged("HomePhone"); }
            get { return _HomePhone; }
        }

        private string _Extension;

        public string Extension
        {
            set { _Extension = value; OnPropertyChanged("Extension"); }
            get { return _Extension; }
        }

        private byte[] _Photo;

        public byte[] Photo
        {
            set { _Photo = value; OnPropertyChanged("Photo"); }
            get { return _Photo; }
        }

        private string _Notes;

        public string Notes
        {
            set { _Notes = value; OnPropertyChanged("Notes"); }
            get { return _Notes; }
        }

        private int _ReportsTo;

        public int ReportsTo
        {
            set { _ReportsTo = value; OnPropertyChanged("ReportsTo"); }
            get { return _ReportsTo; }
        }

        private string _PhotoPath;

        public string PhotoPath
        {
            set { _PhotoPath = value; OnPropertyChanged("PhotoPath"); }
            get { return _PhotoPath; }
        }

        public override string GetTableName()
        {
            return "Employees";
        }

        public override string GetIdColumn()
        {
            return "EmployeeID";
        }

        internal int Insert()
        {
            try
            {
                using (EmployeesDL _employeesdlDL = new EmployeesDL())
                {
                    return _employeesdlDL.Insert(this);
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
                using (EmployeesDL _employeesdlDL = new EmployeesDL())
                {
                    return _employeesdlDL.InsertAndGetId(this);
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
                using (EmployeesDL _employeesdlDL = new EmployeesDL())
                {
                    return _employeesdlDL.Update(this);
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
                using (EmployeesDL _employeesdlDL = new EmployeesDL())
                {
                    return _employeesdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}