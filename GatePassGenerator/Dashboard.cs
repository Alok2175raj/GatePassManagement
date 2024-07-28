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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        String role;
        public Dashboard(String role)
        {
            InitializeComponent();
            this.role = role;

        }


         private void Dashboard_Load(object sender, EventArgs e)
         {
            String backgroundName;
            if("ADMIN".Equals(role))
            {
                employeeToolStripMenuItem.Visible = true;
                backgroundName = "gatePassBg1";
                labelWelcomeText.Text = "Admin Dashboard";
            }
            else
            {
                employeeToolStripMenuItem.Visible = false;
               backgroundName = "gatePassBg2";
                labelWelcomeText.Text = "Employee Dashboard";
            }
            Image image = Image.FromFile(Utility.getImageStorePath(backgroundName));
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
         }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You want to Logout?", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You want to Exit?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addEmployToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<AddEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<AddEmployee>().First().BringToFront();

            }
            else
            {
                AddEmployee addEmployee = new AddEmployee();
                addEmployee.Show();
            }
        }

        private void updateEmployToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<UpadateEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<UpadateEmployee>().First().BringToFront();

            }
            else
            {
                UpadateEmployee upadateEmployee = new UpadateEmployee();
                upadateEmployee.Show();
            }
        }

        private void viewAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<ViewEmployee>().First().BringToFront();

            }
            else
            {
                ViewEmployee viewEmployee = new ViewEmployee();
                viewEmployee.Show();
            }
        }

        private void deleteEmployToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DeleteEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<DeleteEmployee>().First().BringToFront();

            }
            else
            {
                DeleteEmployee deleteEmployee = new DeleteEmployee();
                deleteEmployee.Show();
            }

        }

        private void addVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddVisitor>().Count() == 1)
            {
                Application.OpenForms.OfType<AddVisitor>().First().BringToFront();

            }
            else
            {
                AddVisitor addVisitor = new AddVisitor();
                addVisitor.Show();
            }

        }

        private void updateVisitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UpdateVisitor>().Count() == 1)
            {
                Application.OpenForms.OfType<UpdateVisitor>().First().BringToFront();

            }
            else
            {
                UpdateVisitor updateVisitor = new UpdateVisitor();
                updateVisitor.Show();
            }

        }

        private void updateVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewVisitors>().Count() == 1)
            {
                Application.OpenForms.OfType<ViewVisitors>().First().BringToFront();

            }
            else
            {
                ViewVisitors viewVisitors = new ViewVisitors();
                viewVisitors.Show();
            }

        }
    }
}
