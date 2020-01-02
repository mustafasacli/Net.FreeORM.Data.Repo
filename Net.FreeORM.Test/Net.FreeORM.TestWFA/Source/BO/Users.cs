using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA.Source.DL;
using System;

namespace Net.FreeORM.TestWFA.Source.BO
{
    public class Users : BaseBO
    {
        private long _OBJID;
        public long OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _UserName;
        public string UserName
        {
            set { _UserName = value; OnPropertyChanged("UserName"); }
            get { return _UserName; }
        }

        private string _Pass;
        public string Pass
        {
            set { _Pass = value; OnPropertyChanged("Pass"); }
            get { return _Pass; }
        }

        private string _FirstName;
        public string FirstName
        {
            set { _FirstName = value; OnPropertyChanged("FirstName"); }
            get { return _FirstName; }
        }

        private string _LastName;
        public string LastName
        {
            set { _LastName = value; OnPropertyChanged("LastName"); }
            get { return _LastName; }
        }

        private int _IsActive;
        public int IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "Users";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (UsersDL _usersdlDL = new UsersDL())
                {
                    return _usersdlDL.Insert(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int InsertAndGetId()
        {
            try
            {
                using (UsersDL _usersdlDL = new UsersDL())
                {
                    return _usersdlDL.InsertAndGetId(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int Update()
        {
            try
            {
                using (UsersDL _usersdlDL = new UsersDL())
                {
                    return _usersdlDL.Update(this);
                }
            }
            catch
            {
                throw;
            }
        }

        internal int Delete()
        {
            try
            {
                using (UsersDL _usersdlDL = new UsersDL())
                {
                    return _usersdlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}