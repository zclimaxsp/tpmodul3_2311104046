using System;
using tpmodul3_2311104046;

class Program
{
    enum State { Terkunci, Terbuka }

    class DoorMachine
    {
        private State _state = State.Terkunci;

        public void KunciPintu()
        {
            _state = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            _state = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Pencarian Kode Pos dan Simulasi Pintu ===");

        // Simulasi Pintu
        DoorMachine door = new DoorMachine();
        while (true)
        {
            Console.Write("\nMasukkan perintah (BukaPintu/KunciPintu/exit): ");
            string perintah = Console.ReadLine()?.ToLower();

            if (perintah == "exit")
                break;

            if (perintah == "bukapintu")
                door.BukaPintu();
            else if (perintah == "kuncipintu")
                door.KunciPintu();
            else
                Console.WriteLine("Perintah tidak dikenali.");
        }

        // Pencarian Kode Pos
        while (true)
        {
            Console.Write("\nMasukkan nama kelurahan (atau ketik 'exit' untuk keluar): ");
            string kelurahan = Console.ReadLine();

            if (kelurahan.ToLower() == "exit")
                break;

            string kodePos = KodePos.GetKodePos(kelurahan);
            Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");
        }

        Console.WriteLine("\nProgram selesai.");
    }
}
