namespace GatePassGenerator
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVisitorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validatePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWelcomeText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.visitorToolStripMenuItem,
            this.generatePassToolStripMenuItem,
            this.validatePassToolStripMenuItem,
            this.filterPassToolStripMenuItem,
            this.btnLogOut,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1666, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployToolStripMenuItem,
            this.updateEmployToolStripMenuItem,
            this.viewAllEmployeeToolStripMenuItem,
            this.deleteEmployToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeToolStripMenuItem.Image")));
            this.employeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(226, 64);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployToolStripMenuItem
            // 
            this.addEmployToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addEmployToolStripMenuItem.Image")));
            this.addEmployToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addEmployToolStripMenuItem.Name = "addEmployToolStripMenuItem";
            this.addEmployToolStripMenuItem.Size = new System.Drawing.Size(421, 72);
            this.addEmployToolStripMenuItem.Text = "Add Employee";
            this.addEmployToolStripMenuItem.Click += new System.EventHandler(this.addEmployToolStripMenuItem_Click);
            // 
            // updateEmployToolStripMenuItem
            // 
            this.updateEmployToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateEmployToolStripMenuItem.Image")));
            this.updateEmployToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateEmployToolStripMenuItem.Name = "updateEmployToolStripMenuItem";
            this.updateEmployToolStripMenuItem.Size = new System.Drawing.Size(421, 72);
            this.updateEmployToolStripMenuItem.Text = "Update Employee";
            this.updateEmployToolStripMenuItem.Click += new System.EventHandler(this.updateEmployToolStripMenuItem_Click);
            // 
            // viewAllEmployeeToolStripMenuItem
            // 
            this.viewAllEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAllEmployeeToolStripMenuItem.Image")));
            this.viewAllEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewAllEmployeeToolStripMenuItem.Name = "viewAllEmployeeToolStripMenuItem";
            this.viewAllEmployeeToolStripMenuItem.Size = new System.Drawing.Size(421, 72);
            this.viewAllEmployeeToolStripMenuItem.Text = "View All Employee";
            this.viewAllEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewAllEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployToolStripMenuItem
            // 
            this.deleteEmployToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteEmployToolStripMenuItem.Image")));
            this.deleteEmployToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteEmployToolStripMenuItem.Name = "deleteEmployToolStripMenuItem";
            this.deleteEmployToolStripMenuItem.Size = new System.Drawing.Size(421, 72);
            this.deleteEmployToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployToolStripMenuItem_Click);
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVisitorToolStripMenuItem,
            this.updateVisitorToolStripMenuItem,
            this.updateVisitorToolStripMenuItem1});
            this.visitorToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitorToolStripMenuItem.Image")));
            this.visitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(181, 64);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // addVisitorToolStripMenuItem
            // 
            this.addVisitorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addVisitorToolStripMenuItem.Image")));
            this.addVisitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addVisitorToolStripMenuItem.Name = "addVisitorToolStripMenuItem";
            this.addVisitorToolStripMenuItem.Size = new System.Drawing.Size(387, 72);
            this.addVisitorToolStripMenuItem.Text = "Add Visitor";
            this.addVisitorToolStripMenuItem.Click += new System.EventHandler(this.addVisitorToolStripMenuItem_Click);
            // 
            // updateVisitorToolStripMenuItem
            // 
            this.updateVisitorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateVisitorToolStripMenuItem.Image")));
            this.updateVisitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateVisitorToolStripMenuItem.Name = "updateVisitorToolStripMenuItem";
            this.updateVisitorToolStripMenuItem.Size = new System.Drawing.Size(387, 72);
            this.updateVisitorToolStripMenuItem.Text = "View Visitor";
            this.updateVisitorToolStripMenuItem.Click += new System.EventHandler(this.updateVisitorToolStripMenuItem_Click);
            // 
            // updateVisitorToolStripMenuItem1
            // 
            this.updateVisitorToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("updateVisitorToolStripMenuItem1.Image")));
            this.updateVisitorToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateVisitorToolStripMenuItem1.Name = "updateVisitorToolStripMenuItem1";
            this.updateVisitorToolStripMenuItem1.Size = new System.Drawing.Size(387, 72);
            this.updateVisitorToolStripMenuItem1.Text = "Update Visitor";
            this.updateVisitorToolStripMenuItem1.Click += new System.EventHandler(this.updateVisitorToolStripMenuItem1_Click);
            // 
            // generatePassToolStripMenuItem
            // 
            this.generatePassToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePassToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generatePassToolStripMenuItem.Image")));
            this.generatePassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.generatePassToolStripMenuItem.Name = "generatePassToolStripMenuItem";
            this.generatePassToolStripMenuItem.Size = new System.Drawing.Size(289, 64);
            this.generatePassToolStripMenuItem.Text = "Generate Pass ";
            // 
            // validatePassToolStripMenuItem
            // 
            this.validatePassToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.validatePassToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validatePassToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("validatePassToolStripMenuItem.Image")));
            this.validatePassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.validatePassToolStripMenuItem.Name = "validatePassToolStripMenuItem";
            this.validatePassToolStripMenuItem.Size = new System.Drawing.Size(265, 64);
            this.validatePassToolStripMenuItem.Text = "Validate Pass";
            // 
            // filterPassToolStripMenuItem
            // 
            this.filterPassToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPassToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filterPassToolStripMenuItem.Image")));
            this.filterPassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.filterPassToolStripMenuItem.Name = "filterPassToolStripMenuItem";
            this.filterPassToolStripMenuItem.Size = new System.Drawing.Size(228, 64);
            this.filterPassToolStripMenuItem.Text = "Filter Pass";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Silver;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(191, 64);
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 64);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelWelcomeText
            // 
            this.labelWelcomeText.AutoSize = true;
            this.labelWelcomeText.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcomeText.Font = new System.Drawing.Font("Calibri", 31.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeText.Location = new System.Drawing.Point(1025, 149);
            this.labelWelcomeText.Name = "labelWelcomeText";
            this.labelWelcomeText.Size = new System.Drawing.Size(629, 104);
            this.labelWelcomeText.TabIndex = 1;
            this.labelWelcomeText.Text = "Welcome Admin";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 709);
            this.Controls.Add(this.labelWelcomeText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validatePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem addEmployToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVisitorToolStripMenuItem1;
        private System.Windows.Forms.Label labelWelcomeText;
    }
}