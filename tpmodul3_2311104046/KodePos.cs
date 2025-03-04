using System;
using System.Collections.Generic;


namespace tpmodul3_2311104046
{
    public class KodePos
    {
        // Menggunakan Dictionary untuk teknik Table-Driven
        private static readonly Dictionary<string, string> kodePosMap = new Dictionary<string, string>
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijagra", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

        // Method untuk mendapatkan kode pos berdasarkan nama kelurahan
        public static string GetKodePos(string kelurahan)
        {
            if (kodePosMap.TryGetValue(kelurahan, out string kodePos))
            {
                return kodePos;
            }
            else
            {
                return "Kode Pos tidak ditemukan";
            }
        }
    }
}
