namespace _2_KolekcjaGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> pracownicy = new List<Pracownik>
            {
                new Pracownik { Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik { Imie = "Jan", Nazwisko = "Nowak"},
                new Pracownik { Imie = "Tomasz", Nazwisko = "Nowak"},
             };

            pracownicy.Add(new Pracownik { Imie = "Ania", Nazwisko = "Kos" });

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            for (int i = 0; i < pracownicy.Count; i++)
            {
                Console.WriteLine(pracownicy[i].Imie +" "+ pracownicy[i].Nazwisko);
            }

            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jan", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Bartek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });


            while(kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine("usuwamy z kolejki " +pracownik.Imie+" "+pracownik.Nazwisko);
            }

        }
    }
}