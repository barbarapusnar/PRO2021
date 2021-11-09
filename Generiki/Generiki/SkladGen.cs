using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    class SkladGen<T>
    {
        int m_size;
        T[] m_Items; //vsebina sklada
        int m_StackPointer = 0; //vrh sklada
        public SkladGen(int v)
        {
            m_size = v;
            m_Items = new T[v];
        }
        public SkladGen() : this(100)
        {
        }
        public void Push(T item) //item doda na vrh sklada
        {
            if (m_StackPointer >= m_size)
                throw new Exception("Sklad je poln");
            m_Items[m_StackPointer] = item;
            m_StackPointer++;
        }
        public T Pop()//vrne element iz vrha sklada
        {
            m_StackPointer--;
            if (m_StackPointer >= 0)
                return m_Items[m_StackPointer];
            throw new Exception("Sklad je prazen");
        }
    }
}
