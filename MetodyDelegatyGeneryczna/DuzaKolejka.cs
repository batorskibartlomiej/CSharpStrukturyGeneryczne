using System.Collections;
using System.ComponentModel;

namespace _4_metodyDelegatyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {

        protected Queue<T> kolejka;

        public DuzaKolejka()
        {
            kolejka = new Queue<T>();
        }


        public virtual bool JestPelny => throw new NotImplementedException();

        public virtual bool JestPusty
        {
            get
            {
                return kolejka.Count == 0;
            }
        }

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

       

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }

        public IEnumerator<T> GetEnumerator()
        {

            foreach (var item in kolejka)
            {
                //filtrowanie

                yield return item;
            }
            //return kolejka.GetEnumerator();
        }
        


        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();

            
        }

        //public IEnumerable<Twyjscie> ElementJako<Twyjscie>()
        //{
        //    var konwerter = TypeDescriptor.GetConverter(typeof(T));

        //    foreach (var item in kolejka)
        //    {
        //        Twyjscie wynik = (Twyjscie)konwerter.ConvertTo(item, typeof(Twyjscie));
        //        yield return wynik;

        //    }
            
        //}
    }
}