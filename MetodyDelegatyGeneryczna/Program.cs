

using __4_metodyDelegatyGeneryczne;
using static __4_metodyDelegatyGeneryczne.KolejkaExtensions;

namespace _4_metodyDelegatyGeneryczne
{
     class Program
    {

        static void KonsolaWypisz(double dane)
        {
            Console.WriteLine(dane);

        }
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>();

            WprowadzanieDanych(kolejka);

            //var konsolaWyjscie = new Drukarka<double>(KonsolaWypisz);

            //kolejka.Drukuj(konsolaWyjscie);

            kolejka.Drukuj(KonsolaWypisz);


            //var elementyJakoInt = kolejka.ElementJako<double, int>();


            //foreach (var item in elementyJakoInt)
            //{
            //    Console.WriteLine(item);

            //}

            PrzetwarzanieDanych(kolejka);
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;

            Console.WriteLine("W naszej kolejce jest :");

            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();

            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;

            }
        }
    }

   

}