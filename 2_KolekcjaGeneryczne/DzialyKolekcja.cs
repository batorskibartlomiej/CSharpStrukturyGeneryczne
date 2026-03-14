

namespace _2_KolekcjaGeneryczne
{
    public class DzialyKolekcja: SortedDictionary<string, SortedSet<Pracownik>>
    {

        public DzialyKolekcja Add(string nazwaDzialu, Pracownik pracownik)
        {
            if(!ContainsKey(nazwaDzialu))
            {
                Add(nazwaDzialu , new SortedSet<Pracownik>(new PracownikComparer()));
                
            }
            this[nazwaDzialu].Add(pracownik);
            return this;
        }
    }
}
