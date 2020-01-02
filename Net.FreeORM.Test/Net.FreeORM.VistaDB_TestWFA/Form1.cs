using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net.FreeORM.VistaDB_TestWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUser usr = new FrmUser();
            usr.ShowDialog();
        }

        private void btnOpenPersons_Click(object sender, EventArgs e)
        {
            FrmPerson frmPrsn = new FrmPerson();
            frmPrsn.ShowDialog();
        }
    }
}
