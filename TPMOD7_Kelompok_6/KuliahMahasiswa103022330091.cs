using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TPMOD7_Kelompok_6
{
    class KuliahMahasiswa103022330091
    {
        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Courses
        {
            public List<MataKuliah> courses { get; set; }
        }

        public static void readJSON() {
            try
            {
                string json = File.ReadAllText("tp7_2_103022330091.json");

                Courses courses = JsonSerializer.Deserialize<Courses>(json);

                for (int i = 0; i < courses.courses.Count(); i++)
                {
                    Console.WriteLine($"MK {i + 1} {courses.courses.ElementAt(i).code} - {courses.courses.ElementAt(i).name}");
                }
            } catch (Exception e)
            {
                Console.WriteLine($"Terjadi error: {e}");
            }
        }
    }
}
