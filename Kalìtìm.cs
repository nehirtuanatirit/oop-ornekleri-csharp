using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arac arac = new Arac();
            {
                arac.Marka = "Toyota";
                arac.Model = "Corolla";
                arac.Yil = 2020;
            }
            arac.BilgiGoster();
            Console.WriteLine();
             
            Otomobil otomobil = new Otomobil();
            {
                otomobil.Marka = "Volkswagen";
                otomobil.Model = "Beetle";
                otomobil.Yil = 2016;
                otomobil.KapiSayisi = 4;
            }
            otomobil.BilgiGoster();
            otomobil.Kapi();
            Console.WriteLine();

            Kamyon kamyon = new Kamyon();
            {
                kamyon.Marka = "Mercedes";
                kamyon.Model = "Actros";
                kamyon.Yil = 2018;
                kamyon.YukKapasitesi = 20000;
            }
            kamyon.BilgiGoster();
            kamyon.Yuk();

            Console.ReadKey();
        }
    }
    class Arac
    {
        public string Marka;
        public string Model;
        public int Yil;

        public void BilgiGoster()
        {
            Console.WriteLine($"marka: {Marka}, Model: {Model}, Yıl: {Yil}");
        }
    }
    class Otomobil : Arac
    {
        public int KapiSayisi;

        public void Kapi()
        {
            Console.WriteLine($"Kapı sayısı: {KapiSayisi}");
        }
    }
    class Kamyon : Arac
    {
        public int YukKapasitesi;

        public void Yuk()
        {
            Console.WriteLine($"Yük kapasitesi: {YukKapasitesi}");
        }
    }
}
