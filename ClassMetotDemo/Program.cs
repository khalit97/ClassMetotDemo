using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Özkul";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Kaba";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Abuzer";
            musteri3.Soyadi = "Abalı";
            musteri3.Id = 3;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Hasan";
            musteri4.Soyadi = "Ali";
            musteri4.Id = 4;

            Musteri musteri5 = new Musteri();
            musteri5.Adi = "Cevahir";
            musteri5.Soyadi = "Ulu";
            musteri5.Id = 5;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4, musteri5 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " :"+ musteri.Id);
            }

            Console.WriteLine("-------------------------------------");


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add();
            musteriManager.Delete();



        }
    }
}
