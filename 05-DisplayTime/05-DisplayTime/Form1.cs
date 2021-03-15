using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_DisplayTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayTime(object sender, EventArgs e)
        {
            this.textTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
