namespace loginform_SIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher));
            panel1 = new Panel();
            label1 = new Label();
            lblWelcomeTeacher = new Label();
            pbTeacher = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTeacher).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 30);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 14);
            label1.TabIndex = 2;
            label1.Text = "Student Information System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblWelcomeTeacher
            // 
            lblWelcomeTeacher.AutoSize = true;
            lblWelcomeTeacher.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.Location = new Point(7, 89);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(113, 15);
            lblWelcomeTeacher.TabIndex = 1;
            lblWelcomeTeacher.Text = "Welcome Teacher!";
            lblWelcomeTeacher.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbTeacher
            // 
            pbTeacher.Image = (Image)resources.GetObject("pbTeacher.Image");
            pbTeacher.Location = new Point(29, 36);
            pbTeacher.Name = "pbTeacher";
            pbTeacher.Size = new Size(57, 50);
            pbTeacher.SizeMode = PictureBoxSizeMode.Zoom;
            pbTeacher.TabIndex = 2;
            pbTeacher.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(7, 280);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 3;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Location = new Point(-10, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 20);
            panel2.TabIndex = 4;
            // 
            // teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 342);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(pbTeacher);
            Controls.Add(lblWelcomeTeacher);
            Controls.Add(panel1);
            Name = "teacher";
            Text = "teacher";
            Load += teacher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblWelcomeTeacher;
        private Label label1;
        private PictureBox pbTeacher;
        private Button button1;
        private Panel panel2;
    }
}