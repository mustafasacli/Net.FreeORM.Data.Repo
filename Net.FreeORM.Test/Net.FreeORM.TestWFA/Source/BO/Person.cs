using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA.Source.DL;
using System;

namespace Net.FreeORM.TestWFA.Source.BO
{
    public class Person : BaseBO
    {
        private int _Id;
        public int Id
        {
            set { _Id = value; OnPropertyChanged("Id"); }
            get { return _Id; }
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

        private int _CreatedBy;
        public int CreatedBy
        {
            set { _CreatedBy = value; OnPropertyChanged("CreatedBy"); }
            get { return _CreatedBy; }
        }

        private DateTime _CreationTime;
        public DateTime CreationTime
        {
            set { _CreationTime = value; OnPropertyChanged("CreationTime"); }
            get { return _CreationTime; }
        }

        private Int32 _IsActive;
        public Int32 IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "Person";
        }

        public override string GetIdColumn()
        {
            return "Id";
        }

        internal int Insert()
        {
            try
            {
                using (PersonDL _persondlDL = new PersonDL())
                {
                    return _persondlDL.Insert(this);
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
                using (PersonDL _persondlDL = new PersonDL())
                {
                    return _persondlDL.InsertAndGetId(this);
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
                using (PersonDL _persondlDL = new PersonDL())
                {
                    return _persondlDL.Update(this);
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
                using (PersonDL _persondlDL = new PersonDL())
                {
                    return _persondlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}