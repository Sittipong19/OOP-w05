using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w05
{
    class Curriculumn
    {
        private string curriculumnName;
        private string curriculumnDegree;
        public Curriculumn() { }
        public Curriculumn(string cn,string cd)
        {
            this.curriculumnName = cn;
            this.curriculumnDegree = cd;
        }
    
        public string degree_name()
        {
            return "MajorName: "+this.curriculumnName +" Degree Name: "+ this.curriculumnDegree;
        }
    }
}
