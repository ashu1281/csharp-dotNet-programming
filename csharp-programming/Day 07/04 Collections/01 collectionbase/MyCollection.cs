using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming {
    public class MyCollection : CollectionBase
    {
        public void Add(object item) {
            List.Add(item);
        }

        public void Remove(object item) { 
            List.Remove(item);
        }
        public object this[int index]
        {
            get { return List[index]; }
            set { List[index] = value; }
        }
    }
}
