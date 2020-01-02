using Net.FreeORM.TestWFA.Source.BO;
using Net.FreeORM.TestWFA.Source.DL;
using System;
using System.Windows.Forms;

namespace Net.FreeORM.TestWFA
{
    public partial class FrmUser : Form
    {
        bool boLock = false;
        Users users;
        public FrmUser()
        {
            try
            {
                InitializeComponent();
                users = new Users();
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
                using (UsersDL usrgDL = new UsersDL())
                {
                    grdUsers.DataSource = usrgDL.GetTable(users);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        void Add()
        {
            try
            {
                users.IsActive = 1;
                users.Insert();
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
            finally
            {
                users = new Users();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUsr();
        }

        void UpdateUsr()
        {
            try
            {
                users.OBJID = ToInt(grdUsers.SelectedRows[0].Cells["OBJID"].Value);
                if (users.ChangeSetCount > 1)
                {
                    users.Update();
                    RefreshGrd();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
            finally
            {
                users = new Users();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        void Delete()
        {
            try
            {
                users = new Users();
                users.OBJID = ToInt(grdUsers.SelectedRows[0].Cells["OBJID"].Value);
                users.Delete();
                RefreshGrd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}", ex.Message));
            }
            finally
            {
                users = new Users();
            }
        }

        private void grdUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                boLock = true;
                if (grdUsers.SelectedRows.Count > 0)
                {
                    txtId.Text = grdUsers.SelectedRows[0].Cells["OBJID"].Value.ToString();
                    txtUserName.Text = grdUsers.SelectedRows[0].Cells["UserName"].Value.ToString();
                    txtPass.Text = grdUsers.SelectedRows[0].Cells["Pass"].Value.ToString();
                    txtFirstName.Text = grdUsers.SelectedRows[0].Cells["FirstName"].Value.ToString();
                    txtLastName.Text = grdUsers.SelectedRows[0].Cells["LastName"].Value.ToString();
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

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                users.UserName = txtUserName.Text;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                users.Pass = txtPass.Text;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                users.FirstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (boLock == false)
                users.LastName = txtLastName.Text;
        }
    }
}