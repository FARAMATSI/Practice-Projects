using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_Management_System
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiplomaStudent stud = new DiplomaStudent();
            stud.name = txtFirstName.Text;
            stud.surname = txtSurname.Text;
            stud.setStudID(Convert.ToInt32(txtStudentID.Text));
            stud.cellNumber = Convert.ToInt32(txtCellNumber.Text);
            stud.setEmail(txtEmail.Text);
            stud.setAddress(txtAddress.Text);

            StudentDB db = new StudentDB();
            db.addStudent(stud);
            db.printDatabase();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
