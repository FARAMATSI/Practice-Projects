using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Management_System
{
    class StudentDB
    {
        // public static java.util.List<Employee> empDatabase = new ArrayList<>();
        public static List<DiplomaStudent> studDB = new List<DiplomaStudent>();

        public void addStudent(DiplomaStudent student)
        {
            studDB.Add(student);
        }
        public void printDatabase()
        {

            if (studDB.Count > 0)
            {
                for (int i = 0; i < studDB.ToArray().Length; i++)
                {
                    Interaction.MsgBox(studDB[i].ToString());
                }
            }
            else
                    {
                        Interaction.MsgBox("There is nothing to display");
                    }
                
            
        }
    }
}
