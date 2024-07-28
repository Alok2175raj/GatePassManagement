using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePassGenerator
{
    public partial class DeleteEmployee : Form
    {

        DatabaseOperation databaseOperation = new DatabaseOperation();
        String query;
        DataSet ds;
        Boolean employeeAvailable = false;

        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txtUsername.Text;
                query = "select e.*,a.* from employee as e inner join appUser as a on e.appuser_fk=a.appuser_pk where a.username='" + username + "'";
                ds = databaseOperation.getData(query);
                if (ds != null && ds.Tables[0].Rows.Count !=0)
                {
                    employeeAvailable = true;
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtHireDate.Text = ds.Tables[0].Rows[0][2].ToString();
                    textBox1.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtState.Text = ds.Tables[0].Rows[0][7].ToString();


                }
                else
                {
                    employeeAvailable = false;
                    MessageBox.Show("Employee not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                

            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void clearAllFields()
        {
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtGender.SelectedIndex = -1;
            textBox1.Clear();
            txtHireDate.ResetText();
            txtName.Clear();
            employeeAvailable = false ;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(employeeAvailable)
                {
                    query = "delete from employee from appUser where appuser_fk=appuser_pk and username='" + txtUsername.Text + "'";
                    databaseOperation.setData(query, "Employee deleted");
                    query = "delete from appUser where username = '" + txtUsername + "'";
                    databaseOperation.setData(query,null);
                    clearAllFields();
                }
                else
                {
                    employeeAvailable=false;
                    MessageBox.Show("Employee not found.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            clearAllFields();
        }
    }
}
