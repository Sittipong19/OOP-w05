using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421019-w05
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private string subjectUnit;
        private string subjectLecuture;
        private string subjectLab;
       
        public Subject() { }
        public Subject(string sc,string sn,string su,string sle,string slb)
        {
            this.subjectCode = sc;
            this.subjectName = sn;
            this.subjectUnit = su;
            this.subjectLecuture = sle;
            this.subjectLab = slb;

        }
    }
}
