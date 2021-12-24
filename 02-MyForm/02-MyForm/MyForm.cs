using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_MyForm
{
	// 自定义窗体类应该继承System.Windows.Forms
    class MyForm : Form
    {
        public MyForm()
        {
        	// 设置窗口标题
            this.Text = "My First Window";
        }
    }
}
