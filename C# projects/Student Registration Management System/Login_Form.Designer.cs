namespace Student_Registration_Management_System
{
    partial class Login_Form
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button2 = new Button();
            button1 = new Button();
            lblLinkLabel = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblLinkLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 295);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(169, 25);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 34);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(169, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 34);
            txtPassword.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(207, 236);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(11, 236);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblLinkLabel
            // 
            lblLinkLabel.AutoSize = true;
            lblLinkLabel.Location = new Point(169, 181);
            lblLinkLabel.Name = "lblLinkLabel";
            lblLinkLabel.Size = new Size(153, 28);
            lblLinkLabel.TabIndex = 8;
            lblLinkLabel.TabStop = true;
            lblLinkLabel.Text = "Click to signup ";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 291);
            Controls.Add(groupBox1);
            Name = "Login_Form";
            Text = "Login_Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel lblLinkLabel;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button2;
        private Button button1;
    }
}