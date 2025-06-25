using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çok_biçimcilik
{
    internal class Program
    {
        public class Calisan
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public double Maas {  get; set; }

            public virtual void BilgileriYazdir()
            {
                Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Maas: {Maas}Tl");
            }
        }
        public class Yonetici : Calisan
        {
            public double Prim { get; set; }

            public override void BilgileriYazdir()
            {
                Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Maas: {Maas}TL, Prim: {Prim}TL, Toplam: {Maas + Prim}TL");
            }
        }
        public class Iscı : Calisan
        {
            public override void BilgileriYazdir()
            {
                Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Maas: {Maas}TL");
            }
        }
        static void Main(string[] args)
        {
            var calisan = new Calisan()
            {
                Ad = "Nehir",
                Soyad = "Tirit",
                Maas = 40000
            };
            calisan.BilgileriYazdir();
            Console.WriteLine();

            var yonetici = new Yonetici()
            {
                Ad = "Bora",
                Soyad = "Tastutar",
                Maas = 50000,
                Prim = 10000
            };
            yonetici.BilgileriYazdir();
            Console.WriteLine();

            var ıscı = new Iscı()
            {
                Ad = "Tuana",
                Soyad = "Yılmaz",
                Maas = 22104
            };
            ıscı.BilgileriYazdir();

            Console.ReadKey();
        }
    }
}
