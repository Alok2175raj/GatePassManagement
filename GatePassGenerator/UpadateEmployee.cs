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
    public partial class UpadateEmployee : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        String query;
        DataSet ds;
        Boolean employeeAvailable = false;
        public UpadateEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txtUsername.Text;
                query = "Select e.*,a.* from employee as e inner join appUser as a on e.appuser_fk=a.appuser_pk where a.username='" + username + "'";
                ds = databaseOperation.getData(query);
                if (ds != null && ds.Tables[0].Rows.Count != 0)
                {
                    employeeAvailable = true;
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtHireDate.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][3].ToString();
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
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String contact = txtContact.Text;
                String gender = txtGender.Text;
                String address = txtAddress.Text;
                String city = txtCity.Text;
                String state = txtState.Text;
                String username = txtUsername.Text;

                if (employeeAvailable)
                {
                    if(!String.IsNullOrEmpty(name) && 
                        !String.IsNullOrEmpty(contact) &&
                        !String.IsNullOrEmpty(gender) &&
                        !String.IsNullOrEmpty(address) &&
                        !String.IsNullOrEmpty(city) &&
                        !String.IsNullOrEmpty(state) &&
                        !String.IsNullOrEmpty(username))                       
                    {
                        Int64 number = Int64.Parse(contact);
                        query = "update e set e.ename='" + name + "',e.contact=" + number + ",e.gender='" + gender + "',e.eaddress='" + address + "',e.city='" + city + "',e.estate='" + state + "' from employee as e inner join appUser as a on e.appuser_fk=a.appuser_pk where a.username= '" + username + "'";
                        databaseOperation.setData(query, "Employee updated");
                        clearAllFields();
                    }
                    else
                    {
                        MessageBox.Show("Fields empty.","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void clearAllFields()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            textBox1.Clear();
            txtGender.SelectedIndex = -1;
            txtHireDate.ResetText();
            txtState.Clear();
            employeeAvailable = false;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            clearAllFields();
        }
    }
}
