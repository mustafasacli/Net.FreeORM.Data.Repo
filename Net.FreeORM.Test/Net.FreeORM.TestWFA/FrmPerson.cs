using Net.FreeORM.TestWFA.Source.BO;
using Net.FreeORM.TestWFA.Source.DL;
using System;
using System.Windows.Forms;

namespace Net.FreeORM.TestWFA
{
    public partial class FrmPerson : Form
    {
        bool boLock = false;
        Person p;

        public FrmPerson()
        {
            try
            {
                InitializeComponent();
                p = new Person();
                using (UsersDL usrsDL = new UsersDL())
                {
                    cmbxCreatedBy.DataSource = usrsDL.GetTableAsList<Users>();
                    cmbxCreatedBy.DisplayMember = "UserName";
                    cmbxCreatedBy.ValueMember = "OBJID";
                }
                RefreshGrd();

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void RefreshGrd()
        {
            boLock = true;
            try
            {
                cmbxCreatedBy.SelectedIndex = -1;
                using (PersonDL frLgDL = new PersonDL())
                {
                    grdPerson.DataSource = frLgDL.GetTable(p);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                boLock = false;
                p = new Person();
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                p.FirstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                p.LastName = txtLastName.Text;
        }

        private void txtCreatedUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                p.CreatedBy = ToInt(cmbxCreatedBy.SelectedValue);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                p.IsActive = 1;
                p.CreationTime = DateTime.Now;
                p.Insert();
                p = new Person();
                MessageBox.Show("Insert Success.");
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (p.ChangeSetCount > 1)
                {
                    p.Update();
                    p = new Person();
                }
                MessageBox.Show("Update Success.");
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    p.Delete();
                    p = new Person();
                    MessageBox.Show("Delete Success.");
                    RefreshGrd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
        }


        private void grdPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                boLock = true;
                p = new Person();
                if (grdPerson.SelectedRows.Count > 0)
                {
                    p.Id = ToInt(grdPerson.SelectedRows[0].Cells["Id"].Value);
                    txtFirstName.Text = grdPerson.SelectedRows[0].Cells["FirstName"].Value.ToString();
                    txtLastName.Text = grdPerson.SelectedRows[0].Cells["LastName"].Value.ToString();
                    txtCreationTime.Text = grdPerson.SelectedRows[0].Cells["CreationTime"].Value.ToString();
                    cmbxCreatedBy.SelectedValue = ToInt(grdPerson.SelectedRows[0].Cells["CreatedBy"].Value);
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


        int ToInt(object obj)
        {
            int i;
            try
            {
                i = Convert.ToInt32(obj);
            }
            catch (Exception)
            {
                i = 0;
            }
            return i;
        }
    }
}