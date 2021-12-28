using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            studentList.Items.Add(new Student("amiao", "001"));
            studentList.Items.Add(new Student("bmiao", "002"));
            studentList.Items.Add(new Student("cmiao", "003"));
            studentList.Items.Add(new Student("dmiao", "004"));
            studentList.Items.Add(new Student("emiao", "005"));
            studentList.Items.Add(new Student("fmiao", "006"));

            studentList.SelectionMode = SelectionMode.MultiSimple;
        }

        private void studentList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach(object selectedItem in studentList.SelectedItems)
            {
                MessageBox.Show(selectedItem.ToString());
            }
        }
    }
}
