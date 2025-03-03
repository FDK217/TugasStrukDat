int pilihan;
Console.Write("Masukkan angka: ");
pilihan = Convert.ToInt32(Console.ReadLine());

if (pilihan > 1)
{
    Console.WriteLine("Angka anda lebih besar dari 1");
}
else if (pilihan == 1)
{
    Console.WriteLine("Angka anda adalah 1");
}
else
{
    Console.WriteLine("Angka anda lebih kecil dari 1");
}