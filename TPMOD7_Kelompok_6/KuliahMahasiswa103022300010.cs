using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace TPMOD7_Kelompok_6
{
    public class KuliahMahasiswa103022300010
    {
        public class MataKuliah
        {
            public string Kode { get; set; }
            public string Nama { get; set; }
        }

        public class Kuliah
        {
            public List<MataKuliah> MataKuliah { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("tp7_2_12345678.json");
            Kuliah data = JsonSerializer.Deserialize<Kuliah>(json);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in data.MataKuliah)
            {
                Console.WriteLine($"MK {i} {mk.Kode} - {mk.Nama}");
                i++;
            }
        }
    }
}
