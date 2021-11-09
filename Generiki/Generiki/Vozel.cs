using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    class Vozel<K,T>
    {
        public K Key;
        public T Item;
        public Vozel<K, T> Naslednji;
        public Vozel()
        {
            Key = default(K);
            Item = default(T);
            Naslednji = null;
        }
        public Vozel(K ka, T t, Vozel<K, T> v)
        {
            Key = ka;Item = t;Naslednji = v;
        }
    }
}
