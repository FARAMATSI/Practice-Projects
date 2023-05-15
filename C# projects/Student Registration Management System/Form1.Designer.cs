namespace Student_Registration_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            managementToolStripMenuItem = new ToolStripMenuItem();
            studentRegistrationToolStripMenuItem = new ToolStripMenuItem();
            recordsToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { managementToolStripMenuItem, recordsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(748, 62);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentRegistrationToolStripMenuItem });
            managementToolStripMenuItem.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(279, 58);
            managementToolStripMenuItem.Text = "Management";
            managementToolStripMenuItem.Click += managementToolStripMenuItem_Click;
            // 
            // studentRegistrationToolStripMenuItem
            // 
            studentRegistrationToolStripMenuItem.Name = "studentRegistrationToolStripMenuItem";
            studentRegistrationToolStripMenuItem.Size = new Size(504, 62);
            studentRegistrationToolStripMenuItem.Text = "Student Registration";
            studentRegistrationToolStripMenuItem.Click += studentRegistrationToolStripMenuItem_Click;
            // 
            // recordsToolStripMenuItem
            // 
            recordsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStudentsToolStripMenuItem });
            recordsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            recordsToolStripMenuItem.Size = new Size(183, 58);
            recordsToolStripMenuItem.Text = "Records";
            // 
            // viewStudentsToolStripMenuItem
            // 
            viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            viewStudentsToolStripMenuItem.Size = new Size(391, 62);
            viewStudentsToolStripMenuItem.Text = "View Students";
            viewStudentsToolStripMenuItem.Click += viewStudentsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(748, 303);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem studentRegistrationToolStripMenuItem;
        private ToolStripMenuItem recordsToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
    }
}