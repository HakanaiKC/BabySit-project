
namespace Q2_Winform4
{
    partial class FrmEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtempName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.Label();
            this.dudSalary = new System.Windows.Forms.DomainUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.gbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(36, 39);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 82;
            this.dgvEmployee.RowTemplate.Height = 41;
            this.dgvEmployee.Size = new System.Drawing.Size(1005, 578);
            this.dgvEmployee.TabIndex = 0;
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.btnUpdate);
            this.gbAction.Controls.Add(this.btnDel);
            this.gbAction.Controls.Add(this.btnAdd);
            this.gbAction.Controls.Add(this.dudSalary);
            this.gbAction.Controls.Add(this.txtSalary);
            this.gbAction.Controls.Add(this.txtPhone);
            this.gbAction.Controls.Add(this.lbPhone);
            this.gbAction.Controls.Add(this.rdFemale);
            this.gbAction.Controls.Add(this.rbMale);
            this.gbAction.Controls.Add(this.textBox1);
            this.gbAction.Controls.Add(this.txtempName);
            this.gbAction.Location = new System.Drawing.Point(1079, 39);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(577, 578);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(421, 258);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(122, 36);
            this.rdFemale.TabIndex = 3;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(222, 258);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(98, 36);
            this.rbMale.TabIndex = 2;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 39);
            this.textBox1.TabIndex = 1;
            // 
            // txtempName
            // 
            this.txtempName.AutoSize = true;
            this.txtempName.Location = new System.Drawing.Point(17, 171);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(190, 32);
            this.txtempName.TabIndex = 0;
            this.txtempName.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1096, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Action";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(222, 436);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(329, 39);
            this.txtPhone.TabIndex = 5;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(17, 436);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(82, 32);
            this.lbPhone.TabIndex = 4;
            this.lbPhone.Text = "Phone";
            // 
            // txtSalary
            // 
            this.txtSalary.AutoSize = true;
            this.txtSalary.Location = new System.Drawing.Point(17, 350);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(77, 32);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.Text = "Salary";
            // 
            // dudSalary
            // 
            this.dudSalary.Location = new System.Drawing.Point(222, 350);
            this.dudSalary.Name = "dudSalary";
            this.dudSalary.Size = new System.Drawing.Size(240, 39);
            this.dudSalary.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 526);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 46);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(421, 526);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(150, 46);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(222, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 46);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "FrmEmployee";
            this.Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtempName;
        private System.Windows.Forms.DomainUpDown dudSalary;
        private System.Windows.Forms.Label txtSalary;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
    }
}

