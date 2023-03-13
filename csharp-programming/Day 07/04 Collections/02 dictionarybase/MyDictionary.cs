using System.Collections;

namespace csharp_programming
{
    public class MyDictionary : DictionaryBase
    {
        public void Add(object key, object value) { 
            Dictionary.Add(key, value);
        }

        public void Remove(object key)
        {
            Dictionary.Remove(key);
        }
        
        public object this[object key]
        {
            get { return Dictionary[key]; }
            set { Dictionary[key] = value; }
        }
    }
}
