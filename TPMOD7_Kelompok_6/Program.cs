using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace TPMOD7_Kelompok_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103022300005.ReadJSON();
            KuliahMahasiswa103022300005.ReadJSON();

            DataMahasiswa103022300010.ReadJSON();
            KuliahMahasiswa103022300010.ReadJSON();
        }
    }
}
