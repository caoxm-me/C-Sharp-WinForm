using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterController
{
    class Device
    {
        private int hdl;

        public int Hdl
        {
            get { return this.hdl; }
            set { this.hdl = value; }
        }

        public Device(int hdl)
        {
            this.hdl = hdl;
        }

        public int Set_Wavelength(int wavelength)
        {
            int status = Dll.kurios_Set_Wavelength(this.hdl, wavelength);
            return status;
        }

        public Tuple<int, int> Get_Range()
        {
            Dll.kurios_Get_Specification(this.Hdl, out int max, out int min);
            return new Tuple<int, int> (min, max);
        }

        public int Get_Wavelength()
        {
            int wavelength;
            int status = Dll.kurios_Get_Wavelength(this.hdl, out wavelength);
            if(status < 0)
            {
                wavelength = -1;
            }
            return wavelength;
        }
    }
}
