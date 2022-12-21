namespace ClassLibrary1
{
    public class ExtendedDictionaryElement<T, U, V>
    {
        public T key { set; get; }
        public U value1 { set; get; }
        public V value2 { set; get; }
    }

    public class ExtendedDictionary<T, U, V>
    {
        protected List<ExtendedDictionaryElement<T, U, V>> dict = new List<ExtendedDictionaryElement<T, U, V>>();
        public void Add(T key, U val1, V val2)
        {
            foreach (ExtendedDictionaryElement<T, U, V> i in dict)
            {
                if (object.Equals(i.key, key))
                {
                    Console.WriteLine("Key exists");
                    return;
                }
            }
            ExtendedDictionaryElement<T, U, V> line = new ExtendedDictionaryElement<T, U, V>();
            line.key = key;
            line.value1 = val1;
            line.value2 = val2;
            dict.Add(line);
        }
        public void Print()
        {
            foreach (ExtendedDictionaryElement<T, U, V> i in dict)
            {
                Console.WriteLine($"{i.key} - {i.value1} - {i.value2}");
            }
        }
        public void Remove(T key)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                if (object.Equals(dict[i].key, key))
                {
                    dict.RemoveAt(i);
                    return;
                }
            }
        }

        public void isExistKey(T key)
        {
            int iss = 0;
            int ind = 0;
            for (int i = 0; i < dict.Count; i++)
            {
                if (object.Equals(dict[i].key, key))
                {
                    iss++;
                    ind = i;
                }
            }
            if (iss == 0)
                Console.WriteLine("Key does not exist");
            else
                Console.WriteLine($"Key exist - index: {ind}");
        }

        public int Count()
        {
            return dict.Count;
        }
        public void ExistValues(U value1, V value2)
        {
            int ind = 0;
            bool ter = false;
            for (int i = 0; i < dict.Count; i++)
            {
                if ((object.Equals(dict[i].value1, value1)) && (object.Equals(dict[i].value2, value2)))
                {
                    ind = i;
                    ter = true;
                }
            }
            if (ter)
            {
                Console.WriteLine($"Value ({value1}) and Value ({value2}) is at Key[{ind}]");
            }
            else
                Console.WriteLine($"Value ({value1}) and Value ({value2}) don't not exist");
        }

        private int ind = 0;
        public ExtendedDictionaryElement<T, U, V> this[T key]
        {
            get
            {
                for (int i = 0; i < dict.Count; i++)
                {
                    if (object.Equals(dict[i].key, key))
                    {

                        ind = i;
                    }
                }
                return dict[ind];
            }
        }
        public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator()
        {
            for (int i = 0; i < dict.Count; i++)
            {
                yield return dict[i];
            }
        }
    }
}
