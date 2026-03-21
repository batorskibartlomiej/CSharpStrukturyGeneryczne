

using __4_metodyDelegatyGeneryczne;
using System.Threading.Channels;
using static __4_metodyDelegatyGeneryczne.KolejkaExtensions;

namespace _4_metodyDelegatyGeneryczne
{
     class Program
    {

        
        static void Main(string[] args)
        {
            

            

            Action<double> drukuj = x => Console.WriteLine(x);
            Action<bool> drukujBool = x => Console.WriteLine(x);
            Action<int, int, int> test = (a, b, c) => Console.WriteLine(a + b + c);
            Func<double, double> potegowanie = d => d * d;
            Func<double, double, double> dodaj = (x,y) => x + y;
            Predicate<double> jestMniejszeOdSto = d => d < 100;

            drukujBool( jestMniejszeOdSto( potegowanie(dodaj(6,8))));

            var kolejka = new KolejkaKolowa<double>(pojemnosc:3);
            kolejka.elementUsuniety += Kolejka_elementUsuniety;

            WprowadzanieDanych(kolejka);

            Converter<double, DateTime> konwerter = d => new DateTime(2018,1,1).AddDays(d);
            var jakoData = kolejka.Mapuj(konwerter);
            foreach (var item in jakoData)
            {
                Console.WriteLine(item);
            }

            

            kolejka.Drukuj(d => Console.WriteLine(d));


           

            PrzetwarzanieDanych(kolejka);
        }

        private static void Kolejka_elementUsuniety(object? sender, ElementUsunietyEventArgs<double> e)
        {
            Console.WriteLine("Kolejka jest pełna. Element usuniety to : {0} Nowy element to {1}", e.ElementUsuniety, e.ElemntNowy);
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