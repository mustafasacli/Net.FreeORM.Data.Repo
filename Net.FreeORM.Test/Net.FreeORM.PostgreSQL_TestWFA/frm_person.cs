using Net.FreeORM.PostgreSQL_TestWFA.Source.BO;
using Net.FreeORM.PostgreSQL_TestWFA.Source.DL;
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
    public partial class frm_person : Form
    {
        person p;
        bool boLock = false;

        public frm_person()
        {
            try
            {
                InitializeComponent();
                p = new person();
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void RefreshGrd()
        {
            try
            {
                using (personDL frLgDL = new personDL())
                {
                    grdPerson.DataSource = frLgDL.GetTable(new person());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                p.Insert();
                MessageBox.Show("Insert Success.");
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (p.ChangeSetCount > 1)
                    p.Update();

                MessageBox.Show("Update Success.");
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                p.Delete();
                MessageBox.Show("Delete Success.");
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void grdPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            int _id;
            int.TryParse(txt_id.Text, out _id);
            p.id = _id;
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                p.firstname = txt_firstname.Text;
        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                p.lastname = txt_lastname.Text;
        }

        private void grdPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                boLock = true;
                p = new person();
                if (grdPerson.SelectedRows.Count > 0)
                {
                    txt_id.Text = string.Format("{0}", grdPerson.SelectedRows[0].Cells["id"].Value);
                    txt_firstname.Text = string.Format("{0}", grdPerson.SelectedRows[0].Cells["firstname"].Value);
                    txt_lastname.Text = string.Format("{0}", grdPerson.SelectedRows[0].Cells["lastname"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
            finally
            {
                boLock = false;
            }
        }
    }
}