using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_ManualEventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 给事件绑定委托
            this.btn_test.Click += new EventHandler(this.OnTest);
        }

        public void OnTest(Object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        
    }
}
