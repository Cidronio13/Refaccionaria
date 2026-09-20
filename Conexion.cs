using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refaccionaria
{
    internal class Conexion
    {
        public string conexion()
        {
            string path = @"C:\Conexion\Conexion.txt"; //"C:\Conexion\Conexion.txt"
            string conex = "";
            using (StreamReader file = new StreamReader(path))
            {
                conex = @"" + file.ReadToEnd();
                file.Close();
            }
            //string conex = "server = MSI\\SQLEXPRESS; database=REFACCIONRIA ; integrated security = true";
            return conex;
        }
    }
}
