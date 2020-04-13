using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiPemrog2314
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kr1 = new Karyawan("190302123", "Paijo", 3000000);
            Karyawan kr2 = new Karyawan("190302124", "Jono", 2000000);

            Console.WriteLine("No    Nik/Nama             Gaji Bulanan");
            Console.WriteLine("1.    {0} {1}           {2}",kr1.Nik,kr1.Nama,kr1.GajiBulanan);
            Console.WriteLine("2.    {0} {1}            {2}", kr2.Nik, kr2.Nama, kr2.GajiBulanan);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Asyiiiiiiikkkk Kenaikan Gaji 10%");
            Console.WriteLine("No    Nik/Nama             Gaji Bulanan");
            Console.WriteLine("1.    {0} {1}           {2}", kr1.Nik, kr1.Nama, (kr1.GajiBulanan)*1.1);
            Console.WriteLine("2.    {0} {1}            {2}", kr2.Nik, kr2.Nama, (kr2.GajiBulanan)*1.1);
            Console.WriteLine("---------------------------------------");

            Console.ReadKey();
        }
    }
}
