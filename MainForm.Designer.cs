
namespace CarWashApplication
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWash = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblFinances = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblFinances);
            this.panel1.Controls.Add(this.lblServices);
            this.panel1.Controls.Add(this.lblCustomers);
            this.panel1.Controls.Add(this.lblEmployees);
            this.panel1.Controls.Add(this.lblWash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 577);
            this.panel1.TabIndex = 0;
            // 
            // lblWash
            // 
            this.lblWash.AutoSize = true;
            this.lblWash.Location = new System.Drawing.Point(111, 78);
            this.lblWash.Name = "lblWash";
            this.lblWash.Size = new System.Drawing.Size(50, 20);
            this.lblWash.TabIndex = 0;
            this.lblWash.Text = "Wash";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(89, 120);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(87, 20);
            this.lblEmployees.TabIndex = 1;
            this.lblEmployees.Text = "Employees";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(90, 164);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(86, 20);
            this.lblCustomers.TabIndex = 2;
            this.lblCustomers.Text = "Customers";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(111, 212);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(69, 20);
            this.lblServices.TabIndex = 3;
            this.lblServices.Text = "Services";
            // 
            // lblFinances
            // 
            this.lblFinances.AutoSize = true;
            this.lblFinances.Location = new System.Drawing.Point(111, 271);
            this.lblFinances.Name = "lblFinances";
            this.lblFinances.Size = new System.Drawing.Size(74, 20);
            this.lblFinances.TabIndex = 4;
            this.lblFinances.Text = "Finances";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(126, 385);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(59, 20);
            this.lblLogout.TabIndex = 5;
            this.lblLogout.Text = "Logout";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 577);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblFinances;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblWash;
    }
}

