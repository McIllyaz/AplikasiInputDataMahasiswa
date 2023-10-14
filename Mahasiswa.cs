using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiInputDataMahasiswa
{
    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Kelas { get; set; }
        public int Nilai { get; set; }

        public string GetNilaiHuruf()
        {
            int nilai = this.Nilai;
            if (nilai >= 0 && nilai <= 20)
            {
                return "E";
            }
            else if (nilai >= 21 && nilai <= 40)
            {
                return "D";
            }
            else if (nilai >= 41 && nilai <= 60)
            {
                return "C";
            }
            else if (nilai >= 61 && nilai <= 80)
            {
                return "B";
            }
            else if (nilai >= 81 && nilai <= 100)
            {
                return "A";
            }
            else
            {
                return "Nilai tidak valid";
            }
        }
    }




}
