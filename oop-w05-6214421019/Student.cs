using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w05
{
    class Student
    {
        private string studentId;
        private string studentFirstname;
        private string studentLastname;
        private string[] studentID = { "6214421017", "6214421021", "6214421018", "6214421007" };
        private string[] studentfName = { "Rungrat ", "Anocha", "Rene ", "Phongpanot" };
        private string[] studentlName = { "Sriwirun", "Prungtaeng", "Schmitt", "Thongngam" };
        private int code;
        private Curriculumn curri;
        public Student() { }
        public Student(int n,Curriculumn c) { this.code = n; this.curri = c; }
        public Student(string i,string f,string l) { this.studentId = i;this.studentFirstname = f;this.studentLastname = l; }
    
        public string parameter(Curriculumn c)
        {
            return c.degree_name();
        }
       
       
        public override string ToString()
        {
            return "StudentID: " + this.studentID[this.code] + " StudentName: " + this.studentfName[this.code] + this.studentlName[this.code] + parameter(this.curri);
        }


    }
}
