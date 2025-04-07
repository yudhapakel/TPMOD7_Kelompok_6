﻿using System;
using System.IO;
using System.Text.Json;

namespace TPMOD7_Kelompok_6
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class DataMahasiswa103022300005
    {
        public static void ReadJSON()
        {
            string filePath = "tp7_1_103022300005.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi error: {ex.Message}");
            }
        }
    }
}
