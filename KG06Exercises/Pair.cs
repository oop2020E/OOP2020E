namespace KG06Exercises
{


    #region Exercise 2

    public class Pair<T1, T2>
    {
        public Pair(T1 fst, T2 snd)
        {
            Fst = fst;
            Snd = snd;
        }
        public T1 Fst { get; }
        public T2 Snd { get; }

        #region Exercise 3
        public Pair<T2, T1> Swap() => new Pair<T2, T1>(Snd, Fst);
        #endregion
        #region Exercise 4
        public Pair<C, T2> SetFst<C>(C val) => new Pair<C, T2>(val, Snd);
        public Pair<T1, C> SetSnd<C>(C val) => new Pair<T1, C>(Fst, val);
        #endregion

    }
    #endregion

}
