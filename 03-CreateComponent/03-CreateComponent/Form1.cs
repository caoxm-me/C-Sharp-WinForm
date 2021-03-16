using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_CreateComponent
{
    public partial class Form1 : Form
    {
        // 手动创建按钮
        private Button testButton = new Button();
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(testButton);
            testButton.Text = "测试按钮";
            testButton.Location = new Point(40, 40);
            testButton.Size = new Size(100, 40);
        }
    }
}
