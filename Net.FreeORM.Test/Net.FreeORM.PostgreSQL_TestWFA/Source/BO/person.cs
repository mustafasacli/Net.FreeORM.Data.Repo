using Net.FreeORM.Base;
using Net.FreeORM.Entity.Base;
using System;
using Net.FreeORM.PostgreSQL_TestWFA.Source.DL;

namespace Net.FreeORM.PostgreSQL_TestWFA.Source.BO
{
    public class person : BaseBO
    {
        private int _id;
        public int id
        {
            set { _id = value; OnPropertyChanged("id"); }
            get { return _id; }
        }

        private string _firstname;
        public string firstname
        {
            set { _firstname = value; OnPropertyChanged("firstname"); }
            get { return _firstname; }
        }

        private string _lastname;
        public string lastname
        {
            set { _lastname = value; OnPropertyChanged("lastname"); }
            get { return _lastname; }
        }

        public override string GetTableName()
        {
            return "person";
        }

        public override string GetIdColumn()
        {
            return "id";
        }

        internal int Insert()
        {
            try
            {
                using (personDL _persondlDL = new personDL())
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
                using (personDL _persondlDL = new personDL())
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
                using (personDL _persondlDL = new personDL())
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
                using (personDL _persondlDL = new personDL())
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
