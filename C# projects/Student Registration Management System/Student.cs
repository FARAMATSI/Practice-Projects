using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Management_System
{
    public  class Student
    {
        public string name;
        public string surname;
        private int studID;
        public int cellNumber;
        private string email;
        private string resAddress;
        public int guardianCellNumber;
        public void setGuardianCellNumber(int gdcellNumber)
        {
            this.guardianCellNumber = gdcellNumber;
        }
        public int getGuardianCellNumber()
        {
            return this.guardianCellNumber;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail() { 

           return this.email;
        }
        public void setStudID(int studID)
        {
            this.studID = studID;
        }
        public int getStudID()
        {
            return this.studID;
        }
        public string getResAddress() {
            return this.resAddress;
        }
        public void setAddress(string resAddress)
        {
            this.resAddress = resAddress;
        }
        public override string ToString()
        {
            return "Name: " + this.name + ", " +
                "Surname: " + this.surname + ", " +
                "ID: " + this.studID + ", " +
                "cellNumber: " + this.cellNumber + ", " +
                "Email: " + this.email + ", " +
                "Res Address: " + this.resAddress + ", " +
                "GuardianCellNumber: " + this.guardianCellNumber + "\n";
        }
    }
}
