using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class Categories : BaseBO
    {
        private int _CategoryID;

        private string _CategoryName;

        private string _Description;

        private byte[] _Picture;

        public Categories()
            : base()
        {
        }

        public int CategoryID
        {
            set { _CategoryID = value; OnPropertyChanged("CategoryID"); }
            get { return _CategoryID; }
        }

        public string CategoryName
        {
            set { _CategoryName = value; OnPropertyChanged("CategoryName"); }
            get { return _CategoryName; }
        }

        public string Description
        {
            set { _Description = value; OnPropertyChanged("Description"); }
            get { return _Description; }
        }

        public byte[] Picture
        {
            set { _Picture = value; OnPropertyChanged("Picture"); }
            get { return _Picture; }
        }

        public override string GetIdColumn()
        {
            return "CategoryID";
        }

        public override string GetTableName()
        {
            return "Categories";
        }

        internal int Delete()
        {
            try
            {
                using (CategoriesDL _categoriesdlDL = new CategoriesDL())
                {
                    return _categoriesdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int Insert()
        {
            try
            {
                using (CategoriesDL _categoriesdlDL = new CategoriesDL())
                {
                    return _categoriesdlDL.Insert(this);
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
                using (CategoriesDL _categoriesdlDL = new CategoriesDL())
                {
                    return _categoriesdlDL.InsertAndGetId(this);
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
                using (CategoriesDL _categoriesdlDL = new CategoriesDL())
                {
                    return _categoriesdlDL.Update(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}