namespace Student_Registration_Management_System
{
    partial class RegisterStudent
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudent));
            btnBack = new Button();
            btnAdd = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            addStudentGroupbox = new GroupBox();
            txtAddress = new RichTextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            txtCellNumber = new TextBox();
            txtStudentID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            txtSurname = new TextBox();
            addStudentGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(264, 441);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(47, 441);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // addStudentGroupbox
            // 
            addStudentGroupbox.Controls.Add(txtAddress);
            addStudentGroupbox.Controls.Add(lblAddress);
            addStudentGroupbox.Controls.Add(txtEmail);
            addStudentGroupbox.Controls.Add(btnBack);
            addStudentGroupbox.Controls.Add(btnAdd);
            addStudentGroupbox.Controls.Add(txtCellNumber);
            addStudentGroupbox.Controls.Add(txtStudentID);
            addStudentGroupbox.Controls.Add(label4);
            addStudentGroupbox.Controls.Add(label3);
            addStudentGroupbox.Controls.Add(label1);
            addStudentGroupbox.Controls.Add(label2);
            addStudentGroupbox.Controls.Add(lblFirstName);
            addStudentGroupbox.Controls.Add(txtFirstName);
            addStudentGroupbox.Controls.Add(txtSurname);
            addStudentGroupbox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addStudentGroupbox.Location = new Point(3, 1);
            addStudentGroupbox.Name = "addStudentGroupbox";
            addStudentGroupbox.Size = new Size(437, 479);
            addStudentGroupbox.TabIndex = 13;
            addStudentGroupbox.TabStop = false;
            addStudentGroupbox.Text = "Add Student";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(226, 355);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 71);
            txtAddress.TabIndex = 23;
            txtAddress.Text = "";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(80, 383);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 22;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(226, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 21;
            // 
            // txtCellNumber
            // 
            txtCellNumber.Location = new Point(226, 190);
            txtCellNumber.Name = "txtCellNumber";
            txtCellNumber.Size = new Size(150, 31);
            txtCellNumber.TabIndex = 20;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(226, 136);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(150, 31);
            txtStudentID.TabIndex = 19;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 142);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 18;
            label4.Text = "Student ID ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 196);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 17;
            label3.Text = "Cell number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 303);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 16;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 88);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 15;
            label2.Text = "Surname";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(58, 35);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(102, 25);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(226, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 13;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(226, 82);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(150, 31);
            txtSurname.TabIndex = 12;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(776, 479);
            Controls.Add(addStudentGroupbox);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            addStudentGroupbox.ResumeLayout(false);
            addStudentGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBack;
        private Button btnAdd;
        private ImageList imageList1;
        private ImageList imageList2;
        private GroupBox addStudentGroupbox;
        private RichTextBox txtAddress;
        private Label lblAddress;
        private TextBox txtEmail;
        private TextBox txtCellNumber;
        private TextBox txtStudentID;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtSurname;
    }
}