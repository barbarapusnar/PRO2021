using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    class Sklad
    {
        int m_size;
        object[] m_Items; //vsebina sklada
        int m_StackPointer = 0; //vrh sklada
        public Sklad(int v)
        {
            m_size = v;
            m_Items = new object[v];
        }
        public Sklad():this(100)
        { 
        }
        public void Push(object item) //item doda na vrh sklada
        {
            if (m_StackPointer >= m_size)
                throw new Exception("Sklad je poln");
            m_Items[m_StackPointer] = item;
            m_StackPointer++;
        }
        public object Pop()//vrne element iz vrha sklada
        {
            m_StackPointer--;
            if (m_StackPointer >= 0)
                return m_Items[m_StackPointer];
            throw new Exception("Sklad je prazen");
        }
    }
}
