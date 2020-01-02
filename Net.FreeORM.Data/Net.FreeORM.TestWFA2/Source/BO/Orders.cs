using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class Orders : BaseBO
    {
        public Orders()
        {
        }

        private int _OrderID;

        public int OrderID
        {
            set { _OrderID = value; OnPropertyChanged("OrderID"); }
            get { return _OrderID; }
        }

        private char _CustomerID;

        public char CustomerID
        {
            set { _CustomerID = value; OnPropertyChanged("CustomerID"); }
            get { return _CustomerID; }
        }

        private int _EmployeeID;

        public int EmployeeID
        {
            set { _EmployeeID = value; OnPropertyChanged("EmployeeID"); }
            get { return _EmployeeID; }
        }

        private DateTime _OrderDate;

        public DateTime OrderDate
        {
            set { _OrderDate = value; OnPropertyChanged("OrderDate"); }
            get { return _OrderDate; }
        }

        private DateTime _RequiredDate;

        public DateTime RequiredDate
        {
            set { _RequiredDate = value; OnPropertyChanged("RequiredDate"); }
            get { return _RequiredDate; }
        }

        private DateTime _ShippedDate;

        public DateTime ShippedDate
        {
            set { _ShippedDate = value; OnPropertyChanged("ShippedDate"); }
            get { return _ShippedDate; }
        }

        private int _ShipVia;

        public int ShipVia
        {
            set { _ShipVia = value; OnPropertyChanged("ShipVia"); }
            get { return _ShipVia; }
        }

        private decimal _Freight;

        public decimal Freight
        {
            set { _Freight = value; OnPropertyChanged("Freight"); }
            get { return _Freight; }
        }

        private string _ShipName;

        public string ShipName
        {
            set { _ShipName = value; OnPropertyChanged("ShipName"); }
            get { return _ShipName; }
        }

        private string _ShipAddress;

        public string ShipAddress
        {
            set { _ShipAddress = value; OnPropertyChanged("ShipAddress"); }
            get { return _ShipAddress; }
        }

        private string _ShipCity;

        public string ShipCity
        {
            set { _ShipCity = value; OnPropertyChanged("ShipCity"); }
            get { return _ShipCity; }
        }

        private string _ShipRegion;

        public string ShipRegion
        {
            set { _ShipRegion = value; OnPropertyChanged("ShipRegion"); }
            get { return _ShipRegion; }
        }

        private string _ShipPostalCode;

        public string ShipPostalCode
        {
            set { _ShipPostalCode = value; OnPropertyChanged("ShipPostalCode"); }
            get { return _ShipPostalCode; }
        }

        private string _ShipCountry;

        public string ShipCountry
        {
            set { _ShipCountry = value; OnPropertyChanged("ShipCountry"); }
            get { return _ShipCountry; }
        }

        public override string GetIdColumn()
        {
            return "OrderID";
        }

        public override string GetTableName()
        {
            return "Orders";
        }

        internal int Insert()
        {
            try
            {
                using (OrdersDL _ordersdlDL = new OrdersDL())
                {
                    return _ordersdlDL.Insert(this);
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
                using (OrdersDL _ordersdlDL = new OrdersDL())
                {
                    return _ordersdlDL.InsertAndGetId(this);
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
                using (OrdersDL _ordersdlDL = new OrdersDL())
                {
                    return _ordersdlDL.Update(this);
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
                using (OrdersDL _ordersdlDL = new OrdersDL())
                {
                    return _ordersdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}