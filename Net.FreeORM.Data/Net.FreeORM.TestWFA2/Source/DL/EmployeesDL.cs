using Net.FreeORM.Logic.BaseDal;
using Net.FreeORM.TestWFA2.Source.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.FreeORM.TestWFA2.Source.DL
{
    internal class EmployeesDL : BaseDL
    {
        internal EmployeesDL()
            : base()
        {
        }


        public List<Employees> Employees
        {
            get
            {
                List<Employees> lst = new List<Employees>();
                try
                {
                    lst = TableRecords<Employees>();
                }
                catch (Exception)
                {
                    throw;
                }
                return lst;
            }
        }


    }
}