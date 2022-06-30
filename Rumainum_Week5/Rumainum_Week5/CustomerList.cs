using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumainum_Week5
{
    public class CustomerList<T> : IEnumerable <T>
    {
        private List<T> list = new List<T>();

        // an add method
        public void Add(T item) => list.Add(item);

        // a read-only indexer
        public T this[int i] => list[i];

        // Other members for implementation of IEnumerable<> interface
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }

        // Other members for implementation of IEnumerable<> interface
        System.Collections.IEnumerator
            System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // the ToString method
        public override string ToString()
        {
            string listString = "";
            for (int i = 0; i < list.Count; ++i)
            {
                listString += list[i].ToString() + "\n";
            }
            return listString;
        }
    }
}
