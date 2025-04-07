using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022330122
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
        string json = File.ReadAllText("tp7_1_103022330122.json");
        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(json);
        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");

    }
}