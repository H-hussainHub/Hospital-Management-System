namespace HospManSys
{
    partial class frmSeniorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeniorManagement));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGenerateFinanceReport = new System.Windows.Forms.Button();
            this.btnGeneratePerformanceReport = new System.Windows.Forms.Button();
            this.pbFinanceReport = new System.Windows.Forms.PictureBox();
            this.pbPerformanceReport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinanceReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerformanceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbFinanceReport);
            this.splitContainer1.Panel1.Controls.Add(this.pbPerformanceReport);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1131, 641);
            this.splitContainer1.SplitterDistance = 581;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGenerateFinanceReport);
            this.flowLayoutPanel1.Controls.Add(this.btnGeneratePerformanceReport);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1131, 56);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnGenerateFinanceReport
            // 
            this.btnGenerateFinanceReport.AutoSize = true;
            this.btnGenerateFinanceReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateFinanceReport.Location = new System.Drawing.Point(3, 3);
            this.btnGenerateFinanceReport.Name = "btnGenerateFinanceReport";
            this.btnGenerateFinanceReport.Size = new System.Drawing.Size(264, 53);
            this.btnGenerateFinanceReport.TabIndex = 0;
            this.btnGenerateFinanceReport.Text = "Generate Finance Report";
            this.btnGenerateFinanceReport.UseVisualStyleBackColor = true;
            this.btnGenerateFinanceReport.Click += new System.EventHandler(this.btnGenerateFinanceReport_Click);
            // 
            // btnGeneratePerformanceReport
            // 
            this.btnGeneratePerformanceReport.AutoSize = true;
            this.btnGeneratePerformanceReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePerformanceReport.Location = new System.Drawing.Point(273, 3);
            this.btnGeneratePerformanceReport.Name = "btnGeneratePerformanceReport";
            this.btnGeneratePerformanceReport.Size = new System.Drawing.Size(309, 53);
            this.btnGeneratePerformanceReport.TabIndex = 1;
            this.btnGeneratePerformanceReport.Text = "Generate Performance Report";
            this.btnGeneratePerformanceReport.UseVisualStyleBackColor = true;
            this.btnGeneratePerformanceReport.Click += new System.EventHandler(this.btnGeneratePerformanceReport_Click);
            // 
            // pbFinanceReport
            // 
            this.pbFinanceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFinanceReport.Image = ((System.Drawing.Image)(resources.GetObject("pbFinanceReport.Image")));
            this.pbFinanceReport.Location = new System.Drawing.Point(0, 0);
            this.pbFinanceReport.Name = "pbFinanceReport";
            this.pbFinanceReport.Size = new System.Drawing.Size(1131, 581);
            this.pbFinanceReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFinanceReport.TabIndex = 0;
            this.pbFinanceReport.TabStop = false;
            // 
            // pbPerformanceReport
            // 
            this.pbPerformanceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPerformanceReport.Image = ((System.Drawing.Image)(resources.GetObject("pbPerformanceReport.Image")));
            this.pbPerformanceReport.Location = new System.Drawing.Point(0, 0);
            this.pbPerformanceReport.Name = "pbPerformanceReport";
            this.pbPerformanceReport.Size = new System.Drawing.Size(1131, 581);
            this.pbPerformanceReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerformanceReport.TabIndex = 1;
            this.pbPerformanceReport.TabStop = false;
            // 
            // frmSeniorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1131, 641);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSeniorManagement";
            this.Text = "frmSeniorManagement";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinanceReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerformanceReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGenerateFinanceReport;
        private System.Windows.Forms.Button btnGeneratePerformanceReport;
        private System.Windows.Forms.PictureBox pbFinanceReport;
        private System.Windows.Forms.PictureBox pbPerformanceReport;
    }
}