namespace HospManSys
{
    partial class frmAppointmentManagement
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
            this.panelPatientData = new System.Windows.Forms.Panel();
            this.dgvPatientReferral = new System.Windows.Forms.DataGridView();
            this.fpdgvPatientReferralControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdateDGV = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lbldgvTitle = new System.Windows.Forms.Label();
            this.btnEnrollPatients = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnApproveReferrals = new System.Windows.Forms.Button();
            this.panelPatientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientReferral)).BeginInit();
            this.fpdgvPatientReferralControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPatientData
            // 
            this.panelPatientData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPatientData.AutoSize = true;
            this.panelPatientData.BackColor = System.Drawing.Color.Transparent;
            this.panelPatientData.Controls.Add(this.dgvPatientReferral);
            this.panelPatientData.Controls.Add(this.fpdgvPatientReferralControls);
            this.panelPatientData.Controls.Add(this.lbldgvTitle);
            this.panelPatientData.Location = new System.Drawing.Point(12, 12);
            this.panelPatientData.Name = "panelPatientData";
            this.panelPatientData.Size = new System.Drawing.Size(1240, 563);
            this.panelPatientData.TabIndex = 17;
            // 
            // dgvPatientReferral
            // 
            this.dgvPatientReferral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPatientReferral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientReferral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientReferral.Location = new System.Drawing.Point(24, 98);
            this.dgvPatientReferral.MultiSelect = false;
            this.dgvPatientReferral.Name = "dgvPatientReferral";
            this.dgvPatientReferral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientReferral.Size = new System.Drawing.Size(1178, 365);
            this.dgvPatientReferral.TabIndex = 20;
            // 
            // fpdgvPatientReferralControls
            // 
            this.fpdgvPatientReferralControls.AutoSize = true;
            this.fpdgvPatientReferralControls.Controls.Add(this.btnUpdateDGV);
            this.fpdgvPatientReferralControls.Controls.Add(this.btnEnroll);
            this.fpdgvPatientReferralControls.Controls.Add(this.btnApprove);
            this.fpdgvPatientReferralControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpdgvPatientReferralControls.Location = new System.Drawing.Point(0, 523);
            this.fpdgvPatientReferralControls.Name = "fpdgvPatientReferralControls";
            this.fpdgvPatientReferralControls.Size = new System.Drawing.Size(1240, 40);
            this.fpdgvPatientReferralControls.TabIndex = 19;
            // 
            // btnUpdateDGV
            // 
            this.btnUpdateDGV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateDGV.AutoSize = true;
            this.btnUpdateDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDGV.Location = new System.Drawing.Point(3, 3);
            this.btnUpdateDGV.Name = "btnUpdateDGV";
            this.btnUpdateDGV.Size = new System.Drawing.Size(80, 34);
            this.btnUpdateDGV.TabIndex = 18;
            this.btnUpdateDGV.Text = "Update";
            this.btnUpdateDGV.UseVisualStyleBackColor = true;
            this.btnUpdateDGV.Click += new System.EventHandler(this.btnUpdateDGV_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.AutoSize = true;
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(89, 3);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(148, 34);
            this.btnEnroll.TabIndex = 16;
            this.btnEnroll.Text = "Enroll Selected";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.AutoSize = true;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(243, 3);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(92, 34);
            this.btnApprove.TabIndex = 21;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Visible = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApproveReferral_Click);
            // 
            // lbldgvTitle
            // 
            this.lbldgvTitle.AutoSize = true;
            this.lbldgvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldgvTitle.Location = new System.Drawing.Point(446, -1);
            this.lbldgvTitle.Name = "lbldgvTitle";
            this.lbldgvTitle.Size = new System.Drawing.Size(290, 42);
            this.lbldgvTitle.TabIndex = 17;
            this.lbldgvTitle.Text = "Enroll Referrals";
            this.lbldgvTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnrollPatients
            // 
            this.btnEnrollPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnrollPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollPatients.Location = new System.Drawing.Point(3, 3);
            this.btnEnrollPatients.Name = "btnEnrollPatients";
            this.btnEnrollPatients.Size = new System.Drawing.Size(626, 94);
            this.btnEnrollPatients.TabIndex = 18;
            this.btnEnrollPatients.Text = "Enroll Patients";
            this.btnEnrollPatients.UseVisualStyleBackColor = true;
            this.btnEnrollPatients.Click += new System.EventHandler(this.btnEnrollPatients_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnApproveReferrals, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEnrollPatients, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 581);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 100);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // btnApproveReferrals
            // 
            this.btnApproveReferrals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApproveReferrals.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveReferrals.Location = new System.Drawing.Point(635, 3);
            this.btnApproveReferrals.Name = "btnApproveReferrals";
            this.btnApproveReferrals.Size = new System.Drawing.Size(626, 94);
            this.btnApproveReferrals.TabIndex = 19;
            this.btnApproveReferrals.Text = "Approve Referrals";
            this.btnApproveReferrals.UseVisualStyleBackColor = true;
            this.btnApproveReferrals.Click += new System.EventHandler(this.btnApproveReferrals_Click);
            // 
            // AppointmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelPatientData);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "AppointmentManagement";
            this.Text = "AppointmentManagement";
            this.panelPatientData.ResumeLayout(false);
            this.panelPatientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientReferral)).EndInit();
            this.fpdgvPatientReferralControls.ResumeLayout(false);
            this.fpdgvPatientReferralControls.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelPatientData;
        private System.Windows.Forms.DataGridView dgvPatientReferral;
        private System.Windows.Forms.FlowLayoutPanel fpdgvPatientReferralControls;
        private System.Windows.Forms.Button btnUpdateDGV;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Label lbldgvTitle;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnEnrollPatients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnApproveReferrals;
    }
}