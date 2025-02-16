using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BasicFacebookFeatures
{
    public class FacebookCollection<T> : IEnumerable<T>
    {
        private readonly List<T> r_Items;

        public FacebookCollection(List<T> i_Items)
        {
            r_Items = i_Items ?? new List<T>();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new FacebookEnumerator<T>(r_Items);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}