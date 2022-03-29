namespace HospManSys
{
    partial class frmStaff
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConsultant = new System.Windows.Forms.Button();
            this.btnSeniorManagement = new System.Windows.Forms.Button();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnAppointmentManagement = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTitle.Location = new System.Drawing.Point(157, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Staff";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnConsultant);
            this.flowLayoutPanel1.Controls.Add(this.btnSeniorManagement);
            this.flowLayoutPanel1.Controls.Add(this.btnAdministrator);
            this.flowLayoutPanel1.Controls.Add(this.btnAppointmentManagement);
            this.flowLayoutPanel1.Controls.Add(this.btnFinance);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(397, 245);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnConsultant
            // 
            this.btnConsultant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultant.Location = new System.Drawing.Point(3, 3);
            this.btnConsultant.Name = "btnConsultant";
            this.btnConsultant.Size = new System.Drawing.Size(391, 41);
            this.btnConsultant.TabIndex = 0;
            this.btnConsultant.Text = "Consultant";
            this.btnConsultant.UseVisualStyleBackColor = true;
            this.btnConsultant.Visible = false;
            this.btnConsultant.Click += new System.EventHandler(this.btnConsultant_Click);
            // 
            // btnSeniorManagement
            // 
            this.btnSeniorManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeniorManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeniorManagement.Location = new System.Drawing.Point(3, 50);
            this.btnSeniorManagement.Name = "btnSeniorManagement";
            this.btnSeniorManagement.Size = new System.Drawing.Size(391, 41);
            this.btnSeniorManagement.TabIndex = 1;
            this.btnSeniorManagement.Text = "Senior Management";
            this.btnSeniorManagement.UseVisualStyleBackColor = true;
            this.btnSeniorManagement.Visible = false;
            this.btnSeniorManagement.Click += new System.EventHandler(this.btnSeniorManagement_Click);
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrator.Location = new System.Drawing.Point(3, 97);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(391, 41);
            this.btnAdministrator.TabIndex = 2;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Visible = false;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnAppointmentManagement
            // 
            this.btnAppointmentManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAppointmentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentManagement.Location = new System.Drawing.Point(3, 144);
            this.btnAppointmentManagement.Name = "btnAppointmentManagement";
            this.btnAppointmentManagement.Size = new System.Drawing.Size(391, 41);
            this.btnAppointmentManagement.TabIndex = 3;
            this.btnAppointmentManagement.Text = "Appointment Management";
            this.btnAppointmentManagement.UseVisualStyleBackColor = true;
            this.btnAppointmentManagement.Visible = false;
            this.btnAppointmentManagement.Click += new System.EventHandler(this.btnAppointmentManagement_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.Location = new System.Drawing.Point(3, 191);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(391, 41);
            this.btnFinance.TabIndex = 4;
            this.btnFinance.Text = "Finance";
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Visible = false;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(420, 308);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmStaff";
            this.Text = "frStaff";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConsultant;
        private System.Windows.Forms.Button btnSeniorManagement;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnAppointmentManagement;
        private System.Windows.Forms.Button btnFinance;
    }
}