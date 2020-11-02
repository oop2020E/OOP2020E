using System.Collections.Generic;

namespace KG06Exercises
{
    #region Exercise 5
    public class Dict<K, V>
    {
        List<Pair<K, V>> data = new List<Pair<K, V>>();
        public V Get(K key)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Fst.Equals(key))
                {
                    return data[i].Snd;
                }
            }

            throw new KeyNotFoundException($"[{key}] not found");
        }

        public void Set(K key, V val)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Fst.Equals(key))
                {
                    data[i] = new Pair<K, V>(key, val);
                    return;
                }
            }
            data.Add(new Pair<K, V>(key, val));
        }
    }
    #endregion
}
