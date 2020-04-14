using System;

namespace ResponsiPemrograman2755
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan person = new Karyawan(19112755, 4000000, "Nazil");
            Karyawan person2 = new Karyawan(19110000, 2000000, "Alifurohman");

            Console.WriteLine("No. \t Nik/Nama \t\t Gaji Bulanan ");
            Console.WriteLine("1. \t {0} {1} \t {2}", person.Nik, person.Nama, person.GajiBulanan);
            Console.WriteLine("2. \t {0} {1} \t {2}", person2.Nik, person2.Nama, person2.GajiBulanan);

            Console.WriteLine("");

            Console.WriteLine("Asyiiik kenaikan gaji 10%");

            Console.WriteLine("");

            Console.WriteLine("No. \t Nik/Nama \t\t Gaji Bulanan ");
            Console.WriteLine("1. \t {0} {1} \t {2}", person.Nik, person.Nama, person.UangPlus);
            Console.WriteLine("2. \t {0} {1} \t {2}", person2.Nik, person2.Nama, person2.UangPlus);
        }
    }

    class Karyawan
    {

        public int Nik { get; set; }
        public int GajiBulanan { get; set; }
        public string Nama { get; set; }
        public int UangPlus { get; set; }

        public Karyawan(int Nik, int Gaji, string Nama)
        {

            this.Nik = Nik;
            this.Nama = Nama;

            if (Gaji < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = Gaji;
            }

            double y = 0;
            y = 0.1 * GajiBulanan;
            UangPlus = Convert.ToInt32(y) + GajiBulanan;

        }

    }
}