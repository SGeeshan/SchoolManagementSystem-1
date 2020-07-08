namespace SchoolMS
{
    partial class Nav
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
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnStudentsDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(48, 45);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(114, 48);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student Registration";
            this.btnStudent.UseVisualStyleBackColor = true;
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(216, 45);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(114, 48);
            this.btnTeacher.TabIndex = 1;
            this.btnTeacher.Text = "Teacher Registration";
            this.btnTeacher.UseVisualStyleBackColor = true;
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(381, 45);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(114, 48);
            this.btnMarks.TabIndex = 2;
            this.btnMarks.Text = "Marks Enter";
            this.btnMarks.UseVisualStyleBackColor = true;
            // 
            // btnStudentsDetails
            // 
            this.btnStudentsDetails.Location = new System.Drawing.Point(554, 45);
            this.btnStudentsDetails.Name = "btnStudentsDetails";
            this.btnStudentsDetails.Size = new System.Drawing.Size(114, 48);
            this.btnStudentsDetails.TabIndex = 3;
            this.btnStudentsDetails.Text = "Students Details";
            this.btnStudentsDetails.UseVisualStyleBackColor = true;
            // 
            // Nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStudentsDetails);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnStudent);
            this.Name = "Nav";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnStudentsDetails;
    }
}