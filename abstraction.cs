using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Program
    {
        abstract class Kargo
        {
            public abstract int KilometreBasiUcret { get; }
            public abstract string KargoSuresi();

            public int KargoUcretiHesapla(int kargoSuresi)
            {
                return KilometreBasiUcret * kargoSuresi;
            }
        }

        class HizliKargo : Kargo
        {
            public override int KilometreBasiUcret => 5;
            public override string KargoSuresi()
            {
                return "Teslim süresi: 1-2 iş günü";
            }
        }

        class StandartKargo : Kargo
        {
            public override int KilometreBasiUcret => 2;
            public override string KargoSuresi()
            {
                return "Teslim süresi: 3-5 iş günü";
            }
        }

        class EkonomikKargo : Kargo
        {
            public override int KilometreBasiUcret => 1;
            public override string KargoSuresi()
            {
                return "Teslim süresi: 5-10 iş günü";
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Kargo türü seçiniz (1: Hızlı kargo, 2: Standart kargo, 3: Ekonomik kargo): ");
            int secim = int.Parse(Console.ReadLine());
            Console.Write("Mesafeyi giriniz(Km): ");
            int mesafe = int.Parse(Console.ReadLine());

            Kargo kargo;
            if (secim == 1) kargo = new HizliKargo();
            else if (secim == 2) kargo = new StandartKargo();
            else kargo = new EkonomikKargo();
            Console.WriteLine($"Kargo ücreti: {kargo.KargoUcretiHesapla(mesafe)}TL");
            Console.WriteLine($"Kargo teslim süresi: {kargo.KargoSuresi()}");

            Console.ReadKey();
        }
    }
}
