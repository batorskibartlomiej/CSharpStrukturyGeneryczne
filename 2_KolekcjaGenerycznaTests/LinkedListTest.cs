namespace _2_KolekcjaGenerycznaTests
{
    [TestClass]
    public sealed class LinkedListTest
    {
        [TestMethod]
        public void DodawaniePoElemencie()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddAfter(lista.First, "Ola Środek");

            Assert.AreEqual("Ola Środek", lista.First.Next.Value);

        }

        [TestMethod]
        public void DodawaniePrzedElementem()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddBefore(lista.First, "Ola Środek");

            Assert.AreEqual("Ola Środek", lista.First.Value);

        }

        [TestMethod]
        public void UsuwanieElementuOstatniego()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.RemoveLast();

            Assert.AreEqual(lista.First, lista.Last);

        }

        [TestMethod]
        public void UsuwanieElementu()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Remove("Marcin");

            Assert.AreEqual("Tomek", lista.Last.Value);

        }

        [TestMethod]
        public void CzyListaZawieraElement()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");


            Assert.IsTrue(lista.Contains("Tomek"));
            Assert.IsTrue(lista.Contains("Marcin"));

        }

        [TestMethod]
        public void CzyszczenieListy()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Clear();


            Assert.AreEqual(0, lista.Count);
            

        }




    }
}
