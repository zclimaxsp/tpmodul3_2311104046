using System;
using tpmodul3_2311104046;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pencarian Kode Pos ===");

        while (true)
        {
            Console.Write("Masukkan nama kelurahan (atau ketik 'exit' untuk keluar): ");
            string kelurahan = Console.ReadLine();

            if (kelurahan.ToLower() == "exit")
            {
                break;
            }

            string kodePos = KodePos.GetKodePos(kelurahan);
            Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}\n");
        }

        Console.WriteLine("Program selesai.");
    }
}
