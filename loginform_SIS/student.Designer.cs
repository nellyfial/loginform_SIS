namespace loginform_SIS
{
    partial class student
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
            lblWelcomeStudent = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcomeStudent
            // 
            lblWelcomeStudent.AutoSize = true;
            lblWelcomeStudent.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeStudent.Location = new Point(169, 11);
            lblWelcomeStudent.Name = "lblWelcomeStudent";
            lblWelcomeStudent.Size = new Size(337, 33);
            lblWelcomeStudent.TabIndex = 0;
            lblWelcomeStudent.Text = "Hello! Welcome Student!";
            lblWelcomeStudent.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(lblWelcomeStudent);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 54);
            panel1.TabIndex = 1;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 342);
            Controls.Add(panel1);
            Name = "student";
            Text = "student";
            Load += student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcomeStudent;
        private Panel panel1;
    }
}