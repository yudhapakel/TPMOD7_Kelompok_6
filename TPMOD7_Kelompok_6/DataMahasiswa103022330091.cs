using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPMOD7_Kelompok_6
{
    class DataMahasiswa103022330091
    {
        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }
        }

        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("tp7_1_103022330091.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(json);
            Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        }
    }
}
