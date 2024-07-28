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
    public partial class AddEmployee : Form
    {

        DatabaseOperation databaseOperation = new DatabaseOperation();
        String query;
        DataSet ds;

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String hireDate = txtHireDate.Text;
                String contact = textBox1.Text;
                String gender = txtGender.Text;
                String address = txtAddress.Text;
                String city = txtCity.Text;
                String state = txtState.Text;
                String userName = txtUsername.Text;
                String password = txtPassword.Text;

                if (!String.IsNullOrEmpty(name) &&
                    !String.IsNullOrEmpty(hireDate) &&
                    !String.IsNullOrEmpty(contact) &&
                    !String.IsNullOrEmpty(gender) &&
                    !String.IsNullOrEmpty(address) &&
                    !String.IsNullOrEmpty(city) &&
                    !String.IsNullOrEmpty(state) &&
                    !String.IsNullOrEmpty(userName) &&
                    !String.IsNullOrEmpty(password))
                {
                    Int64 contactInt = Int64.Parse(contact);
                    query = "Select * from appUser where username ='" + userName + "' and uenabled=1 ";
                    ds = databaseOperation.getData(query);

                    if (ds != null && ds.Tables[0].Rows.Count == 0)
                    {
                        query = "insert onto appUser(username,upass,urole) values ('" + userName + "','" + password + "','EMPLOYEE')";
                        databaseOperation.setData(query, null);

                        query = "Select * from appUser where username= '" + userName + "' and upass = '" + password + "' and uenable=1";
                        ds = databaseOperation.getData(query);

                        query = "Insert into employee(ename,hiredate,contact,gender,eaddress,city,estate,appuser_fk) values ('" + name + "','" + hireDate + "'," + contactInt + ",'" + gender + "','" + address + "','" + city + "','" + state + "'," + ds.Tables[0].Rows[0][0] + ")";
                        databaseOperation.setData(query, "Employee added successfully.");
                        clearAllFields();
                    }
                    else
                    {
                        MessageBox.Show("Username already linked with another account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Field Empty. Fill and try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in Add Employee btnSave Click : " + ex);
                MessageBox.Show("Something Wwnt wrong : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void clearAllFields()
        {
            txtName.Clear();
            txtHireDate.ResetText();
            textBox1.Clear();
            txtGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtUsername.Clear();
            txtPassword.Clear();


        }
    }
}
