using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w05
{
    class Lecturer
    {
        private string lecturerFirstname;
        private string lecturerLastname;
        private string lecturerPosition;
        public Lecturer() { }
        public Lecturer(string lf,string ln,string lp)
        {
            this.lecturerFirstname = lf;
            this.lecturerLastname = ln;
            this.lecturerPosition = lp;
        }
    }
}
