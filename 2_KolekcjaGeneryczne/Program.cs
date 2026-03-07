namespace _2_KolekcjaGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista();
            //Kolejka();
            //Stos();
            //HashSet();
            //LinkedList();
            //LinkedList2();
            //Dictionary<string, Pracownik> pracownicy1 = Dictionary();
            //Dictionary2();
            //SortedDictionary();
            //SortedList();

            var set = new SortedSet<int>();
            set.Add(5);
            set.Add(3);
            set.Add(1);
            set.Add(8);


            foreach (int i in set)
            {
                Console.WriteLine(i);
            }

            var set2 = new SortedSet<string>();
            set2.Add("tomek");
            set2.Add("ala");
            set2.Add("iza");
            set2.Add("bartek");

            foreach (string s in set2)
            {
                Console.WriteLine(s);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();

            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(2, "dwa");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            SortedDictionary<string, List<Pracownik>> pracownicy3 = new SortedDictionary<string, List<Pracownik>>();
            pracownicy3.Add("Sprzedaż", new List<Pracownik> { new Pracownik { Imie = "Jan", Nazwisko = "Kowal" },
                                                              new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
                                                              new Pracownik { Imie = "Marcin", Nazwisko = "Bien" } });

            pracownicy3.Add("Informatyka", new List<Pracownik> { new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                                                              new Pracownik { Imie = "Tomek", Nazwisko = "Bien" },
                                                              new Pracownik { Imie = "Marcin", Nazwisko = "Kowal" } });

            pracownicy3.Add("Księgowść", new List<Pracownik> { new Pracownik { Imie = "Alicja", Nazwisko = "Nowak" },
                                                              new Pracownik { Imie = "Ola", Nazwisko = "Bien" },
                                                              new Pracownik { Imie = "Ala", Nazwisko = "Bien" },
                                                              new Pracownik { Imie = "Maja", Nazwisko = "Kowal" } });


            foreach (var item in pracownicy3)
            {
                Console.WriteLine("Ilość pracowników w dziale {0} wynosi {1}", item.Key, item.Value.Count);

            }
        }

        private static void Dictionary2()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Księgowość", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" },
                                                                 new Pracownik { Nazwisko = "Kowal" },
                                                                 new Pracownik { Nazwisko = "Kaczor" } });

            //...

            pracownicy["Księgowość"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Nazwisko = "Kowalski" },
                                                                 new Pracownik { Nazwisko = "Bogacki" },
                                                                 new Pracownik { Nazwisko = "Kaczor" } });


            foreach (var item in pracownicy)
            {
                Console.WriteLine("Dział : " + item.Key);
                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Pracownicy z ksiegowosci");
            foreach (var item in pracownicy["Księgowość"])
            {
                Console.WriteLine(item.Nazwisko);
            }
        }

        private static Dictionary<string, Pracownik> Dictionary()
        {
            var pracownicy = new Dictionary<string, Pracownik>();
            pracownicy.Add("Nowak", new Pracownik { Nazwisko = "Nowak" });
            pracownicy.Add("Nowak", new Pracownik { Nazwisko = "Nowak" });//tu bylby wyjkatek-nie moze byc tych samych kluczy
            pracownicy.Add("Kowal", new Pracownik { Nazwisko = "Kowal" });
            pracownicy.Add("Kaczor", new Pracownik { Nazwisko = "Kaczor" });


            var kowal = pracownicy["Kowal"];//uzywam klucza

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine("{0}:{1}", pracownik.Key, pracownik.Value.Nazwisko);
            }

            return pracownicy;
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var elementPierwszy = lista.First;
            var elementOststani = lista.Last;

            lista.AddAfter(elementPierwszy, 10);
            lista.AddBefore(elementPierwszy, 20);

            var wezel = lista.First;

            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {

                Console.WriteLine(item);
            }
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