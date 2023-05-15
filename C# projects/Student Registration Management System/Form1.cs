namespace Student_Registration_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.Show();
            this.Hide();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDB db = new StudentDB();
            db.printDatabase();
        }
    }
}