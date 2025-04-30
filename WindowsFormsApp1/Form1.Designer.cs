namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Full Name:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(234, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Birth Date:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(234, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Department:";
            // 
            // department
            // 
            this.department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(302, 420);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(144, 21);
            this.department.TabIndex = 4;
            // 
            // fullname
            // 
            this.fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullname.Location = new System.Drawing.Point(540, 387);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(144, 20);
            this.fullname.TabIndex = 5;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.Location = new System.Drawing.Point(540, 418);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(144, 20);
            this.email.TabIndex = 6;
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.add.Location = new System.Drawing.Point(341, 333);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(73, 31);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.delete.Location = new System.Drawing.Point(419, 333);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(73, 31);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete);
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.update.ForeColor = System.Drawing.SystemColors.WindowText;
            this.update.Location = new System.Drawing.Point(497, 333);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(73, 31);
            this.update.TabIndex = 10;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(149, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(600, 267);
            this.dataGridView2.TabIndex = 11;
            // 
            // birthdate
            // 
            this.birthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthdate.Location = new System.Drawing.Point(302, 387);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(144, 20);
            this.birthdate.TabIndex = 12;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.email);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker birthdate;
    }
}

