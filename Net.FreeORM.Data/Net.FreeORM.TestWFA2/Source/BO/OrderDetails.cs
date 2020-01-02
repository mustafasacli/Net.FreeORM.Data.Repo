using Net.FreeORM.Entity.Base;
using Net.FreeORM.TestWFA2.Source.DL;
using System;

namespace Net.FreeORM.TestWFA2.Source.BO
{
    public class OrderDetails : BaseBO
    {
        public OrderDetails()
        {
        }

        private int _OrderID;

        public int OrderID
        {
            set { _OrderID = value; OnPropertyChanged("OrderID"); }
            get { return _OrderID; }
        }

        private int _ProductID;

        public int ProductID
        {
            set { _ProductID = value; OnPropertyChanged("ProductID"); }
            get { return _ProductID; }
        }

        private decimal _UnitPrice;

        public decimal UnitPrice
        {
            set { _UnitPrice = value; OnPropertyChanged("UnitPrice"); }
            get { return _UnitPrice; }
        }

        private Int16 _Quantity;

        public Int16 Quantity
        {
            set { _Quantity = value; OnPropertyChanged("Quantity"); }
            get { return _Quantity; }
        }

        private float _Discount;

        public float Discount
        {
            set { _Discount = value; OnPropertyChanged("Discount"); }
            get { return _Discount; }
        }

        public override string GetIdColumn()
        {
            return "";
        }

        public override string GetTableName()
        {
            return "Order Details";
        }

        internal int Insert()
        {
            try
            {
                using (OrderDetailsDL _orderdetailsdlDL = new OrderDetailsDL())
                {
                    return _orderdetailsdlDL.Insert(this);
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
                using (OrderDetailsDL _orderdetailsdlDL = new OrderDetailsDL())
                {
                    return _orderdetailsdlDL.InsertAndGetId(this);
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
                using (OrderDetailsDL _orderdetailsdlDL = new OrderDetailsDL())
                {
                    return _orderdetailsdlDL.Update(this);
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
                using (OrderDetailsDL _orderdetailsdlDL = new OrderDetailsDL())
                {
                    return _orderdetailsdlDL.Delete(this);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}