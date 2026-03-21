

using _4_metodyDelegatyGeneryczne;
using System.ComponentModel;
using System.Linq;


namespace __4_metodyDelegatyGeneryczne
{
    public static class KolejkaExtensions
    {

        
        public static IEnumerable<Twyjscie> Mapuj<T, Twyjscie>(this IKolejka<T> kolejka, Converter<T, Twyjscie>konwerter)
        {
            return kolejka.Select(i=>konwerter(i));

            //foreach (var item in kolejka)
            //{
            //    Twyjscie wynik = konwerter(item);
            //    yield return wynik;

            //}

        }

        public static void Drukuj<T>(this IKolejka<T> kolejka, Action<T> wydruk)
        {

            foreach (var item in kolejka)
            {
                wydruk(item);
            }

        }


     

    }
}
