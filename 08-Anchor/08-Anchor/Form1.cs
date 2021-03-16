using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Anchor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Anchor=Top|Left|Right 靠上水平拉伸
        // Anchor=None 水平和垂直居中
        // Anchor=Top|Left 左上角停靠
        // Anchor=Top 水平居中
    }
}
