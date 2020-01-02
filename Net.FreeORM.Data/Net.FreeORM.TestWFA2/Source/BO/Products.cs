using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class Products : BaseBO
    {
        public Products()
        {
        }

        private int _ProductID;

        public int ProductID
        {
            set { _ProductID = value; OnPropertyChanged("ProductID"); }
            get { return _ProductID; }
        }

        private string _ProductName;

        public string ProductName
        {
            set { _ProductName = value; OnPropertyChanged("ProductName"); }
            get { return _ProductName; }
        }

        private int _SupplierID;

        public int SupplierID
        {
            set { _SupplierID = value; OnPropertyChanged("SupplierID"); }
            get { return _SupplierID; }
        }

        private int _CategoryID;

        public int CategoryID
        {
            set { _CategoryID = value; OnPropertyChanged("CategoryID"); }
            get { return _CategoryID; }
        }

        private string _QuantityPerUnit;

        public string QuantityPerUnit
        {
            set { _QuantityPerUnit = value; OnPropertyChanged("QuantityPerUnit"); }
            get { return _QuantityPerUnit; }
        }

        private decimal _UnitPrice;

        public decimal UnitPrice
        {
            set { _UnitPrice = value; OnPropertyChanged("UnitPrice"); }
            get { return _UnitPrice; }
        }

        private Int16 _UnitsInStock;

        public Int16 UnitsInStock
        {
            set { _UnitsInStock = value; OnPropertyChanged("UnitsInStock"); }
            get { return _UnitsInStock; }
        }

        private Int16 _UnitsOnOrder;

        public Int16 UnitsOnOrder
        {
            set { _UnitsOnOrder = value; OnPropertyChanged("UnitsOnOrder"); }
            get { return _UnitsOnOrder; }
        }

        private Int16 _ReorderLevel;

        public Int16 ReorderLevel
        {
            set { _ReorderLevel = value; OnPropertyChanged("ReorderLevel"); }
            get { return _ReorderLevel; }
        }

        private bool _Discontinued;

        public bool Discontinued
        {
            set { _Discontinued = value; OnPropertyChanged("Discontinued"); }
            get { return _Discontinued; }
        }

        public override string GetIdColumn()
        {
            return "ProductID";
        }

        public override string GetTableName()
        {
            return "Products";
        }

        internal int Insert()
        {
            try
            {
                using (ProductsDL _productsdlDL = new ProductsDL())
                {
                    return _productsdlDL.Insert(this);
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
                using (ProductsDL _productsdlDL = new ProductsDL())
                {
                    return _productsdlDL.InsertAndGetId(this);
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
                using (ProductsDL _productsdlDL = new ProductsDL())
                {
                    return _productsdlDL.Update(this);
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
                using (ProductsDL _productsdlDL = new ProductsDL())
                {
                    return _productsdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}