using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_StudentInfoEdit
{
    public partial class Form1 : Form
    {
        public void LoadFromFile(string fileName)
        {
            string content = JsonFileTools.Read(fileName);
            Student stu = JsonToStudentInfo(content);
            this.nameBox.Text = stu.name;
            
            this.idBox.Text = stu.id;
            this.phoneBox.Text = stu.phone;
            this.sexComboBox.SelectedIndex = stu.sex ? 0 : 1;
            
        }

        public Form1()
        {
            InitializeComponent();
            LoadFromFile(".\\student.json");
            
        }

        public string StudentInfoToJson(Student stu)
        {
            return JsonConvert.SerializeObject(stu);
        }

        public Student JsonToStudentInfo(string jsonStr)
        {
            return JsonConvert.DeserializeObject<Student>(jsonStr);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string id = idBox.Text;
            string phone = phoneBox.Text;
            bool sex = true;
            if(sexComboBox.SelectedItem.ToString() == "女")
            {
                sex = false;
            }
            Student stu = new Student(name, id, sex, phone);
            JsonFileTools.Write(".\\student.json", StudentInfoToJson(stu));
        }
    }
}
