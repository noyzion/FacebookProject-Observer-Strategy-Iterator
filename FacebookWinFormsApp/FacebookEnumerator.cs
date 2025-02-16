using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FacebookEnumerator<T> : IEnumerator<T>
    {
        private readonly List<T> r_Items;
        private int m_CurrentIndex = -1;

        public FacebookEnumerator(List<T> i_Items)
        {
            r_Items = i_Items ?? throw new ArgumentNullException(nameof(i_Items));
        }
        public T Current => r_Items[m_CurrentIndex];
        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            return ++m_CurrentIndex < r_Items.Count;
        }
        public void Reset()
        {
            m_CurrentIndex = -1;
        }
        public void Dispose()
        {
            m_CurrentIndex = -1;
        }
    }
}