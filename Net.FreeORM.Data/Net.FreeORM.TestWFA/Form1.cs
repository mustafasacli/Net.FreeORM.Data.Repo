using Net.FreeORM.Base;
using Net.FreeORM.Data.Client;
using Npgsql;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Net.FreeORM.TestWFA
{
    public partial class Form1 : Form
    {
        ConnectionTypes connType;

        public Form1()
        {
            InitializeComponent();
            LoadCombo();
        }

        public DataTable GetTable(ConnectionTypes ConnType, string connectionString, string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (IConnection Conn = ConnectionFactory.CreateConnection(ConnType, connectionString))
                {
                    using (DbCommand cmd = Conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.Text;
                        using (DbDataAdapter adapter = Conn.CreateAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            Conn.Open();
                            adapter.Fill(dt);
                            Conn.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable GetTable(string connectionString, string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (NpgsqlConnection Conn = new NpgsqlConnection(connectionString))
                {
                    using (NpgsqlCommand cmd = Conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.Text;
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            Conn.Open();
                            adapter.Fill(dt);
                            Conn.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        private void LoadCombo()
        {
            try
            {
                cmbxConnTypes.Items.Clear();
                foreach (var item in Enum.GetValues(typeof(ConnectionTypes)))
                {
                    cmbxConnTypes.Items.Add(item);
                }
                cmbxConnTypes.Refresh();
                cmbxConnTypes.SelectedIndex = cmbxConnTypes.Items.Count > 0 ? 1 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}\nStack Trace : {1}", ex.Message, ex.StackTrace));
            }
        }

        private void GetData()
        {
            DataTable dt = null;
            try
            {
                if (txtConnStr.Text.Length > 0 && txtQuery.Text.Length > 0)
                {
                    dt = GetTable(connType, txtConnStr.Text, txtQuery.Text);
                    //dt = GetTable(txtConnStr.Text, txtQuery.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message : {0}\nStack Trace : {1}", ex.Message, ex.StackTrace));
            }
            grdTable.DataSource = dt;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void cmbxConnTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            connType = cmbxConnTypes.SelectedIndex < 0 ? ConnectionTypes.SqlServer : (ConnectionTypes)cmbxConnTypes.SelectedItem;
        }
    }
}
