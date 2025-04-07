using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa12345678
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
        public string Fakultas { get; set; }
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("tp7_1_12345678.json");
        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(json);
        Console.WriteLine($"Nama {mhs.Nama} dengan nim {mhs.Nim} dari fakultas {mhs.Fakultas}");
    }
}
