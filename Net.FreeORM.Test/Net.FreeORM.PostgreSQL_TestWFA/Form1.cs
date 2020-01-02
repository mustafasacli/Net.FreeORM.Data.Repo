using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net.FreeORM.PostgreSQL_TestWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            frm_person fp = new frm_person();
            fp.ShowDialog();
        }
    }
}
