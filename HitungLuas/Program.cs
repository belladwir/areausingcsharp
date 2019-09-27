using System;

namespace HitungLuas
{
    class Persegi
    {
        //variable
        public double s;

        public double RumusPersegi()
        {
            Console.WriteLine("Berapa panjang sisi yang diinginkan?");
            s = Convert.ToDouble(Console.ReadLine());
            return s * s;
        }

        public void HasilPersegi()
        {
            Console.WriteLine("Jadi luas persegi adalah {0}", RumusPersegi());
        }
    }

    class PersegiPanjang
    {
        //variable
        public double p;
        public double l;

        public double RumusPersegiPanjang()
        {
            Console.WriteLine("Berapa panjang luas persegi panjang yang di hitung?");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Berapa lebar luas persegi panjang yang ingin di hitung?");
            l = Convert.ToDouble(Console.ReadLine());
            return p * l;
        }

        public void HasilPersegiPanjang()
        {
            Console.WriteLine("Jadi luas persegi panjang adalah {0}", RumusPersegiPanjang());
        }
    }

    class Lingkaran
    {
        //variable
        public double phi = 3.14;
        public double r;

        public double RumusLingkaran()
        {
            Console.WriteLine("Berapa jari-jari lingkarang yg ingin di hitung?");
            r = Convert.ToDouble(Console.ReadLine());
            return phi * r * r;
        }

        public void HasilLingkaran()
        {
            Console.WriteLine("Jadi luas persegi panjang adalah {0}", RumusLingkaran());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int pilihan;
            Console.WriteLine("Hi, luas bangun apa yang ingin anda hitung?\n" +
                "1. Luas Persegi\n" +
                "2. Luas Persegi Panjang\n" +
                "3. Luas Lingkaran\n" +
                "Jawab dengan angka!");
            pilihan = Convert.ToInt16(Console.ReadLine());

            if (pilihan == 1)
            {
                Persegi p = new Persegi();
                p.HasilPersegi();
                Console.WriteLine("Terimakasih sudah mencoba programnya.");
                Console.ReadKey();
            }
            else if (pilihan == 2)
            {
                PersegiPanjang pp = new PersegiPanjang();
                pp.HasilPersegiPanjang();
                Console.WriteLine("Terimakasih sudah mencoba programnya");
                Console.ReadKey();
            }
            else if (pilihan == 3)
            {
                Lingkaran l = new Lingkaran();
                l.HasilLingkaran();
                Console.WriteLine("Terimakasih sudah mencoba programnya");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Maaf, nomor "+ pilihan +" tidak ada penghitungan luasnya.");
                Console.ReadKey();
            }
        }
    }
}
