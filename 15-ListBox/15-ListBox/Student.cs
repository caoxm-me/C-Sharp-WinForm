using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ListBox
{
    class Student
    {
        public string name { get; set; }
        public string id { get; set; }

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public override string ToString()
        {
            return string.Format("({0}):{1}", this.id, this.name);
        }
    }
}
