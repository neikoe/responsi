using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiPemrograman2611
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            if (gajibulanan > 0)
            {
                GajiBulanan = gajibulanan;
            }
            else
            {
                gajibulanan = 0;
            }
        }
    }
}
