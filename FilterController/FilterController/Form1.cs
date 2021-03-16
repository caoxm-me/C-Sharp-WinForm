using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.kurios = null;
        }

        private void On_Test(object sender, EventArgs e)
        {
            //如果设备已连接则释放
            if(this.kurios != null)
            {
                Connection.Connect_Close(this.kurios.Hdl);
                this.kurios.Hdl = -1;
                this.kurios = null;
                this.btn_connect.Text = "Connect";
                this.btn_connect.BackColor = Color.Red;
                return;
            }

            StringBuilder serialInfo = new StringBuilder(100);

            int status = Connection.Find_Serial(serialInfo);

            if(status == -1)
            {
                return;
            }

            this.kurios = Connection.Connect_Serial(serialInfo.ToString().Split(',')[0], 115200, 10);

            
            // 如果连接失败则释放
            if(this.kurios.Hdl < 0)
            {
                this.kurios = null;
                return;
            }
            else
            {
                this.InitializeControls();
                this.btn_connect.Text = "Disconnect";
                this.btn_connect.BackColor = Color.Green;
                //MessageBox.Show(this.kurios.Get_Wavelength().ToString());
                return;
            }

        }

        void InitializeControls()
        {
            int min = this.kurios.Get_Range().Item1;
            int max = this.kurios.Get_Range().Item2;
            this.wavelengthBar.Minimum = min;
            this.lb_MinWavelength.Text = string.Format("{0}nm", min.ToString());
            this.wavelengthBar.Maximum = max;
            this.lb_MaxWavelength.Text = string.Format("{0}nm", max.ToString());
            this.lb_MinWavelength.Visible = true;
            this.lb_MaxWavelength.Visible = true;
        }

        private Device kurios;

        private void On_Change(object sender, EventArgs e)
        {
            if(this.kurios == null)
            {
                MessageBox.Show("Please connect to the device first!");
            }
            else
            {
                this.lb_CurrentWavelength.Text = string.Format("{0}nm", this.wavelengthBar.Value.ToString());
                this.lb_CurrentWavelength.Visible = true;
                Dll.kurios_Set_Wavelength(this.kurios.Hdl, this.wavelengthBar.Value);
            }
        }

        private void On_NarrowMode(object sender, EventArgs e)
        {
            Dll.kurios_Set_BandwidthMode(this.kurios.Hdl, 8);
        }

        private void On_MidiumMode(object sender, EventArgs e)
        {
            Dll.kurios_Set_BandwidthMode(this.kurios.Hdl, 4);
        }

        private void On_WideMode(object sender, EventArgs e)
        {
            Dll.kurios_Set_BandwidthMode(this.kurios.Hdl, 2);
        }

        private void On_BlackMode(object sender, EventArgs e)
        {
            Dll.kurios_Set_BandwidthMode(this.kurios.Hdl, 1);
        }
    }
}
