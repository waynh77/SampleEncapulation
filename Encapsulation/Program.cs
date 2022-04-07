
using Encapsulation;

Encapsul data = new();

data.nama = "Wahyu";
data.alamat = "Jakarta";
data.SetUmur(17);
Console.WriteLine("Nama = "+data.nama);
Console.WriteLine("Alamat = "+data.alamat);
Console.WriteLine("Umur = "+data.GetUmur());
Console.ReadKey();
