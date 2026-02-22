namespace _2_KolekcjaGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista();
            Kolejka();
            Stos();
            HashSet();

        }

        private static void HashSet()
        {
            Console.WriteLine("Hashset");
            HashSet<Pracownik> set = new HashSet<Pracownik>();
            var pracownik = new Pracownik { Imie = "Jan" };

            set.Add(pracownik);
            set.Add(pracownik);//ale tu juz nie doda bo to jest ten sam obiekt
            set.Add(new Pracownik { Imie = "Marcin" });
            set.Add(new Pracownik { Imie = "Marcin" });//dodaje bo to są dwa różne obiekty- nie patrzy na to ze sa te same imiona


            foreach (var item in set)
            {

                Console.WriteLine(item.Imie);

            }
        }

        private static void Lista()
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
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Jan", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Bartek", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            //LIFO
            Console.WriteLine(" ");
            Console.WriteLine("Stos");

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine("usuwamy ze stosu " + pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            //FIFO
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jan", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Bartek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });


            Console.WriteLine("kolejka");
            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine("usuwamy z kolejki " + pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}