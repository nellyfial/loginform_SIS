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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            lblWelcomeStudent = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pbStudent = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStudent).BeginInit();
            SuspendLayout();
            // 
            // lblWelcomeStudent
            // 
            lblWelcomeStudent.AutoSize = true;
            lblWelcomeStudent.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeStudent.Location = new Point(12, 91);
            lblWelcomeStudent.Name = "lblWelcomeStudent";
            lblWelcomeStudent.Size = new Size(111, 15);
            lblWelcomeStudent.TabIndex = 0;
            lblWelcomeStudent.Text = "Welcome Student!";
            lblWelcomeStudent.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 34);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(162, 14);
            label1.TabIndex = 2;
            label1.Text = "Student Information System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbStudent
            // 
            pbStudent.Image = (Image)resources.GetObject("pbStudent.Image");
            pbStudent.Location = new Point(34, 38);
            pbStudent.Name = "pbStudent";
            pbStudent.Size = new Size(59, 50);
            pbStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pbStudent.TabIndex = 2;
            pbStudent.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 283);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 3;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Location = new Point(-6, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(711, 30);
            panel2.TabIndex = 4;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 342);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(pbStudent);
            Controls.Add(lblWelcomeStudent);
            Controls.Add(panel1);
            Name = "student";
            Text = "student";
            Load += student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeStudent;
        private Panel panel1;
        private Label label1;
        private PictureBox pbStudent;
        private Button button1;
        private Panel panel2;
    }
}