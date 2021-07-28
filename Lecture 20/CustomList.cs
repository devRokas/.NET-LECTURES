using System.Collections;
using System.Collections.Generic;

namespace Lecture_20
{
    public class CustomList<T>
    {
        public int Length
        {
            get { return _index; }
        }
        
        private T[] _items;
        private int _index;

        public CustomList()
        {
            _items = new T[10];
            _index = 0;
        }

        public void Add(T item)
        {
            _items[_index] = item;
            _index++;
        }

        public T Get(int index)
        {
            return _items[index];
        }
    }
}