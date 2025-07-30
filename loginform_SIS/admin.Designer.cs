namespace loginform_SIS
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            panel1 = new Panel();
            label1 = new Label();
            lblWelcomeAdmin = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pbAdmin = new PictureBox();
            button7 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 34);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(162, 14);
            label1.TabIndex = 5;
            label1.Text = "Student Information System";
            // 
            // lblWelcomeAdmin
            // 
            lblWelcomeAdmin.AutoSize = true;
            lblWelcomeAdmin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeAdmin.Location = new Point(4, 78);
            lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            lblWelcomeAdmin.Size = new Size(103, 15);
            lblWelcomeAdmin.TabIndex = 0;
            lblWelcomeAdmin.Text = "Welcome Admin!";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(4, 285);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 1;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(4, 129);
            button2.Name = "button2";
            button2.Size = new Size(88, 35);
            button2.TabIndex = 2;
            button2.Text = "Student";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(4, 161);
            button3.Name = "button3";
            button3.Size = new Size(88, 35);
            button3.TabIndex = 3;
            button3.Text = "Teacher";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(4, 193);
            button4.Name = "button4";
            button4.Size = new Size(88, 35);
            button4.TabIndex = 4;
            button4.Text = "Subject";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(4, 225);
            button5.Name = "button5";
            button5.Size = new Size(88, 35);
            button5.TabIndex = 5;
            button5.Text = "Logs";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(4, 257);
            button6.Name = "button6";
            button6.Size = new Size(88, 35);
            button6.TabIndex = 6;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = false;
            // 
            // pbAdmin
            // 
            pbAdmin.Image = (Image)resources.GetObject("pbAdmin.Image");
            pbAdmin.Location = new Point(21, 33);
            pbAdmin.Name = "pbAdmin";
            pbAdmin.Size = new Size(61, 42);
            pbAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdmin.TabIndex = 7;
            pbAdmin.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(4, 96);
            button7.Name = "button7";
            button7.Size = new Size(88, 35);
            button7.TabIndex = 8;
            button7.Text = "Dashboard";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Location = new Point(-6, 326);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 30);
            panel2.TabIndex = 9;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 342);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(pbAdmin);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(lblWelcomeAdmin);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblWelcomeAdmin;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
        private PictureBox pbAdmin;
        private Button button7;
        private Panel panel2;
    }
}