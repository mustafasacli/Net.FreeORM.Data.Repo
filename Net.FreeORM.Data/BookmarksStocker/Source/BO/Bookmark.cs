using BookmarksStocker.Source.DL;
using Net.FreeORM.Entity.Base;
using System;

namespace BookmarksStocker.Source.BO
{
    public class Bookmark : BaseBO
    {
        public Bookmark()
        {
        }

        private long _ID;

        public long ID
        {
            set { _ID = value; OnPropertyChanged("ID"); }
            get { return _ID; }
        }

        private string _Name;

        public string Name
        {
            set { _Name = value; OnPropertyChanged("Name"); }
            get { return _Name; }
        }

        private string _Description;

        public string Description
        {
            set { _Description = value; OnPropertyChanged("Description"); }
            get { return _Description; }
        }

        private string _Url;

        public string Url
        {
            set { _Url = value; OnPropertyChanged("Url"); }
            get { return _Url; }
        }

        private DateTime _CreationTime;

        public DateTime CreationTime
        {
            set { _CreationTime = value; OnPropertyChanged("CreationTime"); }
            get { return _CreationTime; }
        }

        private DateTime _UpdateTime;

        public DateTime UpdateTime
        {
            set { _UpdateTime = value; OnPropertyChanged("UpdateTime"); }
            get { return _UpdateTime; }
        }

        public override string GetTableName()
        {
            return "Bookmarks";
        }

        public override string GetIdColumn()
        {
            return "ID";
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