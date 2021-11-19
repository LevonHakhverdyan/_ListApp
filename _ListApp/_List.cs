using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ListApp
{
    public class _List
    {
        private int[] _items;
        private int _capacity = 0;
        private int _defaultCapacity = 4;
        private int[] _temp;
        private int _version;
        

        public int Count { get => _version; }
        public _List(int capacity)
        {
            _items = new int[capacity];
            _capacity = capacity;
        }
        public _List()
        {

        }

        public int this[int i]
        {
            get
            {
                if (i >= _version)
                    throw new IndexOutOfRangeException();
                return _items[i];
            }
            set
            {
                if (i >= _capacity)
                    throw new IndexOutOfRangeException();
                _items[i] = value;
                _version++;
            }
        }
        public void Add(int value)
        {
            InsureCapacity();
            _items[_version++] = value;
        }
        public override string ToString()
        {
            return $"Count={Count}";
        }
        private void InsureCapacity()
        {
            if (_capacity == 0)
            {
                _capacity = _defaultCapacity;
                _items = new int[_defaultCapacity];
            }

            if (_version >= _capacity)
            {
                _capacity *= 2;
                _temp = new int[_items.Length];
                for (int i = 0; i < _items.Length; i++)
                {
                    _temp[i] = _items[i];
                }
                //Array.Copy(_itime, 0, _temp, 0, _itime.Length);
                _items = new int[_capacity];
                for (int i = 0; i < _temp.Length; i++)
                {
                    _items[i] = _temp[i];
                }
                _temp = null;
            }
        }
    }
}
