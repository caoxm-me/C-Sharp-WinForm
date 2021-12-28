using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_StudentInfoEdit
{
    public class JsonFileTools
    {
        public static void Write(string fileName, string content)
        {
            using (StreamWriter file = new StreamWriter(fileName))
            {
                file.Write(content);
            }
                
        }

        public static string Read(string fileName)
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                return file.ReadToEnd();
            }
        }
    }
}
