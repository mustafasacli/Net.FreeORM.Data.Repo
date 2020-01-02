using BookmarksStocker.Source.DL;
using Net.FreeORM.Entity.Base;
using System;

namespace BookmarksStocker.Source.BO
{
    internal class Browser : BaseBO
    {
        public Browser()
        {
        }

        private long _Id;

        public long Id
        {
            set { _Id = value; OnPropertyChanged("Id"); }
            get { return _Id; }
        }

        private string _Name;

        public string Name
        {
            set { _Name = value; OnPropertyChanged("Name"); }
            get { return _Name; }
        }

        private string _Path;

        public string Path
        {
            set { _Path = value; OnPropertyChanged("Path"); }
            get { return _Path; }
        }

        public override string GetTableName()
        {
            return "Browsers";
        }

        public override string GetIdColumn()
        {
            return "Id";
        }

        public override string ToString()
        {
            return Name;
        }

        internal int Insert()
        {
            try
            {
                using (BookmarksDL _bookmarksdlDL = new BookmarksDL())
                {
                    return _bookmarksdlDL.Insert(this);
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
                using (BookmarksDL _bookmarksdlDL = new BookmarksDL())
                {
                    return _bookmarksdlDL.InsertAndGetId(this);
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
                using (BookmarksDL _bookmarksdlDL = new BookmarksDL())
                {
                    return _bookmarksdlDL.Update(this);
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
                using (BookmarksDL _bookmarksdlDL = new BookmarksDL())
                {
                    return _bookmarksdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}