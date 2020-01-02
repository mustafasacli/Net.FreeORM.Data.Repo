using Net.FreeORM.TestWFA2.Source.BO;
using Net.FreeORM.TestWFA2.Source.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net.FreeORM.TestWFA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (CategoriesDL catDL = new CategoriesDL())
            {
                Categories cat = new Categories();
                grdVw.DataSource = catDL.GetTable(cat);//catDL.Categories; //catDL.GetTable(cat);
                grdVw.Refresh();
                cat.CategoryName = "MyNew Category";
                cat.Description = "New Added Category";
                cat.Picture = File.ReadAllBytes(@"C:\Users\Krkt\Desktop\suskun.jpg");
                cat.CategoryID = catDL.InsertAndGetId(cat);
                MessageBox.Show(cat.CategoryID.ToString());
                grdVw.DataSource = catDL.GetTable(cat);
                grdVw.Refresh();
            }
        }
    }
}
