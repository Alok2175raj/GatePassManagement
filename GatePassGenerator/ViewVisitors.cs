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
    public partial class ViewVisitors : Form
    {

        DatabaseOperation databaseOperation = new DatabaseOperation();
        String query;
        DataSet ds;
        public ViewVisitors()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewVisitors_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select * from visitors";
                ds = databaseOperation.getData(query);
                dataGridViewVisitor.DataSource = ds.Tables[0];
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select * from visitors where vname like '" + txtSearch.Text + "%' or visitorId like '" + txtSearch.Text + "%'";
                databaseOperation.getData(query);
                dataGridViewVisitor.DataSource = ds.Tables[0];
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
