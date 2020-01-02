using Net.FreeORM.Entity.Base;
using Net.FreeORM.VistaDB_TestWFA.Source.DL;

namespace Net.FreeORM.VistaDB_TestWFA.Source.BO
{
    public class Roles : BaseBO
    {
        private int _OBJID;
        public int OBJID
        {
            set { _OBJID = value; OnPropertyChanged("OBJID"); }
            get { return _OBJID; }
        }

        private string _RoleName;
        public string RoleName
        {
            set { _RoleName = value; OnPropertyChanged("RoleName"); }
            get { return _RoleName; }
        }

        private byte _IsActive;
        public byte IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "Roles";
        }

        public override string GetIdColumn()
        {
            return "OBJID";
        }

        internal int Insert()
        {
            try
            {
                using (RolesDL _rolesdlDL = new RolesDL())
                {
                    return _rolesdlDL.Insert(this);
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
                using (RolesDL _rolesdlDL = new RolesDL())
                {
                    return _rolesdlDL.InsertAndGetId(this);
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
                using (RolesDL _rolesdlDL = new RolesDL())
                {
                    return _rolesdlDL.Update(this);
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
                using (RolesDL _rolesdlDL = new RolesDL())
                {
                    return _rolesdlDL.Delete(this);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
