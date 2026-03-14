namespace _4_metodyDelegatyGeneryczne
{
    public interface IKolejka<T>: IEnumerable<T>
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);


        //IEnumerable <Twyjscie> ElementJako<Twyjscie>();

        

    }
}