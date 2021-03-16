using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterController
{
    class Connection
    {
        public static int Find_Serial(StringBuilder serialInfo)
        {
            int status = Dll.common_List(serialInfo);
            return status;
        }

        public static Device Connect_Serial(string serialNo, int baud, int timeout)
        {
            int hdl = Dll.common_Open(serialNo, baud, timeout);
            return new Device(hdl);
        }

        public static int Connect_Close(int hdl)
        {
            int status = Dll.common_Close(hdl);
            return status;
        }
    }
}
