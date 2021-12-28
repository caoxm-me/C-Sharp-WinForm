using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void isPasswdShow_CheckedChanged(object sender, EventArgs e)
        {
            if(isPasswdShow.Checked == true)
            {
                passwdBox.PasswordChar = '\0';
            }
            else
            {
                passwdBox.PasswordChar = '*';
            }
        }
    }
}
