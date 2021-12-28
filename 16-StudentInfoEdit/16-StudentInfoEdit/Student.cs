using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_StudentInfoEdit
{
    public class Student
    {
        public string name { get; set; }
        public string  id { get; set; }
        public bool sex { get; set; }
        public string phone { get; set; }

        public Student(string name, string id, bool sex, string phone)
        {
            this.name = name;
            this.id = id;
            this.sex = sex;
            this.phone = phone;
        }
    }
}
