using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePassGenerator
{
    public partial class Form1 : Form
    {
        DatabaseOperation  databaseOperation = new DatabaseOperation();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from appUser where username='"+txtUsername.Text+"' and upass='"+txtPassword.Text+ "' and uenabled=1";
                DataSet ds = databaseOperation.getData(query);
                if(ds != null && ds.Tables[0].Rows.Count != 0) 
                {
                    String role = ds.Tables[0].Rows[0][3].ToString();
                    Int64 appUserPK = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    Dashboard dashboard = new Dashboard(role);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bad Credentials. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception in btnLogin click :"+ex);
                MessageBox.Show("Something went wrong : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
