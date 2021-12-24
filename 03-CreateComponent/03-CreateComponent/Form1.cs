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
            // 添加按钮控件
            this.Controls.Add(testButton);
            // 设置按钮标题
            testButton.Text = "测试按钮";
            // 设置按钮左上角坐标
            testButton.Location = new Point(40, 40);
            // 设置按钮尺寸
            testButton.Size = new Size(100, 40);
        }
    }
}
