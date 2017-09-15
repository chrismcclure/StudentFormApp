namespace C03
{
    partial class frmStudentInfo
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.txtIDStudent = new System.Windows.Forms.TextBox();
            this.txtMidTermGrade = new System.Windows.Forms.TextBox();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(239, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(354, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(64, 110);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Location = new System.Drawing.Point(236, 110);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(51, 13);
            this.lblMidTerm.TabIndex = 4;
            this.lblMidTerm.Text = "MidTerm:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(354, 110);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(32, 13);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.Text = "Final:";
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(64, 63);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(325, 20);
            this.txtNameStudent.TabIndex = 0;
            this.txtNameStudent.Tag = "Name";
            // 
            // txtIDStudent
            // 
            this.txtIDStudent.Location = new System.Drawing.Point(64, 127);
            this.txtIDStudent.MaxLength = 6;
            this.txtIDStudent.Name = "txtIDStudent";
            this.txtIDStudent.Size = new System.Drawing.Size(144, 20);
            this.txtIDStudent.TabIndex = 1;
            this.txtIDStudent.Tag = "Student ID";
            // 
            // txtMidTermGrade
            // 
            this.txtMidTermGrade.Location = new System.Drawing.Point(239, 127);
            this.txtMidTermGrade.Name = "txtMidTermGrade";
            this.txtMidTermGrade.Size = new System.Drawing.Size(75, 20);
            this.txtMidTermGrade.TabIndex = 2;
            this.txtMidTermGrade.Tag = "Mid Term Grade";
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.Location = new System.Drawing.Point(354, 127);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.Size = new System.Drawing.Size(75, 20);
            this.txtFinalGrade.TabIndex = 3;
            this.txtFinalGrade.Tag = "Final Grade";
            // 
            // frmStudentInfo
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(515, 297);
            this.ControlBox = false;
            this.Controls.Add(this.txtFinalGrade);
            this.Controls.Add(this.txtMidTermGrade);
            this.Controls.Add(this.txtIDStudent);
            this.Controls.Add(this.txtNameStudent);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblMidTerm);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "frmStudentInfo";
            this.Text = "Enter Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblMidTerm;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.TextBox txtIDStudent;
        private System.Windows.Forms.TextBox txtMidTermGrade;
        private System.Windows.Forms.TextBox txtFinalGrade;
    }
}