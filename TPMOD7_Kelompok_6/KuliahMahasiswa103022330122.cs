using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace TPMOD7_Kelompok_6
{
    public class KuliahMahasiswa103022330122
    {
        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Kuliah
        {
            public List<MataKuliah> course { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("tp7_2_103022330122.json");
            Kuliah data = JsonSerializer.Deserialize<Kuliah>(json);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var mk in data.course)
            {
                Console.WriteLine($"MK {i} {mk.code} - {mk.name}");
                i++;
            }
        }
    }
}