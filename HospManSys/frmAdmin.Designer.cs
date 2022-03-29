namespace HospManSys
{
    partial class frmAdmin
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
            this.DeleteStaff = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.StaffidInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uDepartmentInput = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uPhoneNumberInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearFormBtn = new System.Windows.Forms.Button();
            this.updateUserBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.uEmailInput = new System.Windows.Forms.TextBox();
            this.uUnameInput = new System.Windows.Forms.TextBox();
            this.uIDInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteStaff
            // 
            this.DeleteStaff.Location = new System.Drawing.Point(129, 347);
            this.DeleteStaff.Name = "DeleteStaff";
            this.DeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.DeleteStaff.TabIndex = 47;
            this.DeleteStaff.Text = "DELETE STAFF";
            this.DeleteStaff.UseVisualStyleBackColor = true;
            this.DeleteStaff.Click += new System.EventHandler(this.DeleteStaff_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(372, 347);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 46;
            this.Logout.Text = "LOGOUT";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Staff ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // StaffidInput
            // 
            this.StaffidInput.Location = new System.Drawing.Point(275, 136);
            this.StaffidInput.Name = "StaffidInput";
            this.StaffidInput.Size = new System.Drawing.Size(91, 20);
            this.StaffidInput.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 41);
            this.label6.TabIndex = 43;
            this.label6.Text = "ADMIN";
            // 
            // uDepartmentInput
            // 
            this.uDepartmentInput.FormattingEnabled = true;
            this.uDepartmentInput.Items.AddRange(new object[] {
            "Consultant_clerk",
            "Financial_clerk",
            "Appointment_manager",
            "Senior_management",
            "Administrator"});
            this.uDepartmentInput.Location = new System.Drawing.Point(275, 188);
            this.uDepartmentInput.Name = "uDepartmentInput";
            this.uDepartmentInput.Size = new System.Drawing.Size(141, 21);
            this.uDepartmentInput.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Department";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // uPhoneNumberInput
            // 
            this.uPhoneNumberInput.Location = new System.Drawing.Point(275, 299);
            this.uPhoneNumberInput.Name = "uPhoneNumberInput";
            this.uPhoneNumberInput.Size = new System.Drawing.Size(141, 20);
            this.uPhoneNumberInput.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(468, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 412);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ClearFormBtn
            // 
            this.ClearFormBtn.Location = new System.Drawing.Point(291, 347);
            this.ClearFormBtn.Name = "ClearFormBtn";
            this.ClearFormBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearFormBtn.TabIndex = 38;
            this.ClearFormBtn.Text = "CLEAR";
            this.ClearFormBtn.UseVisualStyleBackColor = true;
            this.ClearFormBtn.Click += new System.EventHandler(this.ClearFormBtn_Click);
            // 
            // updateUserBtn
            // 
            this.updateUserBtn.Location = new System.Drawing.Point(210, 347);
            this.updateUserBtn.Name = "updateUserBtn";
            this.updateUserBtn.Size = new System.Drawing.Size(75, 23);
            this.updateUserBtn.TabIndex = 37;
            this.updateUserBtn.Text = "UPDATE";
            this.updateUserBtn.UseVisualStyleBackColor = true;
            this.updateUserBtn.Click += new System.EventHandler(this.Update_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(372, 134);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 36;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(47, 347);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(76, 23);
            this.addUserBtn.TabIndex = 35;
            this.addUserBtn.Text = "ADD";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // uEmailInput
            // 
            this.uEmailInput.Location = new System.Drawing.Point(275, 258);
            this.uEmailInput.Name = "uEmailInput";
            this.uEmailInput.Size = new System.Drawing.Size(141, 20);
            this.uEmailInput.TabIndex = 34;
            // 
            // uUnameInput
            // 
            this.uUnameInput.Location = new System.Drawing.Point(275, 224);
            this.uUnameInput.Name = "uUnameInput";
            this.uUnameInput.Size = new System.Drawing.Size(141, 20);
            this.uUnameInput.TabIndex = 33;
            // 
            // uIDInput
            // 
            this.uIDInput.Location = new System.Drawing.Point(275, 162);
            this.uIDInput.Name = "uIDInput";
            this.uIDInput.Size = new System.Drawing.Size(141, 20);
            this.uIDInput.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "PhoneNumber";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "User Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "User Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "User ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 55);
            this.label1.TabIndex = 27;
            this.label1.Text = "Staff Information";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1028, 508);
            this.Controls.Add(this.DeleteStaff);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StaffidInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uDepartmentInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uPhoneNumberInput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearFormBtn);
            this.Controls.Add(this.updateUserBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.uEmailInput);
            this.Controls.Add(this.uUnameInput);
            this.Controls.Add(this.uIDInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteStaff;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StaffidInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox uDepartmentInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uPhoneNumberInput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearFormBtn;
        private System.Windows.Forms.Button updateUserBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.TextBox uEmailInput;
        private System.Windows.Forms.TextBox uUnameInput;
        private System.Windows.Forms.TextBox uIDInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}