using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            itemList.Items.Add("dmiao");
            itemList.Items.Add("emiao");
            itemList.Items.Add("fmiao");
            itemList.SelectedItem = itemList.Items[0];
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            object itemSelected = itemList.SelectedItem;
            if(itemSelected != null)
            {
                MessageBox.Show(itemList.SelectedItem.ToString());
            }
            
        }

        private void itemList_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(itemList.SelectedItem.ToString());
        }
    }
}
