﻿namespace loginform_SIS
{
    partial class teacher
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
            panel1 = new Panel();
            lblWelcomeTeacher = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(lblWelcomeTeacher);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 54);
            panel1.TabIndex = 0;
            // 
            // lblWelcomeTeacher
            // 
            lblWelcomeTeacher.AutoSize = true;
            lblWelcomeTeacher.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.Location = new Point(172, 9);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(341, 33);
            lblWelcomeTeacher.TabIndex = 1;
            lblWelcomeTeacher.Text = "Hello! Welcome Teacher!";
            lblWelcomeTeacher.TextAlign = ContentAlignment.TopCenter;
            // 
            // teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 342);
            Controls.Add(panel1);
            Name = "teacher";
            Text = "teacher";
            Load += teacher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblWelcomeTeacher;
    }
}